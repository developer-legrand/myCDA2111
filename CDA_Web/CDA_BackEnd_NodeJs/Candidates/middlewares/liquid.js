const { Liquid } = require('liquidjs')
const path = require('path')

const viewPath = path.join(__dirname,'../',  'views')


module.exports = (app) => {
    const viewEngine = new Liquid({
        root: path.join(viewPath),
        extname: '.html'
    })

    app.engine('html', viewEngine.express())
    app.set('view engine', 'html')
}