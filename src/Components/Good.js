import React, { Component } from 'react';
import '../App.css';
import Quagga from 'quagga'; // ES6
//const Quagga = require('quagga').default; // Common JS (important: default)
import '../ApplicationViews';
import { Icon } from 'semantic-ui-react'
import APIManager from '../APIManager'

class Good extends Component {

    state = {
        product: this.props.location.state
    }

    componentDidMount() {

    }

    render() {
        return(
            <div className='top-margin'>
                <Icon name='check circle' size='massive' color='green'/>
            </div>
        )
        
    }
}

export default Good;