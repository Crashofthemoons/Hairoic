import React, { Component } from 'react';
import '../App.css';
import Quagga from 'quagga'; // ES6
//const Quagga = require('quagga').default; // Common JS (important: default)
import '../ApplicationViews';
import { Icon } from 'semantic-ui-react'
import APIManager from '../APIManager'

class Bad extends Component {

    state = {
        product: this.props.location.state
    }

    componentDidMount() {

    }

    render() {
        return(
            <div className='top-margin'>
                <Icon name='x circle' size='massive' color='red'/>
            </div>
        )
    }
}

export default Bad;