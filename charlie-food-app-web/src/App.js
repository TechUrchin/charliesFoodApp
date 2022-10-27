import logo from './images/charcharplays.png';
import demandingCat from './images/charchardemands.jpg';
import whiskasCat from './images/whiskas.jpg';
import felixCat from './images/felix.jpg';
import lilysCat from './images/lilyskitchen.jpg';
import './App.css';
import React from 'react';

// function reviewSquare() {
//   return (
//     <div>

//     </div>
//   )
// }

class Home extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      catBrands: ["Whiskers", "Felix", "Lily's Kitchen"],
      catLogos: [whiskasCat, felixCat, lilysCat],
      tasteRating: [5, 3 , 4],
      nutritionRating: [2.5, 3, 5],
      priceRating: [5, 3, 2],
      approvalRating: [5, 2, 4]
    }
  }

  renderBody(i) {
    return (
      <div className="Review">
        <header className="Review-header">{this.state.catBrands[i]}</header>
        <img src={this.state.catLogos[i]} className="Review-logo" alt='food-logo'/>
        <div className="Review-Para">
          <p>Taste: {this.state.tasteRating[i]}/5</p>
          <p>Nutrition: {this.state.nutritionRating[i]}/5</p>
          <p>Price: {this.state.priceRating[i]}/5</p>
          <p>Approval: {this.state.approvalRating[i]}/5</p>
        </div>
      </div>
    );
  }

  render() {
    return (
      <div className="App">
        <header className="App-header">
          Charlie's Food App
          <img src={logo} className="App-logo" alt="logo" />
        </header>
        <div className="Review-Squares">
            {this.renderBody(0)}
            {this.renderBody(1)}
            {this.renderBody(2)}
        </div>
      </div>
    );
  }


}


export default Home;
