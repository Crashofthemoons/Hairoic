import React, { Component } from 'react';
import '../App.css';
import Quagga from 'quagga'; // ES6
//const Quagga = require('quagga').default; // Common JS (important: default)
import '../ApplicationViews';
import { Icon, Menu, Image, Input, Checkbox, Button } from 'semantic-ui-react'
import APIManager from '../APIManager'
import { Redirect, Link } from "react-router-dom";


class CreateProduct extends Component {

    state = {
        name: "",
        upc: this.props.barcode.barcode,
        ingredient: "",
        ingredients: [],
        newProductIngredients: []
    }
    componentDidMount() {
        APIManager.getData('ingredients')
        .then(ingredients =>{
            this.setState({
                ingredients: ingredients
            })
            this.state.ingredients.sort((a, b)=>{return a.name - b.name})

        })
    }

    handleFieldChange = event => { //handles field change for inputs
        const stateToChange = {};
        stateToChange[event.target.id] = event.target.value;
        this.setState(stateToChange);
    };

    handleCheckbox = (event, {value}) => {
        if (!event.currentTarget.querySelector('input').checked) {
            console.log(event, "checked")
            let name = {value}
            const newIng = {
                name: name.value
            };
            this.state.newProductIngredients.push(newIng);
        } else {
            this.state.newProductIngredients.pop()
        }
    }
    //handleChange = (e, { value }) => this.setState({ value })


    postIngredient = (event) =>{
        if (event.key === "Enter") {
            let ing = { name: this.state.ingredient}
            console.log(ing)
            APIManager.addData('ingredients', ing)
            .then(newIngredient=>{
                this.state.ingredients.push(newIngredient);
            })

        }
    }


    postProduct = () => {
        let prod = {
            name: this.state.name,
            upc: this.state.upc,
            ingredients: this.state.newProductIngredients
        }
        console.log(prod)
        // APIManager.addData('products', prod)
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
                <Input onChange={this.handleFieldChange} id='name' placeholder='Product Name...' />
                <Input id="ingredient" onChange={this.handleFieldChange} onKeyPress={this.postIngredient} placeholder="Add New Ingredient..."/>
                {
                    this.state.ingredients.map(ingredient =>
                        <Checkbox key={ingredient.IngredientId} onChange={this.handleCheckbox} id={ingredient.IngredientId} value={ingredient.name} label={ingredient.name}/>)
                }

             <Button circular color='teal' size='normal' onClick={this.postProduct}>Add A Product</Button>
                

            </React.Fragment>
        );
    }
}

export default CreateProduct;