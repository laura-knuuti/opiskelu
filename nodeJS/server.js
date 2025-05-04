const http = require('http');
const fs = require('fs');
const lo  = require('lodash');

const server = http.createServer((req, res) => {

//lodash
const num = lo.random(0, 20);
console.log(num);


//asetetaan header html-tyyppiseksi
res.setHeader('Content-Type', 'text/html');

let path = './';
switch(req.url) {
    case '/':
        path += 'index.html';
        res.statusCode = 200;
        break;
    case '/about':
        path += 'about.html';
        res.statusCode = 200;
        break;
    case '/about-us':
        res.statusCode = 301;
        res.setHeader('location', '/about');
        res.end();
        break;
    default:
        path += '404.html';
        res.statusCode = 400;
        break;
}

//luodaan ja lähetetään index.html
fs.readFile(path, (err, data) => {
if (err) {
    console.log(err);
    res.end();
} else {
    res.write(data);
    res.end()
    }
});

});
server.listen(3000, 'localhost', () => {
    console.log('listening for request on port 3000')
})