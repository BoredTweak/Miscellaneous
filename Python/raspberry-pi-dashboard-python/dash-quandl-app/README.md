# Quandle Finance Dashboard App

Output/findings from research on making a Raspberry Pi Dashboard/Magic mirror.

Credit to [plotly](https://github.com/plotly/dash-stock-tickers-demo-app).

**Dash Stock Tickers Demo App Against Quandl**

This is a demo app using the Dash interactive Python framework(https://plot.ly/) adjusted to target Quandl (https://www.quandl.com/).

When you run `app.py`, it will say that the app is running on http://localhost:8050. However, by default it will be at http://localhost:8050/dash/gallery/stock-tickers. This can be configured by editing `base_url_pathname`.

Note the included setQuandlKey.ps1 file which will take an input Quandl api key and configure the dependent Environment variable on a windows machine.
