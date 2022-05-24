USE GarageAutoRetro

CREATE TABLE realisations (
id_rea INT NOT NULL,
titre_rea VARCHAR(255) NOT NULL,
date_rea DATE NOT NULL,
texte_rea TEXT NOT NULL
)

CREATE TABLE images (
id_img INT  NOT NULL,
url_img VARCHAR(20) NOT NULL,
nom_img VARCHAR(20) NOT NULL,
text_img VARCHAR(20) NOT NULL,
ext_img VARCHAR(20) NOT NULL
) 

--INSERER UNE LIGNE A LA TABLE 'RESILIATIONS'
INSERT INTO realisations (id_rea, titre_rea, date_rea,texte_rea)
VALUES (10, 'test', GETDATE(), 'ceci est un test');

INSERT INTO realisations (titre_rea, date_rea,texte_rea)
VALUES 
('test', GETDATE(), 'ceci est un test'),
('test', GETDATE(), 'ceci est un test'),
('test', GETDATE(), 'ceci est un test'),
('test', GETDATE(), 'ceci est un test');


--INSERER UNE LIGNE A LA TABLE 'IMAGES'
INSERT INTO images (id_img, url_img, nom_img, text_img, ext_img)
VALUES (10, 'www.img.com', 'name image', 'texte de mon image', 'format image');

INSERT INTO images (url_img, nom_img, text_img, ext_img)
VALUES 
('www.img.com', 'name image', 'texte de mon image', 'format image'),
('www.img.com', 'name image', 'texte de mon image', 'format image'),
('www.img.com', 'name image', 'texte de mon image', 'format image'),
('www.img.com', 'name image', 'texte de mon image', 'format image'),
('www.img.com', 'name image', 'texte de mon image', 'format image'),
('www.img.com', 'name image', 'texte de mon image', 'format image');



------------------------------ VERSION DROP TABLE 'REALISATIONS' -------------------------------

--PERMETTRE L'INSERTION DANS LA PRIMARY KEY IDENTITY DE LA TABLE PROVISOIRE
--SET IDENTITY_INSERT realisations_temp ON
--CONDITION
--SET IDENTITY_INSERT realisations_temp OFF

--CREATION D'UNE TABLE PROVISOIRE
CREATE TABLE realisations_temp (
id_rea INT IDENTITY NOT NULL PRIMARY KEY,
titre_rea VARCHAR(255) NOT NULL,
date_rea DATE NOT NULL,
texte_rea TEXT NOT NULL
);

--INSERER LES DONNEES D'UNE TABLE VERS UNE AUTRE TABLE
--1/
SET IDENTITY_INSERT realisations_temp ON;
--2/
INSERT INTO realisations_temp(id_rea , titre_rea,date_rea ,texte_rea)
    SELECT id_rea , titre_rea,date_rea ,texte_rea
    FROM realisations
SET IDENTITY_INSERT realisations_temp OFF;	

--RENOMMER MA TABLE
EXEC sp_rename 'realisations_temp ', 'realisations'; 

DROP TABLE realisations;
DROP TABLE realisations_temp;
SELECT * FROM realisations;
SELECT * FROM realisations_temp;

------------------------------ VERSION DROP TABLE 'IMAGES' -------------------------------

--PERMETTRE L'INSERTION DANS LA PRIMARY KEY IDENTITY DE LA TABLE PROVISOIRE
--SET IDENTITY_INSERT realisations_temp ON
--CONDITION
--SET IDENTITY_INSERT realisations_temp OFF

--CREATION D'UNE TABLE PROVISOIRE
CREATE TABLE images_temp (
id_img INT IDENTITY NOT NULL PRIMARY KEY,
url_img VARCHAR(20) NOT NULL,
nom_img VARCHAR(20) NOT NULL,
text_img VARCHAR(20) NOT NULL,
ext_img VARCHAR(20) NOT NULL
);

--INSERER LES DONNEES D'UNE TABLE VERS UNE AUTRE TABLE
--1/
SET IDENTITY_INSERT images_temp ON;
--2/
INSERT INTO images_temp(id_img, url_img, nom_img, text_img, ext_img)
    SELECT id_img, url_img, nom_img, text_img, ext_img
    FROM images;  
SET IDENTITY_INSERT images_temp OFF;	

--RENOMMER MA TABLE
EXEC sp_rename 'images_temp ', 'images'; 

DROP TABLE images;
DROP TABLE images_temp;
SELECT * FROM images;
SELECT * FROM images_temp;

------------------------------ RELIER LA TABLE 'REALISATIONS' 1 --> * 'IMAGES' AVEC CONTRAINTE FK -------------------------------
ALTER TABLE realisations
ADD id_realisations_img INT;


ALTER TABLE realisations
DROP CONSTRAINT FK_realisations_id_img;
ALTER TABLE realisations
DROP COLUMN id_realisations_img;

ALTER TABLE images
DROP CONSTRAINT FK_realisations_id_img;
ALTER TABLE images
DROP COLUMN id_images_rea;
------------------------------ RELIER LA TABLE 'REALISATIONS' * >--< * 'IMAGES' AVEC CONTRAINTE FK -------------------------------

CREATE TABLE illustrer (
id_illustrer_img INT,
id_illustrer_rea INT,
CONSTRAINT PK_id_illustrer PRIMARY KEY (id_illustrer_img, id_illustrer_rea),
CONSTRAINT FK_illustrer_id_img FOREIGN KEY (id_illustrer_img) REFERENCES images (id_img),
CONSTRAINT FK_illustrer_id_rea FOREIGN KEY (id_illustrer_rea) REFERENCES realisations (id_rea)
);

USE GarageAutoRetro
DROP TABLE illustrer

SELECT * FROM illustrer
SELECT * FROM realisations
SELECT * FROM images

ALTER TABLE realisations
ADD riri INT, loulou INT;



