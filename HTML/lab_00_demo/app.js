const express = require('express');
const path = require('path');
const bodyParser = require('body-parser');
const cors = require('cors');
const port = 3000;
const axios = require('axios');

const app = express();

app.use(bodyParser.json());
app.use(cors());

app.use(express.static(path.join(__dirname, 'public')));

app.listen(port, () => { console.log(`Server started on http://localhost:${port}`)});

function getData () {
    console.log("API GET FILE LOADED");

    var response = axios.get('https://images-api.nasa.gov')
        .then( response => {
            console.log(response);
        })
        .catch(function (error) {
            console.log(error);
          });
}