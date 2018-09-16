const express = require('express');
const app = express();
const router = express.Router();
const port = 2444;

var path = require('path');
var http = require("http");
var url = require("url");
var cors = require("cors");


app.use(function(req, res, next) {
    res.header("Access-Control-Allow-Origin", "*");
    res.header("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept");
    next();
});
//app.use(express.static(path.join(__dirname, '../')));

app.options('*', cors()); 


// url: http://localhost:2444/apigame
app.get('/apigame', (request, response) => response.json([
    {
        "ID":1,
        "nameGame":"fifa",
        "PlaerOne":"Moshe",
        "PlaerTwo":"David",
        "How_ww":"David"
    },
    {
        "ID":2,
        "nameGame":"fifa",
        "PlaerOne":"Shoshi",
        "PlaerTwo":"Omer",
        "How_ww":"Shoshi"
    }]));


app.listen(port, () => console.log(`Listening on port ${port}`));