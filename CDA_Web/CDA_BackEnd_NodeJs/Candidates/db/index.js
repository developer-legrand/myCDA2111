//import 
const sqlite3 = require('sqlite3') 
//Creer le chemin vers le ou les fichiers .db     
const path = require('path')            
//adapte le chemin selon l'OS (chemin absolu)
const dbpath = path.join(__dirname, "data", "votes.db")  
const db = new sqlite3.Database(dbpath, (err) => {
    if(err) {
        return console.error('Erreur SQL : ' + err)
    }
    console.log('Base de données connectée')
})


module.exports = db



