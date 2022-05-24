const express = require('express')
const router = express.Router()

const validator = require('../middlewares/validator')

const apiController = require('../controllers/apiController')
const homeController = require('../controllers/homeController')
const candidatesController  = require('../controllers/candidatesController')

//chemin de l'url avec des marqueurs '/hello/:name'
//HOME
router.get('/', homeController.index)
router.get('/about', homeController.about)
router.get('/hello/:name', homeController.sayHello)


//API CONTROLLER
router.get('/api', apiController.getAll)
router.get('/api/:id', apiController.getOne)
router.post('/api', apiController.createOne)
router.delete('/api/:id', apiController.removeOne)
router.put('/api/:id', apiController.modifyOne)
router.get('/api/select/:mySelectId' ,apiController.getMySelectId)


//CANDIDATES CONTROLLER

router.get('/candidates/edit/:id', candidatesController.update_view)
router.post('/candidates/edit/:id', validator.candidateValidator, candidatesController.update_post)


router.get('/candidates/delete/:id', candidatesController.remove_view)
router.post('/candidates/delete/:id', candidatesController.remove_post)

router.get('/candidates/add', candidatesController.add_view)
router.post('/candidates/add',validator.candidateValidator, candidatesController.add_post)

router.post('/candidates/mySelect', candidatesController.select_post)

router.get('/candidates/:id', candidatesController.getById)
router.get('/candidates', candidatesController.index)


//erreur 404 toujours en dernier
router.all('*', (req, res) => {
res.status(404).send('Erreur 404 : page non trouvée')
})

module.exports = router