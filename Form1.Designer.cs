import React, {useState,useRef,useEffect} from "react"

import axios from "axios"

import './App.css';

function App() {
  const [nipInfo, setNipInfo] = useState([])
  const [theNip, setTheNip] = useState();
  const date = new Date().toISOString();
  const [currentDate, setCurrentDate] = useState(date.slice(0,10));
  const [isDone, setIsDone] = useState(false)
  const inputRef = useRef();


  const handleButton = () => {
    setIsDone(!isDone)
    if(theNip && currentDate) {
      axios(`https://wl-api.mf.gov.pl/api/search/nip/${theNip}?date=${currentDate}`)
    .then((data)=>{
      setNipInfo(data.data?.result.subject);
    })
    .catch((error)=>{
      console.log(error)
    })}
  }

  return (
    <>
      <input type="text" ref={inputRef} onChange={()=> setTheNip(inputRef.current.value)}/>
      <button onClick={handleButton}>Klik</button>
      {
        isDone ? (<h6>{nipInfo.name}</h6>) : (<h1>Waiting...</h1>)
      }
    </>
  );
}

export default App;
