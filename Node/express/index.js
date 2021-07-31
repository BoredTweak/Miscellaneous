const express = require('express')
, bodyParser = require('body-parser')

const app = express()
app.use(bodyParser.json());
const port = 3000

const items = []

app.get('/', (req, res) => {
  res.send('Hello World!')
})

app.post('/fruits', (req, res) => {
    console.log(req.body)
    items.push(req.body)
    res.send('Success!')
})

app.get('/fruits', (req, res) => {
    res.send(items)
})

app.listen(port, () => {
  console.log(`Example app listening at http://localhost:${port}`)
})