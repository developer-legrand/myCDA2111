

export class Employee {
    constructor(idEmploye, nameEmployee, salaryEmployee, dateBirthEmployee) {
        this.idEmploye = idEmploye;
        this.nameEmployee = nameEmployee;
        this.salaryEmployee = salaryEmployee;
        this.dateBirthEmployee = dateBirthEmployee;
        this.profileImage = "";
    }


    getMail() {
       let emailFormat = this.nameEmployee[0].toLowerCase()+'.'+this.nameEmployee.split(' ')[1].toLowerCase()+'@email.com'
        return emailFormat;
    }   

    getMonthlySalary() {
        let monthlySalary = Math.round(this.salaryEmployee/12*100)/100 +' €';
        return monthlySalary;
    }

}
