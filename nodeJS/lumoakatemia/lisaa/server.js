const express = require('express');

const app = express();

app.set('views', __dirname);
app.set('view engine', 'ejs')

//kuuntelee yhteydenottoja
app.listen(3000);

app.get('/Koti/:title', (req, res) => {
  const title = req.params.title;
  res.render('Koti', { title });
});


app.get('/NJ16', (req, res) => {
    res.render('NJ16', { Otsikko: 'Harjoitus',
      text: 'Tämä on muuttuja.', //NJ17
      elaimet: ['orava', 'kettu', 'pöllö'], //NJ18
      loggedin: false //NJ19
});
     });

     //NJ20 lomakkeelle
app.use(express.urlencoded({ extended: true }));
app.get('/lomake', (req, res) => {
  res.render('NJ20');
});

app.post('/lomake', (req, res) => {
  const nimi = req.body.nimi;
  res.send(`Lomake vastaanotettu`);
});

//NJ23 objekti
app.get('/kayttaja', (req, res) => {
    res.render('kayttaja', { kayttaja: kayttaja });
});

const kayttaja = {
    etunimi: 'Matti',
    sukunimi: 'Meikäläinen',
    ika: 30,
};

app.get('/NJ23', (req, res) => {
    res.render('NJ23', { 
        title: 'Käyttäjätiedot',
        kayttaja: kayttaja
    });
});

//NJ24
const hedelmat = ['omena', 'banaani', 'appelsiini', 'kiivi'];

app.get('/NJ24', (req, res) => {
  res.render ('NJ24', { hedelmat });
});