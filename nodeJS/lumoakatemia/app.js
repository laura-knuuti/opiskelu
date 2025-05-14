const express = require('express');

const app = express();

app.set('views', './assets');
app.set('view engine', 'ejs')

//kuuntelee yhteydenottoja
app.listen(3000);


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
