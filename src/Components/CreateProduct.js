import React, { Component } from 'react';
import '../App.css';
import Quagga from 'quagga'; // ES6
//const Quagga = require('quagga').default; // Common JS (important: default)
import '../ApplicationViews';
import { Icon, Menu, Image } from 'semantic-ui-react'
import APIManager from '../APIManager'
import { Redirect, Link } from "react-router-dom";


class CreateProduct extends Component {

    state = {
        name: "",
        upc: 0,
        ingredient: "",
        ingredients: []
    }
    componentDidMount() {
        APIManager.getData('ingredients')
        .then(ingredients =>{
            this.setState({
                ingredients: ingredients
            })
        })
    }

    render() {
        return(
            <React.Fragment>
                <Menu fixed='top' inverted>
                    <Menu.Item as='a' header onClick={this.resetSearch}>
                        <Image id="logo" size='tiny' srcSet='' style={{ marginRight: '1.5em' }} />
                        Hairoic
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
                <Icon className='top-margin' name='exclamation circle' size='massive'/>
                <div> {this.props.barcode.barcode} </div>
                <Input id='name' placeholder='Product Name...' />
                {
                    this.state.ingredients.map(ingredient =>
                        <Checkbox id={ingredient.IngredientId} label={ingredient.name}/>)

                }



            </React.Fragment>
        );
    }
}

export default CreateProduct;