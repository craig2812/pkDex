import logo from './logo.svg';
import './App.css';
import React, {useState, useEffect} from "react";

function App() {

  const [pkms, setPkms] = useState([]);
          // https://todolist-gcsproj.herokuapp.com
  useEffect(() => {
    getPkms();
  }, []);
  
  async function getPkms() {
    console.log("TEST")
    let response = await fetch("https://localhost:5001/pkms");
    console.log(response);
    let data = await response.json();
    console.log(data);
    console.log(data.name);
    console.log(pkms);
    setPkms(data);
  };


  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <button onClick={()=> getPkms()}>Click for pkms</button>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
