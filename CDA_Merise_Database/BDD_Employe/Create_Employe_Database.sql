USE Employe

CREATE TABLE Department(
department_id SMALLINT IDENTITY(10,10) PRIMARY KEY,
department_name VARCHAR(50) NOT NULL,
department_location VARCHAR(50) NOT NULL,
);

CREATE TABLE Person(
employe_id SMALLINT PRIMARY KEY,
job_person VARCHAR(20) NOT NULL,
hire_date_person DATE NOT NULL,
name_person VARCHAR(50) NOT NULL,
wage_person MONEY NOT NULL,
bonus_person MONEY,
department_department_id SMALLINT,
manager_employe_id SMALLINT NOT NULL,
CONSTRAINT FK_manager_id FOREIGN KEY(manager_employe_idREFERENCES Person(employe_id),
CONSTRAINT FK_department_id FOREIGN KEY(department_department_id)REFERENCES Department(department_id),
);

CREATE TABLE PROJET(
projet_id SMALLINT IDENTITY(101,1) PRIMARY KEY,
CONSTRAINT CHK_projet_id CHECK (projet_id <= 999 AND projet_id >= 101),
nom_projet VARCHAR(5) NOT NULL,
budget_projet INT NOT NULL,
);

ALTER TABLE Person
ADD person_projet_id SMALLINT

ALTER TABLE Person
ADD CONSTRAINT FK_projet_id FOREIGN KEY(person_projet_id) REFERENCES PROJET(projet_id)

--SELECT * FROM DEPARTMENT

--ALTER TABLE Person ADD manager_employe_id SMALLINT 
ALTER TABLE Person ALTER COLUMN manager_employe_id SMALLINT