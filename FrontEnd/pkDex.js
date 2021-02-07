//GET QUESTION FUNCTION//
async function getQuestions(){
    // startButton.innerText = "Restart Quiz" // need this to refresh page not just start a new question
    
    // create random number 
    let rndnum = Math.random();
    // insert random number into path 
    let response = await fetch (`https://localhost:5001/pkms/14`);
    let data = await response.json();
    console.log(data);
}