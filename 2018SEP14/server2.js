var express = require('express');
var app = express();

app.get('/', function(req, res){
    res.end('hello from Express!! eller nått...');
});

var server = app.listen(8088, function(){
    var host = server.address().address;
    var port = server.address().port;

    console.log('server running at http://%s%s', host, port);
    
})