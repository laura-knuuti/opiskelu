const fs = require('fs');
const readStream = fs.createReadStream('./lorem.txt')
readStream.on('data', (chunk) => {
    console.log
})