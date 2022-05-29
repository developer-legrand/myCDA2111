const db = require('./index')

class Repository{
    constructor(_db) 
    {
        this.db = _db
    }
    //sélectionne toutes les données du fichier json
    getAll(sql, params = []) {
        return new Promise((resolve, reject) => {
            this.db.all(sql, params, (err, rows) => {
                if(err) {
                    console.error('Erreur SQL : ' + err)
                    reject(err)
                } else { 
                    //console.log(rows)
                    resolve(rows)
                }
            })
        })
    }
    
    getById(sql, params = []) {
        return new Promise((resolve, reject) => {
            this.db.get(sql, params, (err, row) => {
                if(err) {
                    console.error('Erreur SQL : ' + err)
                    reject(err)
                } else { 
                    //console.log(rows)
                    resolve(row)
                }
            })
        })
    }

    execute(sql, params = []) {
        return new Promise((resolve, reject) => {
            this.db.run(sql, params, (err, result) => {
                if(err) {
                    console.error('Erreur SQL : ' + err)
                    reject(false)
                } else { 
                    resolve(true)
                }
            })
        })
    }
}        
module.exports = new Repository(db);
    
 

