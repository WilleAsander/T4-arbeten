var Product = require('../models/product.model');

exports.test = function(req,res) {
    res.send('Hello from MVC and Node')
};

exports.product_create = function(req,res){
    var product = new product({
        name: req.body.name,
        price: req.body.price
    });

    product.save(function(error){
        //obs hantera error

        res.send('Product created');
    });
}