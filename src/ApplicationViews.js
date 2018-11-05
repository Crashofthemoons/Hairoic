import React, { Component } from 'react';
import './App.css';
import { Route, Redirect } from "react-router-dom"
import { Button, Card, Image } from 'semantic-ui-react'
import Scan from './Components/Scan'
import CreateProduct from './Components/CreateProduct'
import LogIn from './Components/LogIn'
import Product from './Components/Product'
import Bad from './Components/Bad'
import Good from './Components/Good'
import APIManager from './APIManager'


class ApplicationViews extends Component {

  state ={
    product: {}

  }

  

  render() {
    return (
      <React.Fragment>
        <Route exact path="/" render={(props) => {
          return <Scan {...props} product={props.location.state}/>
        }} />
        <Route exact path="/createproduct" render={(props) => {
          return <CreateProduct {...props} barcode={props.location.state}/>
        }} />
        <Route exact path="/login" render={(props) => {
          return <LogIn {...props} />
        }} />
        <Route exact path="/product" render={(props) => {
          return <Product {...props} product={props.location.state}/>
        }} />
        <Route exact path="/product/good" render={(props) => {
          return <Good {...props} product={props.location.state}/>
        }} />
        <Route exact path="/product/bad" render={(props) => {
          return <Bad {...props} product={props.location.state}/>
        }} />
      </React.Fragment>
    );
  }
}

export default ApplicationViews;
