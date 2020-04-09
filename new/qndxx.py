from requests import get
from webbrowser import open
from bs4 import BeautifulSoup as bs

h_code = get("http://news.cyol.com/node_67071.htm")

code = bs(h_code.content, "lxml").find('a', 'transition').get("href").split('/')[5]

html = get(
    "http://h5.cyol.com/special/daxuexi/" + code + "/m.html?z=200",
    {"User-Agent" : "Mozilla/5.0 (Linux; Android 6.0.1; MuMu Build/V417IR; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/52.0.2743.100 Mobile Safari/537.36"}
    )

url = bs(html.content, "lxml").find("video").get("src")

open(url)
