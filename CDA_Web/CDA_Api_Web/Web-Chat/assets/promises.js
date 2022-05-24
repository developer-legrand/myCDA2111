//-------- RESOLVED PROMISE FUNCTION --------
let resolvedPromise = () => 
{
   console.log('vous êtes majeur')
}

let rejectedPromise = () => 
{
   console.error('vous êtes mineur!')
}

let isMajor = (age) => {
   return new Promise((resolve, reject) => {
      setTimeout(() => {
         if(age >= 18)
         {
            resolve();
         }
         else 
         {
            reject();
         }
      }, 5000);
   });   
}
//let isMajor3 = async function(age)
async function isMajor2(age)
{
   return await new Promise((resolve, reject) =>{
      setTimeout(() => {
         if(age >= 18)
         {
            resolve();
         }
         else 
         {
            reject();
         }
      }, 5000);
   });   
}

isMajor2(20).then((resolve) => {
   resolvedPromise();
})
.catch((reject) => {
   rejectedPromise();
});

console.log('bonjour');