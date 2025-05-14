const http = require('http');
const server = http.createServer((req, res) => {
    console.log('request made');
});

server.listen(3000, 'localhost', 'localhost', () => {
    console.log('listening for request on port 3000')
})

app.get('/teksti', (req, res) => {
  res.render('teksti', { text: 'Tämä on muuttuja.' });
});