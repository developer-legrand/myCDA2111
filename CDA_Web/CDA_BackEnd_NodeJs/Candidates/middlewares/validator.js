const { body } = require('express-validator')

exports.candidateValidator = [
    body('lastname')
        .notEmpty().withMessage("Champ requis")
        .isLength({min: 2}).withMessage("Taille minimale de 2 caractères")
        .matches(/^[a-zA-ZÀ-ÿ]+([ -][a-zA-ZÀ-ÿ]+)*$/).withMessage("format du nom erreur")
        .exists({checkFalsy:false}).withMessage("le candidat existe déjà"),
    body('firstname')
        .notEmpty().withMessage("Champ requis")
        .isLength({min: 2}).withMessage("Taille minimale de 2 caractères")
        .matches(/^[a-zA-ZÀ-ÿ]+([ -][a-zA-ZÀ-ÿ]+)*$/).withMessage("format du prénom erreur"),
    body('slogan').isLength({min: 5, max: 45}).withMessage("Taille minimale de 5 caractères et 45 maximum")
]