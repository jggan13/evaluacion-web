import React from 'react';
import './App.css';
import FormLogin from './components/FormLogin';
import Products from './components/Products';
import {
  BrowserRouter as Router,
  Switch,
  Route
} from "react-router-dom";

function App() {
  return (
    <Router>
      <div className="App">
      <Switch>
          <Route exact path="/" component={FormLogin} />
          <Route exact path="/products" component={Products} />
          <Route component={FormLogin} />
      </Switch>
      </div>
    </Router>
  );
}

export default App;
