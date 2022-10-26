import logo from './images/charcharplays.png';
import './App.css';
import React from 'react';

function reviewSquare() {
  return (
    <div>
      
    </div>
  )
}

class Home extends React.Component {
  renderHeader() {
    return (
      <div className="App">
        <header className="App-header">
          Charlie's Food App
          <img src={logo} className="App-logo" alt="logo" />
        </header>
      </div>
    );
  }
  renderBody() {
    return (
      <div>

      </div>
    )
  }
}


export default Home;
