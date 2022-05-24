import { Employee } from "./Employee.js";


export class TableEmployee{
    constructor(){
        
    }

    createHeader(elem, arrayName) {
        arrayName.forEach(value => {
            var columnHeader = document.createElement('th');
            columnHeader.textContent = value;
            console.log(value);
            elem.appendChild(columnHeader);
        });

        fetch("https://arfp.github.io/tp/web/frontend/employees/employees.json")
        .then(res =>{ return res.json(); })
        .then(data => {   
            console.log(data)
            let tbody = document.querySelector('#contentTable');
            for(let employee of data.data)
            {         
                let employeeObject = new Employee(employee.id, employee.employee_name, employee.employee_salary, employee.employee_age)
                
                let tr = document.createElement('tr');

                let tdEmployeeId = document.createElement("td");  
                tdEmployeeId.innerHTML = employee.id;

                let tdEmployeeName = document.createElement("td");  
                tdEmployeeName.innerHTML = employee.employee_name;

                let tdEmployeeEmail = document.createElement("td");  
                tdEmployeeEmail.innerHTML = employeeObject.getMail();
                
                let tdEmployeeSalary = document.createElement("td");
                tdEmployeeSalary.innerHTML = employeeObject.getMonthlySalary();
               
                let tdEmployeeAge = document.createElement("td");  
                tdEmployeeAge.innerHTML = employee.employee_age ; 

                let tdEmployeeActions = document.createElement("td");   
                let buttonDuplicate = document.createElement("button");
                let buttonDelete = document.createElement("button");

                tbody.appendChild(tr);
                tr.appendChild(tdEmployeeId);
                tr.appendChild(tdEmployeeName);
                tr.appendChild(tdEmployeeEmail);
                tr.appendChild(tdEmployeeSalary);
                tr.appendChild(tdEmployeeAge);
                tr.appendChild(tdEmployeeActions);
                tdEmployeeActions.appendChild(buttonDelete);
                tdEmployeeActions.appendChild(buttonDuplicate);

                buttonDelete.innerHTML = 'Delete';
                buttonDuplicate.className = 'mySuperButton'
                buttonDelete.style.background ='red';
              
                buttonDuplicate.innerHTML = 'Duplicate';
                buttonDuplicate.className = 'mySuperButton'
                buttonDuplicate.style.background = 'blue';
            }
        })
        .catch(error=>{
            console.log(error)
            console.log('toto')
        });

    }


}
