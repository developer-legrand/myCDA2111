//------- NAVIGATION ANIMATION -------

$('#cv').css('display','none');
$('#news').css('display','none');
$('#contact').css('display','none');

$(document).ready(function(){
$('#link-news').click(function(){
    $('#about').css('display','none');
    $('#news').show();
    $('#cv').css('display','none');
    $('#contact').css('display','none');
    
  });

  $('#link-about').click(function(){
    $('#about').show();
    $('#news').css('display','none');
    $('#cv').css('display','none');
    $('#contact').css('display','none');
  });

  $('#link-cv').click(function(){
    $('#about').css('display','none');
    $('#news').css('display','none');
    $('#cv').show();
    $('#contact').css('display','none');
  });

  $('#link-contact').click(function(){
    $('#about').css('display','none');
    $('#news').css('display','none');
    $('#cv').css('display','none');
    $('#contact').show();
  });
});

// A function that hides or shows a selected element
function hideOrShow() {
	
  // Select the element with id "theDIV"
  var x = document.getElementById("link-about");
  
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







