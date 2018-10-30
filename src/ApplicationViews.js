import React, { Component } from 'react';
import './App.css';
import { Route, Redirect } from "react-router-dom"
import { Button, Card, Image } from 'semantic-ui-react'
import Scan from './Components/Scan'
import CreateProduct from './Components/CreateProduct'


class ApplicationViews extends Component {
  state = {

  }


  render() {
    return (
      <React.Fragment>
        <Route exact path="/" render={(props) => {
          return <Scan {...props} scan={props.location.state}/>
        }} />
        <Route exact path="/createproduct" render={(props) => {
          return <CreateProduct {...props} barcode={props.location.state.barcode}/>
        }} />
      </React.Fragment>
    );
  }
}

export default ApplicationViews;
