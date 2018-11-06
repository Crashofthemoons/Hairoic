import React, { Component } from 'react';
import '../App.css';
import Quagga from 'quagga'; // ES6
//const Quagga = require('quagga').default; // Common JS (important: default)
import '../ApplicationViews';
import { Icon, Button, Menu, Image, Input, Container } from 'semantic-ui-react'
import APIManager from '../APIManager'
import { Redirect, Link } from "react-router-dom";

class Bad extends Component {

    state = {
        product: this.props.location.state,
        badIng: this.props.location.state.badIng
    }

    componentDidMount() {

    }

    logOut = () => {
        localStorage.removeItem("Hairoic")
        this.props.history.push("/")
    }

    render() {
        return(
            <React.Fragment>
                <Menu fixed='top' inverted>
                    <Menu.Item as='a' header onClick={this.resetSearch}>
                        <Image id="logo" size='tiny' src='../images/hairoic.jpg' style={{ marginRight: '1.5em' }} />
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
                <Container textAlign="center">
                    <Icon className='top-margin' name='x circle' size='massive' color='red'/>
                    <br/>
                    <div>{this.state.product.product.name} has HAIRY SCARIES!</div>
                    <br/>
                    <div>Hairy Scaries included in this product:</div>
                    {
                        this.state.badIng.map(ingredient =>
                             <div>{ingredient}</div>)
                    }
                    <br/>
                    <Button circular color='teal' size='large' onClick={()=>this.props.history.push('/')}>Scan Another Product</Button>
                </Container>
            </React.Fragment>
        )
    }
}

export default Bad;