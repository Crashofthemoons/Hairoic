import React, { Component, Link } from 'react';
import '../App.css';
import Quagga from 'quagga'; // ES6
//const Quagga = require('quagga').default; // Common JS (important: default)
import '../ApplicationViews';
import { Button, Menu, Icon, Image, Input } from 'semantic-ui-react'
import APIManager from '../APIManager'

class LogIn extends Component {

    state = {
        username: "",
        password: ""
      };

      handleFieldChange = event => {
        const stateToChange = {};
        stateToChange[event.target.id] = event.target.value;
        this.setState(stateToChange);
      };

      handleLogin = () => {
        let body = this.state;
        console.log(this.state)
        APIManager.addData('token', body)
            .then(id => id.text())
            .then(id => {
                localStorage.setItem("Hairoic", id)
            })
            .then(() => {
                this.props.history.push('/')
            })
    }

    componentDidMount() {

    }

    render() {
        return(
            <React.Fragment>
                <div className='top-margin'>
                <Input iconPosition='left' required placeholder='Email' id='username' onChange={this.handleFieldChange}>
                <Icon name='at' />
                <input />
                </Input>
                    <br />
                    <br />
                <Input icon type="password" required placeholder='Password' id='password' onChange={this.handleFieldChange}>
                <input />
                </Input>
                <br/>
                <br/>
                <Button.Group>
                    <Button onClick={this.handleLogin}>Register</Button>
                    <Button.Or />
                    <Button positive onClick={this.handleLogin}>Log-In</Button>
                </Button.Group>
                </div>
            </React.Fragment>
        );
    }
}

export default LogIn;