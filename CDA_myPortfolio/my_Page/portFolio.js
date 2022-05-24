
// FUNCTION DISPLAY MY DIFFERENTS ELEMENTS
function hideOrShow(myElement) {
    let nameRecovered = myElement.name;
    alert(nameRecovered);
    // Select the element with id "theDIV"
      let x = document.getElementById(nameRecovered)
      // If selected element is hidden
      if (x.style.display === "none") {
        // Show the hidden element
        x.style.display = "block";
        // Else if the selected element is shown
      } else {
        // Hide the element
        x.style.display = "none";
      }
    }
  