import gzip
import json
from mitmproxy import http

SERVER_HOST = 'YOUR_SERVER_HERE'
SERVER_PORT = 80

REWRITE_HOST_LIST = [
    'ba-jp-sdk.bluearchive.jp',
    'prod-gateway.bluearchiveyostar.com',
    'prod-game.bluearchiveyostar.com',
    # 'prod-notice.bluearchiveyostar.com',
    # 'prod-logcollector.bluearchiveyostar.com',
]

def request(flow: http.HTTPFlow) -> None:
    if flow.request.pretty_host.endswith('log.aliyuncs.com'):
        flow.kill()
        return
    if flow.request.pretty_host in REWRITE_HOST_LIST:
        flow.request.scheme = 'http'
        flow.request.host = SERVER_HOST
        flow.request.port = SERVER_PORT
        return

def response(flow: http.HTTPFlow) -> None:
    if flow.request.url.endswith('/api/gateway'):
        try:
            req = flow.request.raw_content
            res = json.loads(flow.response.text)
            protocol = res['protocol']

            mx_end = req.rfind(b'\r\n', 0, len(req) - 1)
            mx_start = req.rfind(b'\r\n\r\n')
            req_mx = req[mx_start + 4:mx_end]
            req_bytes = req_mx[12:]
            req_bytes = bytearray([x ^ 0xD9 for x in req_bytes])
            req_bytes = gzip.decompress(req_bytes)
            print(f'Protocol: {protocol}')
            print(f'[OUT]->{json.loads(req_bytes)}')
            print(f'[IN]<--{json.loads(res["packet"])}')
            print('')
        except Exception as e:
            print('Failed to dump packet', e)
        return
