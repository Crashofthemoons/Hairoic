import React, { Component } from 'react';
import '../App.css';
import Quagga from 'quagga'; // ES6
//const Quagga = require('quagga').default; // Common JS (important: default)
import '../ApplicationViews';
import { Icon } from 'semantic-ui-react'
import APIManager from '../APIManager'


class CreateProduct extends Component {


    componentDidMount() {

    }

    render() {
        return(
            <div>
                <Icon name='exclamation circle' size='massive'/>
            </div>
        );
    }
}

export default CreateProduct;