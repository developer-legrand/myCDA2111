/*$(document).ready(function(){
    $.get('/fichiers_txt/import_jquery.txt', function(data) {
        document.getElementById("A3").textContent = data;
    });
});*/



fetch('/fichiers_txt/import_jquery.txt')
.then((response) => {
     return response.text();
})
.then((text) => {
    document.getElementById("A3").textContent = text;
});
