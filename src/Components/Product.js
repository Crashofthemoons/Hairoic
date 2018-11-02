import React, { Component } from 'react';
import '../App.css';
import Quagga from 'quagga'; // ES6
//const Quagga = require('quagga').default; // Common JS (important: default)
import '../ApplicationViews';
import { Icon } from 'semantic-ui-react'
import APIManager from '../APIManager'

class Product extends Component {

    state = {
        product: this.props.location.state
    }

    componentDidMount() {

    }

    render() {
        return(
            <div> product </div>
        )
        
        // if ( this.props.product) { 

        // return (
        //     <React.Fragment>
        //         <Good key={this.props.product.id} product={this.props.product}/>
        //     </React.Fragment>
        // )


        // } else {

        // return(
        //     <React.Fragment>
        //         <Bad key={this.props.product.id} product={this.props.product} />
        //     </React.Fragment>

        // )

        // }
    }
}

export default Product;