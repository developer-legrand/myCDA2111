const express = require('express')
const router = express.Router()

//import Validator
const validator = require('../middlewares/validator')
//HOME CONTROLLER
const homeController = require('../controllers/homeController')
router.get('/', homeController.home)
//CINE CONTROLLER
const cineController =  require('../controllers/cineController')

router.post('/entries/addMovieEntries', cineController.postEntriesMovie)
router.get('/entriesMovieOrderDate', cineController.getEntriesOrderDate)

router.get('/movie', cineController.getAllMovie)
router.get('/entries', cineController.getAllEntries)

router.get('/dateByMovieId/:id', cineController.getDateMovie)

//erreur 404 toujours en dernier
router.all('*', (req, res) => {
    res.status(404).send('Erreur 404 : page non trouvée')
})

module.exports = router