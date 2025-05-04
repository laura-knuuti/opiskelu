const fs = require('fs');
            const readStream = fs.createReadStream('./lorem.txt');
            const writeStream = fs.createWriteStream('./blog4.txt')
            
            readStream.pipe(writeStream);