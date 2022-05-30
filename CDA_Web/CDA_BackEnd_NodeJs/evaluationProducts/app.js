const express = require('express');
const bodyParser = require('body-parser')

const app = express();

app.use(bodyParser.urlencoded({ extended: false }))
//app.use(bodyParser.json())

// chaque requête est inscrite dans la console du serveur
app.use((req, res, next) => {
    let method = req.method;
    let path = req.originalUrl;
    let body = req.body;
    console.log(`${method} ${path}`, body);
    next()
})

const router = require('./routes')

app.use('/', router)

app.listen(80, () => {
    console.log("Serveur prêt (http://localhost:80)")
});
