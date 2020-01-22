const ProductController = require('../controllers/product.controller');
module.exports = function(app){
    app.get('/api', ProductController.index);
    app.post('/api/product', ProductController.createProduct);
    app.get('/api/products', ProductController.getAll);
    app.get('/api/product/:_id', ProductController.getOne)
    app.put('/api/product/:_id', ProductController.updateObject)
}