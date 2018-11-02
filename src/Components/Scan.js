import React, { Component } from 'react';
import '../App.css';
import Quagga from 'quagga'; // ES6
//const Quagga = require('quagga').default; // Common JS (important: default)
import '../ApplicationViews';
import { Button, Menu, Icon, Image, Input } from 'semantic-ui-react'
import APIManager from '../APIManager'
import CreateProduct from './CreateProduct'
import LogIn from './LogIn'
import { Redirect, Link } from "react-router-dom";


export default class Scan extends Component {

    state={
        isHidden: "notHidden",
        barcode: 0,
        product: {},
        new: 0
    }


scan = () => {
    if (('#barcode-scanner').length > 0 && navigator.mediaDevices && typeof navigator.mediaDevices.getUserMedia === 'function') {
      console.log("defined")
      var last_result = [];
      if (Quagga.initialized === undefined) {
        Quagga.onDetected((result) => {
          var last_code = result.codeResult.code;
          last_result.push(last_code);
          if (last_result.length > 20) {
              let code = (last_result)[0];
              last_result = [];
              Quagga.stop();
              console.log(code);
              this.setState({barcode: code});
            APIManager.getData(`products?upc=${code}`)
            .then(product => {
                this.setState({
                    product: product,
                    new: 1
                })
            })
            // .catch(this.setState({
            //     new: 2
            // }))
        }   
        });
    }

      Quagga.init({
        inputStream : {
          name : "Live",
          type : "LiveStream",
          numOfWorkers: navigator.hardwareConcurrency,
          target: document.querySelector('#barcode-scanner')
        },
        decoder: {
            readers : ['code_128_reader', 'ean_8_reader', 'upc_reader', 'upc_e_reader']
            // 'ean_reader','ean_8_reader',,'code_39_vin_reader','codabar_reader','upc_reader','upc_e_reader'
        }
      },function(err) {
          if (err) { console.log(err); return }
          Quagga.initialized = true;
          Quagga.start();
      });

    }

    this.setState({isHidden: "hidden"});
}

newProduct = () =>{
    console.log("hello")
}

render() {
    if (this.state.new === 1) {
        return(
            <Redirect  to={{
                pathname: "/product",
                state: { product: this.state.product }
              }} />
        )
    } else if (this.state.new === 2) {
        return(
            <Redirect  to={{
                pathname: "/createproduct",
                state: { barcode: this.state.barcode }
              }} />
        )

    } else {
        return (
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
              <div className='top-margin' id='barcode-scanner' onDetected={this.newProduct}></div>
             <Button className={this.state.isHidden} circular icon='barcode' color='teal' size='massive' onClick={this.scan}>Scan a Product</Button>
             
             
            </React.Fragment>
            );
    }
    
  }
}
