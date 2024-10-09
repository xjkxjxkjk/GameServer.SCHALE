# Redirect server via mitmproxy

## Install mitmproxy

Download the installer from [mitmproxy.org](https://mitmproxy.org/)

## Install CA certificate

Follow the instructions from [System CA on Android Emulator](https://docs.mitmproxy.org/stable/howto-install-system-trusted-ca-android/)

## Hook client with mitmproxy

Set your server address and port in `redirect_server.py`

Install [WireGuard](https://wireguard.com/install/#android-play-store-f-droid) on client, then run mitmproxy:

```
mitmweb -m wireguard --no-http2 -s redirect_server.py --set termlog_verbosity=warn
```

It also works as a packet dumper. You can save the flow file for further works.
