import React from 'react';
import './App.css';
import Header from './Header';
import BowlerLeagueList from './Bowlers/BowlerList';

function App() {
  return (
    <div className="App">
      <Header title="Bowling League: Mission 10 Phethean" />
      <BowlerLeagueList />
    </div>
  );
}

export default App;
