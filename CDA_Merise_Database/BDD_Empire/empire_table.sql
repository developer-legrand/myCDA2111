
USE EMPIRE

CREATE TABLE Environments
(environment_id INT IDENTITY PRIMARY KEY, 
environment_name VARCHAR(20) NOT NULL);

CREATE TABLE Galaxies(
code_galaxy VARCHAR(20) PRIMARY KEY,
galaxy_name VARCHAR(20) NOT NULL,
distance_bushbe BIGINT NOT NULL,
planet_zone INT NOT NULL
);

CREATE TABLE Planets(
code_planet VARCHAR(20) PRIMARY KEY,
name_planet VARCHAR(20) NOT NULL UNIQUE, 
gravity_planet INT NOT NULL, 
submission_planet BIT NOT NULL, 
speed_gravity SMALLINT NOT NULL,
planet_environment_id INT,
planet_code_galaxy VARCHAR(20),
CONSTRAINT FK_planet_environment_id FOREIGN KEY (planet_environment_id) REFERENCES Environments(environment_id),
CONSTRAINT FK_planet_code_galaxy FOREIGN KEY (planet_code_galaxy) REFERENCES Galaxies(code_galaxy)
);

CREATE TABLE Specialisations(
specialisation_id SMALLINT IDENTITY PRIMARY KEY,
specialisation_name VARCHAR(20) NOT NULL
);

CREATE TABLE Missions(
code_mission VARCHAR(20) PRIMARY KEY,
number_ship SMALLINT NOT NULL,
mission_code_galaxy VARCHAR(20),
mission_code_planet VARCHAR(20),
mission_specialisation_id SMALLINT,
CONSTRAINT FK_mission_code_galaxy FOREIGN KEY (mission_code_galaxy) REFERENCES Galaxies(code_galaxy),
CONSTRAINT FK_mission_code_planet FOREIGN KEY (mission_code_planet) REFERENCES Planets(code_planet),
CONSTRAINT FK_mission_specialisation_id FOREIGN KEY (mission_specialisation_id) REFERENCES Specialisations(specialisation_id)
);

CREATE TABLE Ships(
code_ship VARCHAR(20) PRIMARY KEY,
radius_action BIGINT NOT NULL,
number_pilot INT NOT NULL,
speed_max BIGINT,
speed_min BIGINT,
ship_environment_id INT,
ship_specialisation_id SMALLINT,
ship_code_mission VARCHAR(20),
CONSTRAINT FK_ship_environment_id FOREIGN KEY (ship_environment_id) REFERENCES Environments(environment_id),
CONSTRAINT FK_ship_specialisation_id FOREIGN KEY (ship_specialisation_id) REFERENCES Specialisations(specialisation_id),
CONSTRAINT FK_ship_code_mission FOREIGN KEY (ship_code_mission) REFERENCES Missions(code_mission)
);


CREATE TABLE CREWS(
code_crew VARCHAR(20) PRIMARY KEY,
crew_code_ship VARCHAR(20),
CONSTRAINT FK_crew_code_ship FOREIGN KEY (crew_code_ship) REFERENCES Ships(code_ship),
);


CREATE TABLE People(
matricule BIGINT IDENTITY PRIMARY KEY,
lastname VARCHAR(20) NOT NULL,
firstname VARCHAR(20) NOT NULL,
age INT NOT NULL,
grade VARCHAR(20),
job VARCHAR (15) NOT NULL,
people_code_crew VARCHAR(20),
people_specialisation_id SMALLINT,
CONSTRAINT FK_people_code_crew FOREIGN KEY (people_code_crew) REFERENCES Crews(code_crew),
CONSTRAINT FK_people_specialisation_id FOREIGN KEY (people_specialisation_id) REFERENCES Specialisations(specialisation_id),
);