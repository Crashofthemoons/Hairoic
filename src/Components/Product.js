import React, { Component } from 'react';
import '../App.css';
import Quagga from 'quagga'; // ES6
//const Quagga = require('quagga').default; // Common JS (important: default)
import '../ApplicationViews';
import { Icon } from 'semantic-ui-react'
import APIManager from '../APIManager'
import { Redirect, Link } from "react-router-dom";

class Product extends Component {

    state = {
        product: this.props.location.state
    }

    componentDidMount() {

    }

    render() {
        
        if (this.props.product.product.ingredients.includes("Ammonium")) {
            return(
                <Redirect  to={{
                    pathname: "/product/bad",
                    state: { product: this.state.product }
                  }} />
            )
        } else {
            return(
                <Redirect  to={{
                    pathname: "/product/good",
                    state: { product: this.state.product }
                  }} />
            )
    
        }
    }
}

export default Product;