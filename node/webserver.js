// use a library for HTTP
var http = require('http');

console.log('HTTP Web Server')

http.createServer( (request, response) => {
    console.log('Server started')
    response.writeHead(200, { 'Content-Type' : 'text/plain' })
    response.end('Plain message sent to web server')


}).listen(8080, '127.0.0.1');