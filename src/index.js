import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import ApplicationViews from './ApplicationViews';
// import registerServiceWorker from './registerServiceWorker';
import { Route, Redirect } from "react-router-dom"
import { BrowserRouter as Router } from 'react-router-dom'
import 'semantic-ui-css/semantic.min.css';



ReactDOM.render(
    <Router>
        <ApplicationViews />
    </Router>, document.getElementById('root'));
    // registerServiceWorker();

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: http://bit.ly/CRA-PWA
//serviceWorker.unregister();
