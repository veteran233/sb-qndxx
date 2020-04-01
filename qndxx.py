import requests
import webbrowser
from bs4 import BeautifulSoup as bs

s=input()
a,b=s.split(' ')

#http://h5.cyol.com/special/daxuexi/daxuexi8z7/m.html?z=200

html=requests.get(
    "http://h5.cyol.com/special/daxuexi/daxuexi"+a+"a"+b+"/m.html?z=200",
    {"User-Agent" : "Mozilla/5.0 (Linux; Android 6.0.1; MuMu Build/V417IR; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/52.0.2743.100 Mobile Safari/537.36"}
    )

c=1
while (html.status_code==404):
    if (c+97>122):
        raise Exception("WTF?!")
    html=requests.get(
    "http://h5.cyol.com/special/daxuexi/daxuexi"+a+chr(97+c)+b+"/m.html?z=200",
    {"User-Agent" : "Mozilla/5.0 (Linux; Android 6.0.1; MuMu Build/V417IR; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/52.0.2743.100 Mobile Safari/537.36"}
    )
    c=c+1

x = bs(html.content,"lxml")

url = x.find("video")
url = url.get("src")

webbrowser.open(url)
