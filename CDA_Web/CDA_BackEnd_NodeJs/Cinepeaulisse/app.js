// importer le module express
const express = require('express')

// application express
const app = express()

// analyse le contenu du corps des requêtes
app.use(express.urlencoded())
app.use(express.json())

// middleware : s'exécute à chaque requête
app.use((req, res, next) => {
    let method = req.method;
    let path = req.originalUrl;
    console.log(`${method} ${path}`);
    next()
})

// import des routes (voir le fichier routes/index.js)
const router = require('./routes')
// association du router à l'app
app.use('/', router)

//fonction anonyme
//démarrage du serveur
app.listen(3000, () => {
    console.log(`Application should be ready on port 3000: http://localhost:3000/movie`)
    console.log(`Application should be ready on port 3000: http://localhost:3000/entries`)
    console.log(`Application should be ready on port 3000: http://localhost:3000/entriesMovieOrderDate`)
    console.log(`Application should be ready on port 3000: http://localhost:3000/entries/addMovieEntries`)
})