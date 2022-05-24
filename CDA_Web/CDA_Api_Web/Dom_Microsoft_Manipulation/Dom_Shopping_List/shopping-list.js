
//INPUT BOX VALUE
let myLabelElement = document.getElementById('myLabel');
let myInputElement = document.getElementById('myInput');
let myButtonElement = document.getElementById('myButton');




myButtonElement.onclick = function() {
    var myNewData = myInputElement.value
    // alert(myNewData);
    myInputElement.value = "";
    
    //CREATE A LIST WITH DELETE BUTTON
    //--------------------------------

    //CREATE LIST
    let myCreateList = document.createElement('li');
    myCreateList.setAttribute('class', 'myList');
    document.body.appendChild(myCreateList);
    
    //CREATE ITEM
    let myTextItem = document.createTextNode(myNewData);
    myTextItem.setAttribute = ('class', 'myTextItem');
    myCreateList.appendChild(myTextItem);
   
    //CREATE SPAN
    let myBlankSpan = document.createElement('span');
    myCreateList.appendChild(myBlankSpan);
  
    //CREATE DELETE BUTTON
    let myDeleteButton = document.createElement('button');
    myCreateList.appendChild(myDeleteButton);
    myDeleteButton.textContent = 'Delete';
    myDeleteButton.setAttribute('class','myDeleteButton');
    
    myDeleteButton.onclick = function() {
    // alert(myCreateList.appendChild(myTextItem).textContent);
    document.body.removeChild(myCreateList);
    focusMethod();
    }

    focusMethod = function getFocus() {
        document.getElementById("myInput").focus();
      }
    focusMethod();
}












// const list = document.getElementByTagName('SearchList');
// fetch(url)
//     .then(res =>{ return res.json(); })
//     .then(data => {
//         console.log(data)
//         for(let ville of data )
//         {
//             let opt = document.createElement("option");
//             opt.value = ville.codePostal;
//             opt.innerHTML = ville.nomCommune;
//             list.appendChild(opt);
//         }
//     })
//     .catch(error=>{
//         console.log(error)
//     });