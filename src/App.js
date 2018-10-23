import React, { Component } from 'react';
import './App.css';
import Quagga from 'quagga'; // ES6
//const Quagga = require('quagga').default; // Common JS (important: default)
import './index.css';


class App extends Component {

componentDidMount() {
    if (('#barcode-scanner').length > 0 && navigator.mediaDevices && typeof navigator.mediaDevices.getUserMedia === 'function') {
      console.log("defined")
      var last_result = [];
      if (Quagga.initialized == undefined) {
        Quagga.onDetected(function(result) {
          var last_code = result.codeResult.code;
          last_result.push(last_code);
          if (last_result.length > 20) {
            let code = (last_result)[0];
            last_result = [];
            Quagga.stop();
            console.log(code);
            // $.ajax({
            //   type: "POST",
            //   url: '/products/get_barcode',
            //   data: { upc: code }
            // });
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
}



  render() {

    return (
      <div id="barcode-scanner">
      </div>
    );
  }
}

export default App;
