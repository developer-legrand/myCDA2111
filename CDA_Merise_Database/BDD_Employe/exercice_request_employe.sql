


-----------------------------EXERECICES EMPLOYE 1ERE PARTIE----------------------------------------

USE Employe
--1.	Donner nom, job, numéro et salaire de tous les employés,puis seulement des employés du département 10
--Person(employe_id, name_person, job_person, manager_employe_id, hire_date_person, wage_person, bonus_person, department_department_id)
SELECT name_person, job_person, wage_person FROM Person

SELECT name_person, job_person, wage_person FROM Person 
WHERE department_department_id = 10

--2.	Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800
SELECT name_person, job_person, wage_person FROM Person 
WHERE job_person = 'MANAGER' AND wage_person > 2800

--3.	Donner la liste des MANAGER n'appartenant pas au département 30
SELECT name_person, job_person, department_department_id  FROM Person 
WHERE job_person = 'MANAGER' AND department_department_id != 30

--4.	Liste des employés de salaire compris entre 1200 et 1400
SELECT name_person, job_person, wage_person from Person WHERE wage_person >= 1200 AND wage_person <= 1400

--5.	Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique
SELECT name_person,  department_department_id  FROM Person WHERE  department_department_id != 20 
ORDER BY name_person ASC

--6.	Liste des employés du département 30 classés dans l'ordre des salaires croissants
SELECT name_person, wage_person, department_department_id FROM Person 
WHERE department_department_id = 30 
ORDER BY wage_person ASC

--7.	Liste de tous les employés classés par emploi et salaires décroissants
SELECT name_person, job_person, wage_person FROM Person 
ORDER BY job_person ASC,  wage_person DESC

--8.	Liste des différents emplois
SELECT job_person FROM Person 
GROUP BY job_person

SELECT DISTINCT job_person FROM Person

--9.	Donner le nom du département où travaille ALEN
SELECT department_name FROM Department 
LEFT JOIN Person ON department_department_id = department_id 
WHERE name_person = 'ALEN'

--10.	Liste des employés avec nom du département, nom, job, salaire classés par noms de départements et par salaires décroissants.
SELECT name_person, job_person, wage_person, department_name FROM Person 
FULL OUTER JOIN Department ON department_department_id = department_id 
ORDER BY department_name ASC, wage_person DESC

--11.	Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + commissions
SELECT name_person, job_person, wage_person,ISNULL(bonus_person, 0), wage_person + COALESCE(bonus_person, 0)  FROM Person  
WHERE job_person = 'SALESMAN'

--12.	Liste des employés du département 20: nom, job, date d'embauche sous forme VEN 28 FEV 1997' ddd DD MM AAAA
SELECT name_person, job_person, FORMAT(hire_date_person, 'ddd dd MMM yyyy', 'FR-fr')  FROM Person 
WHERE department_department_id = 20

--13.	Donner le salaire le plus élevé par département
SELECT  MAX(wage_person), department_name FROM Person 
INNER JOIN Department ON department_department_id = department_id 
GROUP BY department_name

--14.	Donner département par département masse salariale, nombre d'employés, salaire moyen par type d'emploi.
SELECT  department_name, job_person, SUM(wage_person) AS payroll, COUNT(*) AS number_employe, AVG(wage_person) AS average_wage FROM Person
INNER JOIN Department ON department_department_id = department_id 
GROUP BY department_name, job_person 

--15.	Même question mais on se limite aux sous-ensembles d'au moins 2 employés
SELECT  department_name, job_person, SUM(wage_person) AS payroll, COUNT(*) AS number_employe , AVG(wage_person) AS average_wage FROM Person
INNER JOIN Department ON department_department_id = department_id GROUP BY department_name, job_person HAVING COUNT(*) > 1

--16.	Liste des employés (Nom, département, salaire) de même emploi que JONES
SELECT name_person, job_person, wage_person, department_name From Person 
INNER JOIN Department ON department_department_id = department_id 
WHERE job_person = (
		SELECT job_person From Person WHERE name_person = 'JONES')

--17.	Liste des employés (nom, salaire) dont le salaire est supérieur à la moyenne globale des salaires
SELECT name_person, wage_person FROM Person WHERE wage_person > (
		SELECT AVG(wage_person) FROM Person) ORDER BY name_person ASC

--18.	Création d'une table PROJET avec comme colonnes numéro de projet (3 chiffres), nom de projet(5 caractères), budget. Entrez les valeurs suivantes:
		--101, ALPHA,	96000
		--102, BETA,	82000
		--103, GAMMA,	15000



--19.   Ajouter l'attribut numéro de projet à la table EMP et affecter tous les vendeurs du département 30 au projet 101, et les autres au projet 102


UPDATE Person
SET person_projet_id 
= CASE department_department_id 
WHEN 30 THEN 101 
ELSE 102
END

--20.   Créer une vue comportant tous les employés avec nom, job, nom de département et nom de projet
CREATE VIEW EmployeInfo AS
SELECT name_person, job_person, department_name, nom_projet FROM Person 
INNER JOIN Department ON department_department_id = department_id
INNER JOIN PROJET ON projet_id = person_projet_id 


--21.	A l'aide de la vue créée précédemment, lister tous les employés avec nom, job, nom de département et nom de projet triés sur nom de département et nom de projet
SELECT  name_person, job_person, department_name, nom_projet
FROM EmployeInfo
ORDER BY department_name ASC, nom_projet ASC

--22.	Donner le nom du projet associé à chaque manager
SELECT name_person, job_person, nom_projet FROM Person 
INNER JOIN PROJET ON projet_id = person_projet_id
WHERE job_person = 'MANAGER'
ORDER BY name_person ASC


--SELECT * FROM Person

-----------------------------EXERECICES EMPLOYE 2EME PARTIE----------------------------------------

--1.	Afficher la liste des managers des départements 20 et 30
SELECT name_person, job_person, department_id FROM Person 
INNER JOIN Department ON department_department_id = department_id
WHERE (department_id = 20 OR department_id = 30) AND job_person = 'MANAGER'

--2.	Afficher la liste des employés qui ne sont pas manager et qui ont été embauchés en 81
SELECT name_person, job_person, hire_date_person FROM Person
WHERE job_person != 'MANAGER' AND YEAR(hire_date_person) = 1981

--3.	Afficher la liste des employés ayant une commission
SELECT name_person, bonus_person FROM PERSON
WHERE bonus_person != NULL OR bonus_person != 0

--4.	Afficher la liste des noms, numéros de département, jobs et date d'embauche triés par Numero de Département et JOB  les derniers embauches d'abord.
SELECT name_person, department_department_id, job_person, hire_date_person FROM Person
ORDER BY department_department_id ASC, job_person ASC,  hire_date_person DESC

--5.	Afficher la liste des employés travaillant à DALLAS
SELECT name_person, department_location FROM Person
INNER JOIN Department ON department_department_id = department_id
WHERE department_location = 'DALLAS'
	
--6.	Afficher les noms et dates d'embauche des employés embauchés avant leur manager, avec le nom et date d'embauche du manager.
SELECT e.name_person AS employe, FORMAT(e.hire_date_person, 'ddd dd MMM yyyy', 'FR-fr'), m.name_person AS manager, FORMAT(m.hire_date_person, 'ddd dd MMM yyyy', 'FR-fr') from Person AS e 
INNER JOIN Person AS m ON e.manager_employe_id = m.employe_id
WHERE e.hire_date_person < m.hire_date_person


--7.	Lister les numéros des employés n'ayant pas de subordonné.
SELECT e.name_person from Person AS e 
INNER JOIN Person AS m ON e.manager_employe_id = m.employe_id
WHERE e.employe_id NOT IN(m.manager_employe_id)
	
--8.	Afficher les noms et dates d'embauche des employés embauchés avant BLAKE.
SELECT name_person, hire_date_person FROM Person 
WHERE hire_date_person < (SELECT hire_date_person FROM Person WHERE name_person  = 'BLAKE')

--9.	Afficher les employés embauchés le même jour que FORD.
SELECT name_person, hire_date_person FROM Person 
WHERE hire_date_person = (SELECT hire_date_person FROM Person WHERE name_person  = 'FORD') AND name_person != 'FORD'

--10.	Lister les employés ayant le même manager que CLARK.
SELECT name_person, hire_date_person FROM Person 
WHERE hire_date_person = (SELECT hire_date_person FROM Person WHERE name_person  = 'FORD') AND name_person != 'FORD'

--11.	Lister les employés ayant même job et même manager que TURNER.
SELECT name_person, job_person, manager_employe_id FROM Person 
WHERE job_person = (
	SELECT job_person FROM Person
	WHERE name_person = 'TURNER') 
	--AND name_person != 'TURNER' 
	AND manager_employe_id = (
		SELECT manager_employe_id FROM Person
		WHERE name_person = 'TURNER')

--12.	Lister les employés du département RESEARCH embauchés le même jour que quelqu'un du département SALES.
SELECT EMP.name_person FROM Person AS EMP
INNER JOIN Department AS DPT ON EMP.department_department_id = DPT.department_id
WHERE DPT.department_name = 'RESEARCH' 
AND hire_date_person IN(
	SELECT hire_date_person FROM Person 
	INNER JOIN Department ON department_department_id = department_id
	WHERE department_name = 'SALES')

--13.	Lister le nom des employés et également le nom du jour de la semaine correspondant à leur date d'embauche.
SET LANGUAGE french
SELECT name_person, DATENAME(weekday,hire_date_person) AS HIREDAY FROM Person

--14.	Donner, pour chaque employé, le nombre de mois qui s'est écoulé entre leur date d'embauche et la date actuelle.
SELECT name_person, DATEDIFF(month,hire_date_person, GETDATE()) FROM Person

--15.	Afficher la liste des employés ayant un M et un A dans leur nom.
SELECT name_person FROM Person WHERE name_person LIKE '%A%M%' 

--16.	Afficher la liste des employés ayant deux 'A' dans leur nom.
SELECT name_person FROM Person WHERE name_person LIKE '%A%A%' 

--17.	Afficher les employés embauchés avant tous les employés du département 10.
SELECT name_person FROM Person WHERE hire_date_person < (
	SELECT MIN(hire_date_person) FROM Person WHERE department_department_id = 10)

--18.	Sélectionner le métier où le salaire moyen est le plus faible.
SELECT job_person, AVG(wage_person) AS AVERAGE FROM Person GROUP BY job_person H
AVING wage_person
--19.	Sélectionner le département ayant le plus d'employés.


--20.	Donner la répartition en pourcentage du nombre d'employés par département selon le modèle ci-dessous

--Département Répartition en % 
-----------       ---------------- 
--10                  21.43            
--20                 35.71            
--30	 42.86 


--DECLARE @TEST VARCHAR
--SET @TEST = (SELECT name_person FROM Person WHERE employe_id = 7839)