var http = require("http");
http.createServer(function(request, response){

    response.end('hello World!!');

}).listen(8080);

console.log('Server up and runnig at full speed on port 8080');