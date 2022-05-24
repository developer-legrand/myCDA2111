
const list = document.getElementById('JsonData');
const thead = document.querySelector('#col');
const resultButton = document.querySelector('#result');

let paulData;

let tr = document.createElement('tr');
thead.appendChild(tr);
let thCodePostal = document.createElement('th');
thCodePostal.textContent = 'code postal'
let thCodeCommune = document.createElement('th');
thCodeCommune.textContent = 'code commune';
let thNomCommune = document.createElement('th');
thNomCommune.textContent = 'nom commune';
let thLibelleAcheminement = document.createElement('th');
thLibelleAcheminement.textContent = 'acheminement';

tr.appendChild(thCodePostal);
tr.appendChild(thCodeCommune);
tr.appendChild(thNomCommune);
tr.appendChild(thLibelleAcheminement);

fetch('./zipcodes.json')
    .then(res =>{ return res.json(); })
    .then(data => {
        paulData = data;
        console.log(data)
        for(let ville of data )
        {
            let opt = document.createElement("option");
            opt.value = ville.codePostal;
            opt.innerHTML = ville.nomCommune;
            //opt.setAttribute('value', ville)
            list.appendChild(opt);
        }
    })
    .catch(error=>{
        console.log(error)
        console.log('toto')
});

const btn = document.querySelector('.myButtonValidation');
btn.addEventListener('click', function(event) {
  event.preventDefault();
  let recupValue = document.querySelector('#myInputBox').value;
  fetch('./zipcodes.json') 
  .then(res => res.json())
  
  .then(data => {
    for(let ville of data) {

      if(recupValue === ville.codePostal){
            console.log(recupValue);
            let tr = document.createElement('tr');
            resultButton.appendChild(tr);
            let tdCodePostal = document.createElement('td');
            tdCodePostal.textContent = ville.codePostal
            let tdCodeCommune = document.createElement('td');
            tdCodeCommune.textContent = ville.codeCommune;
            let tdNomCommune = document.createElement('td');
            tdNomCommune.textContent = ville.nomCommune;
            let tdLibelleAcheminement = document.createElement('td');
            tdLibelleAcheminement.textContent = ville.libelleAcheminement;
            
            tr.appendChild(tdCodePostal);
            tr.appendChild(tdCodeCommune);
            tr.appendChild(tdNomCommune);
            tr.appendChild(tdLibelleAcheminement);
            }
        }
    
    })
});


