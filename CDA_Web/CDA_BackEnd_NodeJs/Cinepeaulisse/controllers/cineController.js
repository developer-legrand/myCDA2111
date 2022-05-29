const repo = require('../models/cineRepository')
const { validationResult } = require('express-validator')
module.exports = {
    async getAllMovie (req, res) {
        try {
            let result = await repo.getAllMovies()
            res.send(result);
        } catch (err) {
                res.status(500).send()
        }
    },

    async getAllEntries (req, res) {
        try {
            let result = await repo.getAllEntries()
            res.send(result);
        } catch (err) {
                res.status(500).send()
        }
    },

    async getEntriesOrderDate (req, res) {
        try {
            let result = await repo.orderMovieEntries()
            
            res.send(result);
        } catch (err) {
                res.status(500).send()
        }
    },

    // async postEntriesMovie(req, res) {
    //     const validationErrors = validationResult(req)
    //     if(!validationErrors.isEmpty()){
    //         console.log(validationErrors.mapped())
    //         res.send('erreur de format')
    //     }else {
    //         let model = req.body
    //         await repo.addEntriesMovie(model)
    //         res.send('requête effectuée avec succés')
    //     }
    // },

    async postEntriesMovie(req, res) {
        try {
            let model = req.body
            console.log(req.body)
            await repo.addEntriesMovie(model)
            // let dateSplit = model.dateDay
            // dateSplit = dateSplit.split(' ')
            // let day = dateSplit[0]
            // let month = dateSplit[1]
            // let year = dateSplit[2]
            // let stringDate = day + ' ' + month + ' ' +  year
            // let formatDate = new Date(stringDate)
            // formatDate = formatDate.toLocaleDateString("fr")
            // console.log('formatDate : ' + formatDate)
            // console.log('----------------------')
            // console.log('concat : ' + stringDate)
            // console.log('----------------------')
            // console.log('split : ' + dateSplit)
            // console.log('day : ' + day)
            // console.log('month : ' + month)
            // console.log('year : ' + year)
            res.send('requête effectuée avec succés')
        } catch (err) {
                res.status(500).send()
        }
    },
    async getDateMovie (req, res) {
        try {
            console.log(req.params)
            let result = await repo.checkDateMovie(req.params.id) 
            res.send(result);
        } catch (err) {
                res.status(500).send()
        }
    }

}