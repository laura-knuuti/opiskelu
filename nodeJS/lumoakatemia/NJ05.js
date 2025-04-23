const fs = require('fs');
fs.writeFile('./blog2.txt', 'Kissani osaa olla ärsyttävä.', () => {
    console.log('Tämä tässä on teksti.');
});