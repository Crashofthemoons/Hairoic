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
        product: this.props.location.state,
        ingredients: [],
        sAnds: ["Ammonium", "Alkylbenzene Sulfonate", "Ammonium Laureth", "Lauryl Sulfate", "Sodium Xylenesulfonate", "Dioctyl Sodium Sulfosuccinate", "Ethyl PEG-15 Cocamine Sulfate", "Sodium C14-16 Olefin Sulfonate", "Sodium Cocoyl Sarrcosinate", "Sodium Laureth", "Sodium Myreth", "Sodium Lauryl Sulfoacetate", "TEA-Dodecylbenzenesulfonate", "Cetearyl Methiocne", "Cetyl Dimethicone", "Dimethicone", "Dimethiconol", "Stearyl Dimethicone", "Amodimethicone", "Cyclomethicone", "Cyclopentasiloxane", "Trimethysilylamodimethicone", "Behenoxy Dimethicone", "Stearoxy Dimethicone"],
        bad: null
    }

    componentWillMount() {
        let ingArray = [];
       this.state.product.product.ingredients.forEach(ingredient => {
           ingArray.push(ingredient.name);
        });
        this.setState({
            ingredients: ingArray
        })
    }

    componentDidMount() {
        
        console.log(this.state.product.product.ingredients.length, this.state.ingredients.length)
       if (this.state.ingredients.length === this.state.product.product.ingredients.length) {
           this.checkProduct();

       }
    }

    checkProduct = () => {
        console.log(this.state.ingredients, this.state.sAnds)
        if (this.state.ingredients.some(ing => this.state.sAnds.includes(ing))) {
            this.setState({
                bad: true
            })
            console.log("bad")
        }else{
            this.setState({
                bad: false
            })
            console.log("good")
        }
    }

    
    render() {

            // this.state.product.product.ingredients.map(ingredient=>{
            //     if (ingredient.name === "Cetyl Dimethicone" || "Ammonium") {
            //         return (<Redirect  to={{
            //             pathname: "/product/bad",
            //             state: { product: this.state.product }
            //           }} />)
            //     } else {
            //         return (<Redirect  to={{
            //             pathname: "/product/good",
            //             state: { product: this.state.product }
            //           }} />)
            //     }
            // })
            
            
        if (this.state.bad === true) {
            return(
                <Redirect  to={{
                    pathname: "/product/bad",
                    state: { product: this.state.product.product }
                  }} />

            )
        } else if (this.state.bad === false) {
            return(
                <Redirect  to={{
                    pathname: "/product/good",
                    state: { product: this.state.product.product }
                  }} />
            )
    
        } else {
            return(
                <div>product</div>
            )
        
        }
    }
}

export default Product;