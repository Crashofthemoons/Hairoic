import React, { Component } from 'react';
import '../App.css';
import Quagga from 'quagga'; // ES6
//const Quagga = require('quagga').default; // Common JS (important: default)
import '../ApplicationViews';
import { Button, Link } from 'semantic-ui-react'
import APIManager from '../APIManager'
import { STATUS_CODES } from 'http';


class Scan extends Component {

    state={
        isHidden: "notHidden",
        barcode: 0,
        product: {}
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
            .catch((error) => {
                console.log("this product does not exist", error);
                this.location.pushState(this.state.barcode, 'createproduct');
              })
            .then(thisProduct => { // reset state search: with results
                this.setState({
                        product: thisProduct
                    })
                console.log("this product exists")
            })
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
            readers : ['ean_reader','ean_8_reader','code_39_reader','code_39_vin_reader','codabar_reader','upc_reader','upc_e_reader']
        }
      },function(err) {
          if (err) { console.log(err); return }
          Quagga.initialized = true;
          Quagga.start();
      });

    }

    this.setState({isHidden: "hidden"});
}

render() {
    return (
        <React.Fragment>
      <div id='barcode-scanner'>
        <Link to={{ pathname: "/createproduct" }}>
        </Link>
      </div>
    <Button className={this.state.isHidden} circular icon='barcode' color='teal' size='massive' onClick={this.scan}>Scan a Product</Button>
    </React.Fragment>
    );
  }
}

export default Scan;