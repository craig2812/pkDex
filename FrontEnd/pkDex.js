//GET PKM FUNCTION//
async function getPkm(){    

    // const proxyurl = "https://cors-anywhere.herokuapp.com/";
const url = "https://localhost:5001/pkms"; // site that doesn’t send Access-Control-*
let response = await fetch (url) // https://cors-anywhere.herokuapp.com/https://example.com
let data = await response.json();
console.log(data);


    // // create random number 
    // let rndnum = Math.random();
    // // insert random number into path 
    // let response = await fetch (`https://localhost:5001/pkms`); //correct endpoint - endpoint just being the server address not including route 
    // let data = await response.json();
    // console.log(data);
}
// getQuestions()