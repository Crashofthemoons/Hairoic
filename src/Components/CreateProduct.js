import React, { Component } from 'react';
import '../App.css';
import Quagga from 'quagga'; // ES6
//const Quagga = require('quagga').default; // Common JS (important: default)
import '../ApplicationViews';
import { Icon, Menu, Image, Input, Checkbox, Button, Container } from 'semantic-ui-react'
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

    logOut = () => {
        localStorage.removeItem("Hairoic")
        this.props.history.push("/")
    }

    isSelected(ingredientObject) {
        let foundIngredient = this.state.newProductIngredients.find(ingredient => {
            return ingredient.ingredientId === ingredientObject.ingredientId
        })
        console.log(foundIngredient === undefined ? false : true)
    }

    componentDidMount() {
        APIManager.getData('ingredients')
        .then(ingredients =>{
            // ingredients.forEach(element => {
            //     element.checked = false
            // })
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
        let thisEvent = event.currentTarget
        console.log(event.currentTarget)
        if (thisEvent.checked) {
            let name = {value}
            const newIng = {
                name: name.value,
                ingredientId: parseInt(thisEvent.id)
            };
            console.log(newIng)
            this.state.newProductIngredients.push(newIng);
        } else {

            let filteredArray = this.state.newProductIngredients.filter(item => item.name !== thisEvent.value)
            this.setState({newProductIngredients: filteredArray});
        }
    }


    postIngredient = (event) =>{
        if (event.key === "Enter") {
            let ing = { name: this.state.ingredient}
            console.log(ing)
            APIManager.addData('ingredients', ing)
            .then(()=>APIManager.getData('ingredients'))
            .then(ings=>{
                console.log(ings);
                this.setState(() => 
                { return {ingredients: ings}})
            })
            console.log(this.refs.ing.inputRef.value) 
            this.refs.ing.inputRef.value= ""
        }
    }


    postProduct = () => {
        let prod = {
            name: this.state.name,
            upc: this.state.upc,
            ingredients: this.state.newProductIngredients
        }
        console.log(prod)
        APIManager.addData('products', prod)
        .then(this.props.history.push('/'))
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
                    <Icon className='top-margin' name='exclamation circle' size='massive'/>
                    <div>Product Not Available. Add this Product?</div>
                    <div>Product Barcode: {this.props.barcode.barcode}</div>
                </Container>
                <Input className='input' onChange={this.handleFieldChange} id='name' placeholder='Product Name...' />
                <Input ref='ing' className='input' id="ingredient" onChange={this.handleFieldChange} onKeyPress={this.postIngredient} placeholder="Add New Ingredient..."/>
                {
                    this.state.ingredients.map(ingredient =>
                        <Checkbox key={ingredient.IngredientId} onChange={this.handleCheckbox} id={ingredient.ingredientId} value={ingredient.name} checked={this.isSelected(ingredient)} label={ingredient.name}/>)
                }
                <Container textAlign="center">
                    <Button circular color='teal' size='normal' onClick={this.postProduct}>Add A Product</Button>
                </Container>
                

            </React.Fragment>
        );
    }
}

export default CreateProduct;