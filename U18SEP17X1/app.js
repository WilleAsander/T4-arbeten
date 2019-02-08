var express = require('express');
var app = express();

app.get('/', function(req, res){
    res.end('Welcome to my web server!');
});

var server = app.listen(8088, function(){
    var host = server.address().address;
    var port = server.address().port;

    console.log('server started, listening on port 8088');
    
})