const repo = require('./repository')

// const db = require('./index')


exports.getAll = () => {
    const sql = `SELECT id, lastname, firstname, slogan FROM candidates`
    return repo.getAll(sql)
}
    
exports.getOneId = (id) => {
    const sql = `SELECT id, lastname, firstname, slogan FROM candidates WHERE id=?`
    const params = [id]
    return repo.getById(sql, params);
}

/**
 * Crée un candidat
 * @param {Object} model { lastname: String, firstname: String, slogan: String }
 * @returns {Promise}
 */
 exports.createId = (model) => {

    const sql = `INSERT INTO candidates (lastname, firstname, slogan) VALUES (?, ?, ?)`
    const params = [model.lastname, model.firstname, model.slogan]
    return repo.execute(sql, params)
}

/**
 * Modifie un candidat
 * @param {Object} model { lastname: String, firstname: String, slogan: String, id: Int }
 * @returns {Promise}
 */
 exports.updateId = (model) => {
    const sql = `UPDATE candidates SET lastname=?, firstname=?, slogan=? WHERE id=?`
    const params = [model.lastname, model.firstname, model.slogan, model.id]
    return repo.execute(sql, params)
}


/**
 * Supprime un candidat
 * @param {Int} id Identifiant du candidat à supprimer 
 * @returns {Promise}
 */
 exports.deleteId = (id) => {
    const sql = `DELETE FROM candidates WHERE id=?`
    const params = [id]
    return repo.execute(sql, params)
}

/**
 * 
 * @param {array} mySelectId 
 * @returns 
 */
exports.getManyId = (model) => {
    console.log(model.check + ' toto')
    let marqueurs = '?'
    let checkSelectId = []
    model.check.forEach(id => {
        checkSelectId.push(marqueurs)
    })
    checkSelectId.join(',')
    const sql = `SELECT id, lastname, firstname, slogan FROM candidates WHERE id IN (${checkSelectId})`
    const params =  model.check
    return repo.getAll(sql, params)
}

    // let uhu = document.querySelector(nameCheckBox).value
    // checkSelectId = []
    // nameTable.forEach(uhu => {
    //     marqueurs.push('?')
    // })
    // marqueurs.join(',')
    // const sql = `SELECT id, lastname, firstname, slogan FROM candidates WHERE id IN (${marqueurs})`
    // return repo.getAll(sql, checkSelectId)
