const express = require('express');
const mongoose = require('mongoose');
const kayttaja = require('./models/user');

const app = express();

//yhteys mongodb
const mango = 'mongodb+srv://lauraknuuti:Sateenvarjo1987@mongocluster.ox06chx.mongodb.net/mongoDB?retryWrites=true&w=majority&appName=mongoCluster'

mongoose.connect(mango)
  .then(() => console.log('Yhdistetty MongoDB:hen'))
  .catch((err) => console.log('Virhe yhdistäessä MongoDB:hen:', err));

app.set('views', __dirname);
app.set('view engine', 'ejs')

//kuuntelee yhteydenottoja
app.listen(3000);

//css(taustaväri...)
app.use(express.static('public'));


app.get('/', (req, res) => {
    const blogit =    	[
        {title: 'Kissa nukkuu', esittely: 'Lorem ipsum dolor sit amet consectetur adipiscing elit. Quisque faucibus ex sapien vitae pellentesque sem placerat. In id cursus mi pretium tellus duis convallis.'},
        {title: 'Kissa syö', esittely: 'Lorem ipsum dolor sit amet consectetur adipiscing elit. Quisque faucibus ex sapien vitae pellentesque sem placerat. In id cursus mi pretium tellus duis convallis.'},
        {title: 'Kissa juo', esittely: 'Lorem ipsum dolor sit amet consectetur adipiscing elit. Quisque faucibus ex sapien vitae pellentesque sem placerat. In id cursus mi pretium tellus duis convallis.'},
    ]
    res.render('index', { title: 'Koti', blogit });

});

app.get('/meista', (req, res) => {
    res.render('meista', { title: 'Meistä'  } );
});

app.get('/blogit/luo', (req, res) => {
    res.render('luo', { title: 'Luo uusi blogi'  });
})

const User = require('./models/user');

// Uuden käyttäjän luonti
app.get('/luo-kayttaja', (req, res) => {
    console.log("Moi pääsin perille");
  const uusiKayttaja = new User({
    name: 'Laura',
    age: 39,
    email: 'laura@example.com'
  });

    uusiKayttaja.save()
    .then((tulos) => {
      console.log('Tallennettu käyttäjä:', tulos);
      res.send('Käyttäjä tallennettu!');
    })
    .catch((err) => {
      console.log('Virhe tallennuksessa:', err);
      res.status(500).send('Tallennus epäonnistui.');
    });
});

app.get('/add-user', (req, res) => {
    const testi = new User()
})

//aina viimeiseksi
app.use((req, res) => {
    res.status(404).render('404', { title: '404'  }) });
