const express = require('express');

const app = express();

//kuuntelee yhteydenottoja
app.listen(3000);

app.get('/', (req, res) => {
    res.sendFile('./assets/index.html', { root: __dirname });

});

app.get('/meista', (req, res) => {
    res.sendFile('./assets/meista.html', { root: __dirname});
});

app.get('/minusta', (req, res) => {
    res.redirect('/meista');
});

app.use((req, res) => {
    res.sendFile('/assets/404.html', { root: __dirname } )
})
