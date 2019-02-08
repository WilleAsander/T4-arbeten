var express = require('express');
var router = express.Router();

var product_controller = require('../controllers/product.controller');

//test
router.get('/test', product_controller.test);
//Skapa en ny post i DB
router.post('/create', product_controller.product_create);

module.exports = router;