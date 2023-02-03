import React from "react";
import logo from "./logo.svg";
import "./App.css";
import TopoMap from "./components/topomap";
import { Item, Status } from "./types";

const App = () => {
  enum Demo {
    Home = "Home",
    TopoMap = "TopoMap",
  }

  const [demo, setDemo] = React.useState(Demo.Home);

  const generateItems = (count: number): Item[] => {
    const items: Item[] = [];
    for (let i = 0; i < count; i++) {
      items.push({
        latitude: Math.random() * 180 - 90,
        longitude: Math.random() * 360 - 180,
        status:
          Object.values(Status)[
            Math.floor(Math.random() * Object.values(Status).length)
          ],
      });
    }
    return items;
  };

  const items = generateItems(10);
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />

        <div>
          <button onClick={() => setDemo(Demo.Home)}>Home</button>
          <button onClick={() => setDemo(Demo.TopoMap)}>TopoMap</button>
        </div>

        {demo === Demo.Home && (
          <p>
            Edit <code>src/App.tsx</code> and save to reload.
          </p>
        )}

        {demo === Demo.TopoMap && <TopoMap items={items} />}
      </header>
    </div>
  );
};

export default App;
