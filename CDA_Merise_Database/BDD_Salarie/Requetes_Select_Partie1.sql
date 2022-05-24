USE SALARIE;
--USE MASTER

-- 1.	Donner nom, EMPMETIER, numéro et salaire de tous les employés, puis seulement des employés du département 10

-- selectionne les attribut suivant à afficher : EMPNO, EMPNOM, EMPMETIER, EMPSAL depuis la table EMPlOYE
SELECT EMPNO, EMPNOM, EMPMETIER, EMPSAL 
FROM EMPlOYE;

-- selectionne les mêmes attributs uniquement pour les employé du département 10 (DPTNO = 10)
SELECT EMPNO, EMPNOM, EMPMETIER, EMPSAL 
FROM EMPlOYE WHERE EMPLOYE.DPTNO = 10;


-- 2.	Donner nom, EMPMETIER et salaire des employés de type MANAGER dont le salaire est supérieur à 2800
SELECT EMPNOM, EMPMETIER, EMPSAL 
FROM EMPlOYE 
WHERE EMPMETIER = 'MANAGER' AND EMPSAL > 2800;

-- "WHERE EMPMETIER = 'MANAGER'" : condition pour selectionner les managers
-- "AND" : pour ajouter une deuxième condition
-- "EMPSAL > 2800" : pour la condition du salaire minimal 


-- 3.	Donner la liste des MANAGER n'appartenant pas au département 30
SELECT EMPNOM, EMPMETIER, EMPLOYE.DPTNO 
FROM EMPlOYE 
WHERE EMPMETIER = 'MANAGER' AND EMPLOYE.DPTNO <> 30.

-- 4.	Liste des employés de salaire compris entre 1200 et 1400
SELECT * 
FROM  EMPlOYE 
WHERE EMPSAL > 1200 AND EMPSAL < 1400;

-- 5.	Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique
SELECT * 
FROM EMPlOYE 
WHERE EMPLOYE.DPTNO  = 10 OR EMPLOYE.DPTNO  =  30 
ORDER BY EMPNOM;
--ORDER BY : permet de définir une colonne dont on veut l'ordre alphabétique.

-- Alternative
SELECT * 
FROM EMPlOYE 
WHERE EMPLOYE.DPTNO  IN (10,30)  -- IN : permet de lister toutes les valeurs attendues
ORDER BY EMPNOM;




-- 6.	Liste des employés du département 30 classés dans l'ordre des salaires croissants

SELECT *
FROM EMPlOYE
WHERE EMPLOYE.DPTNO IN (30) 
ORDER BY EMPSAL ASC;
-- Ordre des salaires dans l'ordre croissant ASC = ordre croissant DESC = ordre décroissant

-- 7.	Liste de tous les employés classés par emploi et salaires décroissants

SELECT *
FROM EMPlOYE
ORDER BY EMPMETIER DESC,EMPSAL DESC;

-- 8.	Liste des différents emplois
SELECT DISTINCT EMPMETIER
FROM EMPlOYE

-- DISTINCT sert à lister une seule occurrence dans une colonne. 

-- Autre soloution acceptée :
SELECT EMPMETIER
FROM EMPlOYE
GROUP BY EMPMETIER;


-- 9.	Donner le nom du département où travaille ALLEN

SELECT DEPARTEMENT.DPTNOM 
FROM DEPARTEMENT
INNER JOIN EMPlOYE ON EMPlOYE.DPTNO = DEPARTEMENT.DPTNO
WHERE EMPlOYE.EMPNOM = 'ALLEN';
-- Je fais une jointure avec mon 'INNER JOIN' pour accéder au nom du département.

SELECT DEPARTEMENT.DPTNOM 
FROM DEPARTEMENT
WHERE DPTNO = (SELECT EMPlOYE.DPTNO 
					FROM EMPlOYE
					WHERE EMPNOM = 'ALLEN')

-- Deuxième version avec une sous-requête à la place d'une jointure.



-- 10.	Liste des employés avec nom du département, nom, EMPMETIER, salaire classés par noms de départements et par salaires décroissants.
SELECT EMPNOM, DPTNOM, EMPMETIER, EMPSAL 
FROM EMPlOYE 
INNER JOIN DEPARTEMENT ON EMPlOYE.DPTNO = DEPARTEMENT.DPTNO 
ORDER BY DPTNOM DESC, EMPSAL DESC


-- 11.	Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + commissions

Select EMPNOM, EMPSAL, EMPCOMM, (EMPSAL + EMPCOMM) AS CALCUL 
From EMPlOYE
WHERE EMPMETIER = 'SALESMAN';

-- On peut faire n'importe quels calculs sur n'importe quelle colonne qui utilise des valeurs de type numérique.


-- 12.	Liste des employés du département 20: nom, EMPMETIER, date d'embauche sous forme VEN 28 FEV 1997'

Select EMPNOM, EMPMETIER, FORMAT(EMPEMBDATE, 'ddd dd MMM yyyy', 'FR-fr') 
FROM EMPlOYE
WHERE DPTNO = 20;


-- 13.	Donner le salaire le plus élevé par département
SELECT MAX (EMPSAL) AS SALMAX, DPTNO 
FROM EMPlOYE 
GROUP BY DPTNO;  
-- max pour déterminer le salaire max as=alias group by pour grouper 

-- 14.	Donner département par département masse salariale, nombre d'employés, salaire moyen par type d'emploi.
     select DPTNO, SUM(EMPSAL) AS SumSal, AVG(EMPSAL) AS AverageSal, count (EMPNOM) AS EmployeeCount,EMPMETIER
	 from EMPlOYE
	 group by DPTNO,EMPMETIER
	 order by DPTNO;



-- 15.	Même question mais on se limite aux sous-ensembles d'au moins 2 employés
	SELECT DPTNOM, EMPMETIER, SUM(EMPSAL), COUNT(*) AS NBRPERSON, AVG(EMPSAL) AS AVERAGESAL 
	FROM EMPlOYE
	INNER JOIN DEPARTEMENT ON DEPARTEMENT.DPTNO = EMPlOYE.DPTNO
	GROUP BY DPTNOM, EMPMETIER 
	HAVING COUNT(*) > 1;

	-- HAVING permet d'ajouter des conditions sur des valeurs agrégée (avec un GROUP BY)

-- 16.	Liste des employés (Nom, département, salaire) de même emploi que JONES
SELECT EMPlOYE.EMPNOM, EMPlOYE.DPTNO, EMPlOYE.EMPSAL 
FROM EMPlOYE 
WHERE EMPlOYE.EMPMETIER = (SELECT EMPlOYE.EMPMETIER FROM EMPlOYE  WHERE EMPNOM ='JONES');

-- j'ai affiché la liste des employés (Nom, département, salaire) de même emploi que JONES

-- 17.	Liste des employés (nom, salaire) dont le salaire est supérieur à la moyenne globale des salaires
SELECT EMPNOM, EMPSAL 
FROM EMPlOYE
WHERE EMPSAL > (SELECT AVG(EMPSAL)FROM EMPlOYE)

-- 18.	Création d'une table PROJET avec comme colonnes numéro de projet (3 chiffres), nom de projet(5 caractères), budget. Entrez les valeurs suivantes:
-- 101, ALPHA,	96000
-- 102, BETA,	82000
-- 103, GAMMA,	15000

--VOIR AUTRES FICHIERS
 
-- 19.	Ajouter l'attribut numéro de projet à la table EMPlOYE et affecter tous les vendeurs du département 30 au projet 101, et les autres au projet 102

-- VOIR AUTRES FICHIERS

-- 20.	 Créer une vue comportant tous les employés avec nom, EMPMETIER, nom de département et nom de projet



CREATE VIEW EMPLOYE_INFO AS E
	SELECT E.EMPNOM, E.EMPMETIER, d.DPTNOM, p.PROJNOM FROM EMPlOYE AS e
	INNER JOIN DEPARTEMENT AS d ON d.DPTNO = E.DPTNO
	INNER JOIN PROJET AS p ON p.PROJNO = E.PROJNO;

-- 21.	A l'aide de la vue créée précédemment, lister tous les employés avec nom, EMPMETIER, nom de département et nom de projet triés sur nom de département et nom de projet

SELECT * FROM employees_info
	ORDER BY DPTNOM, PROJNOM;


-- 22.	Donner le nom du projet associé à chaque manager
SELECT PROJNOM FROM employees_info WHERE EMPMETIER = 'MANAGER';

CREATE TABLE nomenclature(
reference_mat_compose INT,
reference_mat_composant INT,
CONSTRAINT PK_id_nomEnclature PRIMARY KEY(reference_mat_compose, reference_mat_composant)
);


