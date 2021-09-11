const express = require('express');

const app = express()
app.use(express.json());
const port = 3000;

const items = []

app.get('/', (req, res) => {
  res.send('Hello World!')
})

app.post('/fruits', (req, res) => {
    console.log("Posting Fruit");
    const body = req.body;
    console.log(body);
    items.push(body.fruit);
    res.send(body.fruit);
})

app.get('/fruits', (req, res) => {
    res.send(items)
})

app.listen(port, function(err) {
  if (err) console.log(err);
  console.log(`Example app listening at http://localhost:${port}`)
})