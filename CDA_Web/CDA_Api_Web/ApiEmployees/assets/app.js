import { Employee } from "./Employee.js";
import { TableEmployee } from "./TableEmployee.js"

let myNewTable = new TableEmployee();

const myTableData = document.getElementById('columnEntitledTable');
const rowCategoryHeader = document.createElement('tr');
const arrayHeader = ['EID', 'Full Name', 'Email', 'Monthly salary', 'Year of birth', 'Actions'];
myTableData.appendChild(rowCategoryHeader);
myNewTable.createHeader(rowCategoryHeader, arrayHeader);
