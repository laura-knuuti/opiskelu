const express = require('express');
const app = express();
const port = 3000;

app.get('/', (req, res) => {
  res.send('Hei maailma!');
});

//NJ27
app.get('/about', (req, res) => {
  res.send('Tämä on About-sivu.');
});

//NJ28
app.get('/api/data', (req, res) => {
  const data = {
    nimi: 'Testikäyttäjä',
    ikä: 30,
    sähköposti: 'random@email.com'
  };

  res.json(data);
});

// Palvelimen käynnistys
app.listen(port, () => {
  console.log(`Palvelin käynnissä`);
});