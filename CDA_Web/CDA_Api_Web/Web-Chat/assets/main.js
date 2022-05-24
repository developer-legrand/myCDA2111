function generateTable(json)
{
   for(let i = 0; i < json.length; i++) {
      let user = json[i];
      let tr = document.createElement('tr');
      let td =document.createElement('td');
      td.textContent = user.user_name;
   }

   // for(let user of json) { }
   // json.array.forEach(user => { });

}

fetch('https://api.devoldere.net/dataset/users.json')
.then((response) => {
    console.log(response);
    return response.json();
})
.then(json => {
console.log(json);
})
.catch(error => {
    console.log(error);
});

// function ResolvedPromise()
// {

// }

// resolvedPromise = function()
// {
   
// }

// var toto;
// let tata;
// const titi = "";

//  function test()
//  {
//     if(true) {
//         var toto;
//         let tata;
        
//      }
//     console.log(toto);
//     console.log(tata);
//  }


// const toto = document.getElementById('logo');
// const tata = document.querySelector('#logo');

// const titi = document.getElementsByTagName('a');
// const tutu = document.getElementsByClassName('exemple'); 

// MULTI SELECTION
// const titi = document.querySelectorAll('a[href=a]');

// console.log(logo);
// logo.style.color = 'red';
// logo.style.fontSize = '40px';