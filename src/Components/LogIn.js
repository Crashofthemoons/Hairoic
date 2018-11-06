import React, { Component } from 'react';
import '../App.css';
import Quagga from 'quagga'; // ES6
//const Quagga = require('quagga').default; // Common JS (important: default)
import '../ApplicationViews';
import { Button, Menu, Icon, Image, Input } from 'semantic-ui-react'
import APIManager from '../APIManager'
import { Redirect, Link } from "react-router-dom";

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

    logOut = () => {
        localStorage.removeItem("SpecTrek")
        this.setState({
            currentUser: "",
            role: ""
        })
        this.props.history.push("/")
    }

    render() {
        return(
            <React.Fragment>
                <Menu fixed='top' inverted>
                    <Menu.Item as='a' header onClick={this.resetSearch}>
                        <Image id="logo" size='tiny' srcSet='../images/hairoic.jpg' style={{ marginRight: '1.5em' }} />
                        <Link
                                to={{
                                    pathname: "/"
                                }}>
                                Hairoic
                            </Link>
                        </Menu.Item>
                        <Menu.Item>
                            <Link
                                to={{
                                    pathname: "/login"
                                }}>
                                Log In
                            </Link>
                        </Menu.Item>
                        <Menu.Item onClick={this.logOut}>
                            Log Out
                        </Menu.Item>
                    {/* <Input ref="search" id="search" style={{ marginLeft: '3em' }} onKeyPress={this.searchBar} transparent inverted placeholder='Search...'/> */}
                </Menu>
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