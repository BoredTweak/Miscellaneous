import "./App.css";
import React, { FC, useState } from "react";
import RandomCircles from "./random-circles";

enum Demo {
  randomCircles = "demo1",
}

const App: FC = () => {
  const [selectedDemo, setSelectedDemo] = useState<Demo>(Demo.randomCircles);

  return (
    <div className="App">
      <header className="App-header">
        <p>Playing with d3!</p>
        <div>
          <button
            className="navigate-btn"
            onClick={() => setSelectedDemo(Demo.randomCircles)}
          >
            Random Circles
          </button>
        </div>
      </header>
      <div className="demo-container">
        {selectedDemo === Demo.randomCircles && (
          <>
            <h2>Random Circles</h2>
            <RandomCircles />
          </>
        )}
      </div>
    </div>
  );
};

export default App;
