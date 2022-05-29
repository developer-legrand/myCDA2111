const repo = require('./repository')

module.exports = {
    getAllMovies(){
        const sql = `SELECT movieId, title, duration FROM movie`
        return repo.getAll(sql)
    },
    
    getAllEntries(){
        const sql = `SELECT entriesId, dateDay, entriesNumber, movieId FROM entries`
        return repo.getAll(sql)
    },

    orderMovieEntries(){
        const sql = `SELECT  movie.title, entries.dateDay, entries.entriesNumber FROM entries INNER JOIN movie WHERE entries.movieId = movie.movieId
        ORDER BY dateDay DESC`
        return repo.getAll(sql)
    },

    /**
    * Crée un candidat
    * @param {Object} uhu { dateDay: Integer, entriesNumber: Integer, movieId: Integer }
    * @returns {Promise}
    */
    addEntriesMovie(uhu) {
        const sql = `INSERT INTO entries (dateDay, entriesNumber, movieId) VALUES (?, ?, ?)`
        const params = [uhu.dateDay, uhu.entriesNumber, uhu.movieId]
        return repo.execute(sql, params)
    },

    checkDateMovie(id) {
        const sql = `SELECT entriesId, dateDay, entriesNumber, movieId
                     FROM entries WHERE movieId=?`
        const params = [id]
        return repo.getAll(sql, params)
    }
}