import logo from './logo.svg';
import './App.css';
import EditGrid from './edit-grid.js';

function App() {
  return (
    <div className="App">
      <img src={logo} className="App-logo" alt="logo" />
      <EditGrid/>
    </div>
  );
}

export default App;
