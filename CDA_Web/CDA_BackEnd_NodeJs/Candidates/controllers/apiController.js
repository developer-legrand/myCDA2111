
const repository = require('../db/candidatesrepository')

exports.getAll = async (req, res) => {
 
    try {
        let result = await repository.getAll()
        res.json(result)
        console.log('toto a réussi')
    } catch(err) {
        console.error(err)
        res.status(500).end()
    }
}

exports.getOne = async (req, res) => {
    try {
        const { id } = req.params
        let result = await repository.getOneId(id)
        if(result == undefined) {
            res.status(404).end()
        }
        res.json(result)
        console.log('toto a réussi')
    } catch(err) {
        console.error
        res.status(500).end()
    }

}

exports.createOne = async (req, res) => {
    console.log(req.body)
    const model = req.body
    //constrôle de saisie dans l'objet req.body
    let result = await repository.createId(model)
    res.json(result)
}

exports.removeOne = async (req, res) => {
    let { id } = req.params
    let result =  await repository.deleteId(id)
    res.status(404).end()
    
}

exports.modifyOne = async (req, res) => {
    const model = req.body
    let id = req.params
    let result =  await repository.updateId(id, model)
    res.json(result)
    res.status(404).end() 
}

exports.getMySelectId = async (req, res) => {
    try {
        console.log(req.params)
        let { mySelectId } = req.params
        mySelectId = mySelectId.split(',')
        console.log(mySelectId)
        let result = await repository.getManyId(mySelectId)
        res.json(result)
        console.log('toto a réussi')
        
    } catch(err) {
        console.error
        res.status(500).end()
        console.log('toto a tout cassé')
        
    }
    
}







