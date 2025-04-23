const fs = require('fs');
if (!fs.existsSync('./temp')) {
    fs.mkdir('./temp', (err) => {
        if (err) {
        console.log(err);
        }
        console.log('kansio luotu');
    });
    } else {
        fs.rmdir('./temp', (err) => {
            if (err) {
                console.log(err)
            }
            console.log('kansio poistettu');
        })
    }