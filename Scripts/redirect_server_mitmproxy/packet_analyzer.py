#!/usr/bin/env python 
import argparse
import gzip
import json
import os

from mitmproxy import io
from mitmproxy.http import HTTPFlow

if __name__ == "__main__":
  parser = argparse.ArgumentParser('Flow dumper')
  parser.add_argument('file', type=str, help='mitmproxy flow file')
  args = parser.parse_args()

  os.makedirs(f'{args.file}.dumps', exist_ok=True)

  f = open(args.file, 'rb')
  r = io.FlowReader(f)

  i = 0
  for flow in r.stream():
    if not isinstance(flow, HTTPFlow):
      continue
    if not flow.request.url.endswith('/api/gateway'):
      continue

    req = flow.request.raw_content
    res = json.loads(flow.response.text)
    protocol = res['protocol']

    mx_end = req.rfind(b'\r\n', 0, len(req) - 1)
    mx_start = req.rfind(b'\r\n\r\n')
    req_mx = req[mx_start + 4:mx_end]
    req_bytes = req_mx[12:]
    req_bytes = bytearray([x ^ 0xD9 for x in req_bytes])
    req_bytes = gzip.decompress(req_bytes)

    packet = json.loads(req_bytes)
    with open(f'{args.file}.dumps/{i}_req_{protocol}.json', 'w') as f_req:
      json.dump(packet, f_req, indent=2, ensure_ascii=False)

    packet = json.loads(res['packet'])
    with open(f'{args.file}.dumps/{i}_resp_{protocol}.json', 'w', encoding='utf8') as f_res:
      json.dump(packet, f_res, indent=2, ensure_ascii=False)
    i += 1

  f.close()
