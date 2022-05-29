const { body } = require('express-validator')

exports.entriesValidator = [
    body ('dateDay')
        .notEmpty().withMessage("Champ requis")
        .isDate('dd MMMM yyyy')
]
