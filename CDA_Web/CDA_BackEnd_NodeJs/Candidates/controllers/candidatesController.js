/* 
        index    lister les candidats (accueil du controleur)
        getById    afficher les détails d'un candidat
        add    ajouter un nouveau candidat
        update   modifier un candidat existant
        remove    supprimer un candidat existant
*/

const { validationResult } = require('express-validator')
const repo = require('../db/candidatesRepository')

module.exports = {
    async index (req, res) {
        try {
            let result = await repo.getAll()
            res.render('index',{ model : result })
            // res.send(result);
        } catch (err) {
                res.status(500).send()
        }
    },

     async getById (req, res) {
        try {
            let result = await repo.getOneId(req)
            res.render('index',{ model : result })
        } catch (err) {
                res.status(500).send()
        }
    },

    async add_view (req, res) {
        res.render('candidate_add')
    },

    async add_post (req, res) {  
        const validationErrors = validationResult(req)
        if(!validationErrors.isEmpty()){
            console.log(validationErrors.mapped())
            res.render('candidate_add', {errors: validationErrors.mapped(), model: req.body})
           
        }else {
            let model = req.body
            let result = await repo.createId(model)
            res.redirect('/candidates')
        }     
    },

    async update_view (req, res) {
        let result = await repo.getOneId(req.params.id)
        res.render('candidate_edit', { model : result })
    },


    async update_post (req, res) {
        const validationErrors= validationResult(req)
        if(!validationErrors.isEmpty()){
            console.log(validationErrors.mapped())
            res.render('candidate_edit', {errors: validationErrors.mapped(), model: req.body})
        }else {
            const model = req.body
            let result =  await repo.updateId(model)
            res.redirect('/candidates')
        }
    },

    async remove_view (req, res) {
        let result = await repo.getOneId(req.params.id)
        res.render('candidate_delete', { model : result })
    },

    async remove_post (req, res) {
        await repo.deleteId(req.params.id)
        console.log(req.params.id)
        res.redirect('/candidates')
    },
 
    async select_post (req, res) {
        try{
            console.log('test')
            console.log(req.body.check)
            console.log(req.body)
            console.log(req.body.toto)
            console.log('test')
            const myButtonValue = req.body.toto
            
            if (myButtonValue === 'Select') {
                if(req.body.check.length > 1){
                    let result = await repo.getManyId(req.body)
                    console.log(result)
                    res.render('candidate_select', { model : result }) 
                }else {
                    let id = req.body.check
                    let result = await repo.getOneId(id)
                    console.log(id + ' toto')
                    console.log(result)
                    res.render('candidate_select',{ model : [result] })
                
                }
            }
        }catch (err) {
            console.log('toto a tout cassé')
            res.status(500).send()
        }
    }
}