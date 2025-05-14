const express = require('express');
const morgan = require('morgan')
const mongoose = require('mongoose');

const app = express();

//yhteys mongodb
const mango = 'mongodb+srv://lauraknuuti:Sateenvarjo1987@mongocluster.ox06chx.mongodb.net/?retryWrites=true&w=majority&appName=mongoCluster'

mongoose.connect(mango, { useNewUrlParser: true, useUnifiedTopology: true })
  .then(() => console.log('Yhdistetty MongoDB:hen'))
  .catch((err) => console.log('Virhe yhdistäessä MongoDB:hen:', err));

app.set('views', __dirname);
app.set('view engine', 'ejs')

//kuuntelee yhteydenottoja
app.listen(3000);


//middleware testausta
app.use((req, res, next) => {
    console.log('new request made');
    console.log('host: ', req.hostname);
    console.log('path ', req.path);
    console.log('method: ', req.method);
    next();
});

app.use((req, res, next) => {
    console.log('in the next middleware');
    next();

});

app.use(express.static('public'));
//end

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

app.use((req, res) => {
    res.status(404).render('404', { title: '404'  })
});
