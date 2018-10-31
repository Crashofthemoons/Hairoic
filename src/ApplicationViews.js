import React, { Component } from 'react';
import './App.css';
import { Route, Redirect } from "react-router-dom"
import { Button, Card, Image } from 'semantic-ui-react'
import Scan from './Components/Scan'
import CreateProduct from './Components/CreateProduct'
import LogIn from './Components/LogIn'


class ApplicationViews extends Component {


  render() {
    return (
      <React.Fragment>
        <Route exact path="/" render={(props) => {
          return <Scan {...props} scan={props.location.state}/>
        }} />
        <Route exact path="/createproduct" render={(props) => {
          return <CreateProduct {...props} barcode={props.location.state}/>
        }} />
        <Route exact path="/login" render={(props) => {
          return <LogIn {...props} />
        }} />
        {/* <Route exact path="/product" render={(props) => {
          return <CreateProduct {...props} product={props.location.state.product}/>
        }} /> */}
      </React.Fragment>
    );
  }
}

export default ApplicationViews;
