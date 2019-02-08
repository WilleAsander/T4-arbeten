var express = require('express');
var bodyParser = require('body-parser');

var app = express();

var product = require('./routes/product.route');

var mongoose = require('mongoose');
var db_url = 'mongodb://dbuser:Willeka12@ds155823.mlab.com:55823/te4-papp';
mongoose.connect( db_url, {useNewUrlParser: true});
mongoose.Promise = global.Promise; //Vi ska prata om detta senare!
var db = mongoose.connection;
db.on('error', console.error.bind(console, 'MongoDB connection error: '));

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended: false}));

app.use('/products', product);

app.listen('4242', function() {
    console.log('Server up and running');
});

