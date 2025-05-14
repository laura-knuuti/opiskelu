//NJ10-11

const http = require('http');
const fs = require('fs');

const server = http.createServer((req, res) => {
    res.setHeader('Content-Type', 'text/html');
    let path = './assets/';
    switch(req.url) {
        case '/':
            path += 'index.html';
            res.statusCode = 200;
            break;

        case '/meista':
            path += 'meista.html';
            res.statusCode = 200;
            break;

        case '/minusta':
                res.statusCode = 301;
                res.setHeader('Location', '/meista');
                res.end();
                break;
    

        default: path += '404.html';
            res.statusCode = 404;
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