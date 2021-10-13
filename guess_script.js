function processGuess() {
    var valueString=document.getElementById("guessInput").value;
    var messageRef=document.getElementById("message");
    messageRef.innerHTML="Du har gissat";

    console.log(valueString);
    var randomNumber=Math.random()*100;
    randomNumber=parseInt(randomNumber);
    console.log(randomNumber);
}