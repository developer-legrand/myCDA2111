// exports URL conditions name

exports.index = (req, res) => {
    res.send('Accueil')
}

exports.about = (req, res) => {
    res.send('A propos')
    
}

exports.sayHello = (req, res) => {
    let name = req.params.name
    console.log(req.params)
    res.send(`Bonjour ${name}`)
}