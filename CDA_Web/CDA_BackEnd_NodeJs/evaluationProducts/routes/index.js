const express = require('express')
const router = express.Router()

router.get('/', (req, res) => {
    res.redirect('/productions')
})


module.exports = router
