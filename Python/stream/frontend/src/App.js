import './App.css';
import { useState } from 'react';

function App() {
  const [file, setFile] = useState(null)

  const onFileChange = event => {
    setFile(event.target.files[0]);
  };

  const onFileUpload = () => {
    const formData = new FormData();
  
    formData.append(
      "file",
      file,
      file.name
    );
  
    console.log(file);
  
    fetch("http://localhost:5000/api/file", { method: 'POST', body: formData })
  };

  const FileDetails = () => {
    if(!file) {
      return <div><h4>Select a file via the upload button.</h4></div> 
    }

    return (
      <div>
        <h2>File Details:</h2>
        <p>File Name: {file.name}</p>
        <p>File Type: {file.type}</p>
        <p>File Size: {file.size}</p>
        <p>Last Modified: {file.lastModifiedDate.toDateString()}</p>
      </div>
    );
  } 

  return (
    <div className="App">
      <div>
        <input type="file" onChange={onFileChange} />
        <button onClick={onFileUpload}>Upload</button>
        <FileDetails/>
      </div>
    </div>
  );
}

export default App;
