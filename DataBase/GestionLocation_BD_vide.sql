-- DROP DATABASE serge;
CREATE DATABASE serge;
USE serge;

/*
DROP TABLE statut_equipement;
DROP TABLE categories_equipements;
DROP TABLE utilisateurs;
DROP TABLE equipements;
DROP TABLE types_clients;
DROP TABLE clients;
DROP TABLE locations_equipements;
DROP TABLE retours;
DROP TABLE locations;
*/

CREATE TABLE statut_equipement
(
    id_statut INTEGER AUTO_INCREMENT,
    description VARCHAR(50),
        CONSTRAINT pk_statut_equipement PRIMARY KEY (id_statut)
);
INSERT INTO statut_equipement
        VALUES
            (NULL, 'Neuf'),
            (NULL, 'En bon état'),
            (NULL, 'Endommagé'),
            (NULL, 'Defectueux');

CREATE TABLE categories_equipements
(
    id_categorie INTEGER AUTO_INCREMENT,
    description VARCHAR(150),
        CONSTRAINT pk_categories_equipements PRIMARY KEY (id_categorie)
);
INSERT INTO categories_equipements
        VALUES
            (NULL, 'Ordinateur'),
            (NULL, "Accessoires d'ordinateurs"),
            (NULL, 'Casque VR'),
            (NULL, 'Accessoires VR'),
            (NULL, 'Raspberry Pi');

CREATE TABLE utilisateurs
(
    id_utilisateur VARCHAR(15),
    nom_utilisateur VARCHAR(50),
    prenom_utilisateur VARCHAR(50),
    mot_passe VARCHAR(300),
        CONSTRAINT pk_utilisateurs PRIMARY KEY (id_utilisateur)
);

CREATE TABLE equipements
(
    id_equipement VARCHAR(50),
    description_equipement VARCHAR(150),
    no_serie_equipement VARCHAR(150),
    categorie_id INTEGER,
        CONSTRAINT pk_equipements PRIMARY KEY (id_equipement),
        CONSTRAINT fk_equipements_categories FOREIGN KEY (categorie_id) REFERENCES categories_equipements (id_categorie)
);

CREATE TABLE types_clients
(
    id_type_client INTEGER AUTO_INCREMENT,
    description VARCHAR(50),
        CONSTRAINT pk_type_clients PRIMARY KEY (id_type_client)
);
INSERT INTO types_clients
        VALUES
            (NULL, 'Étudiant'),
            (NULL, 'Enseignant'),
            (NULL, 'Membre du personnel');

CREATE TABLE clients
(
    id_client VARCHAR(20),
    nom_client VARCHAR (75),
    prenom_client VARCHAR(75),
    type_id INTEGER,
    departement VARCHAR(100),
    courriel VARCHAR(150),
    telephone VARCHAR(10),
        CONSTRAINT pk_clients PRIMARY KEY (id_client),
        CONSTRAINT fk_clients_types FOREIGN KEY (type_id) REFERENCES types_clients (id_type_client)
);

CREATE TABLE locations
(
    id_location INTEGER AUTO_INCREMENT,
    client_id VARCHAR(20),
    date_debut DATETIME,
    is_annuler BOOLEAN DEFAULT false,
    utilisateur_id VARCHAR(15),
        CONSTRAINT pk_locations PRIMARY KEY (id_location),
        CONSTRAINT fk_locations_clients FOREIGN KEY (client_id) REFERENCES clients (id_client),
        CONSTRAINT fk_locations_utilisateurs FOREIGN KEY (utilisateur_id) REFERENCES utilisateurs (id_utilisateur)
);

CREATE TABLE retours
(
    id_retour INTEGER AUTO_INCREMENT,
    client_id VARCHAR(20),
    date_retour DATETIME,
    utilisateur_id VARCHAR(15),
        CONSTRAINT pk_retours PRIMARY KEY (id_retour),
        CONSTRAINT fk_retours_clients FOREIGN KEY (client_id) REFERENCES clients (id_client),
        CONSTRAINT fk_retours_utilisateurs FOREIGN KEY (utilisateur_id) REFERENCES utilisateurs (id_utilisateur)
);

CREATE TABLE locations_equipements
(
    location_id INTEGER,
    equipement_id VARCHAR(50),
    date_retour_prevu DATETIME,
    statut_equipement_av_location INTEGER,
    retour_id INTEGER,
    statut_equipement_ap_retour INTEGER,
    frais_retard DOUBLE,
        CONSTRAINT pk_locations_equipements PRIMARY KEY (location_id, equipement_id),
        CONSTRAINT fk_locations FOREIGN KEY (location_id) REFERENCES locations(id_location),
        CONSTRAINT fk_locations_equipements FOREIGN KEY (equipement_id) REFERENCES equipements(id_equipement),
        CONSTRAINT fk_stat_equ_av_locat FOREIGN KEY (statut_equipement_av_location) REFERENCES statut_equipement(id_statut),
        CONSTRAINT fk_stat_equ_ap_retour FOREIGN KEY (statut_equipement_ap_retour) REFERENCES statut_equipement(id_statut),
        CONSTRAINT fk_locations_retour FOREIGN KEY (retour_id) REFERENCES retours(id_retour)
);

CREATE TABLE horaire_jours
(
    journee VARCHAR(25),
        CONSTRAINT pk_horaires_jour PRIMARY KEY (journee)
);

INSERT INTO horaire_jours
        VALUES
            ('Lundi'),
            ('Mardi'),
            ('Mercredi'),
            ('Jeudi'),
            ('Vendredi');

CREATE TABLE horaire_periodes
(
    id_periode INTEGER,
    description VARCHAR(75),
        CONSTRAINT pk_horaire_periodes PRIMARY KEY (id_periode)
);

ALTER TABLE `horaire_periodes`
ADD COLUMN heure_debut TIME;

ALTER TABLE `horaire_periodes`
ADD COLUMN heure_fin TIME;

INSERT INTO horaire_periodes 
        VALUES
            (1, '8:00 à 8:50', '08:00:00', '08:50:00'),
            (2, '8:50 à 9:45', '08:50:00', '09:45:00'),
            (3, '9:45 à 10:40', '09:45:00', '10:40:00'),
            (4, '10:40 à 11:35', '10:40:00', '11:35:00'),
            (5, '11:35 à 12:10', '11:35:00', '12:10:00'),
            (6, '12:10 à 13:00', '12:10:00', '13:00:00'),
            (7, '13:00 à 13:55', '13:00:00', '13:55:00'),
            (8, '13:55 à 14:50', '13:55:00', '14:50:00'),
            (9, '15:05 à 15:55', '15:05:00', '15:55:00'),
            (10, '15:55 à 16:50', '15:55:00', '16:50:00'),
            (11, '16:50 à 17:45', '16:50:00', '17:45:00');


CREATE TABLE horaire_ouverture
(
    journee VARCHAR(25),
    periode_id INTEGER,
    is_ouvert BOOLEAN,
        CONSTRAINT pk_horaire_ouvertures PRIMARY KEY (journee, periode_id),
        CONSTRAINT fk_ouverture_jours FOREIGN KEY (journee) REFERENCES horaire_jours(journee),
        CONSTRAINT fk_ouvertur_periode FOREIGN KEY (periode_id) REFERENCES horaire_periodes(id_periode)
);

INSERT INTO horaire_ouverture 
        VALUES
            ('Lundi', 1, 0),
            ('Lundi', 2, 0),
            ('Lundi', 3, 0),
            ('Lundi', 4, 0),
            ('Lundi', 5, 0),
            ('Lundi', 6, 0),
            ('Lundi', 7, 0),
            ('Lundi', 8, 0),
            ('Lundi', 9, 0),
            ('Lundi', 10, 0),
            ('Lundi', 11, 0),
            ('Mardi', 1, 0),
            ('Mardi', 2, 0),
            ('Mardi', 3, 0),
            ('Mardi', 4, 0),
            ('Mardi', 5, 0),
            ('Mardi', 6, 0),
            ('Mardi', 7, 0),
            ('Mardi', 8, 0),
            ('Mardi', 9, 0),
            ('Mardi', 10, 0),
            ('Mardi', 11, 0),
            ('Mercredi', 1, 0),
            ('Mercredi', 2, 0),
            ('Mercredi', 3, 0),
            ('Mercredi', 4, 0),
            ('Mercredi', 5, 0),
            ('Mercredi', 6, 0),
            ('Mercredi', 7, 0),
            ('Mercredi', 8, 0),
            ('Mercredi', 9, 0),
            ('Mercredi', 10, 0),
            ('Mercredi', 11, 0),
            ('Jeudi', 1, 0),
            ('Jeudi', 2, 0),
            ('Jeudi', 3, 0),
            ('Jeudi', 4, 0),
            ('Jeudi', 5, 0),
            ('Jeudi', 6, 0),
            ('Jeudi', 7, 0),
            ('Jeudi', 8, 0),
            ('Jeudi', 9, 0),
            ('Jeudi', 10, 0),
            ('Jeudi', 11, 0),
            ('Vendredi', 1, 0),
            ('Vendredi', 2, 0),
            ('Vendredi', 3, 0),
            ('Vendredi', 4, 0),
            ('Vendredi', 5, 0),
            ('Vendredi', 6, 0),
            ('Vendredi', 7, 0),
            ('Vendredi', 8, 0),
            ('Vendredi', 9, 0),
            ('Vendredi', 10, 0),
            ('Vendredi', 11, 0);

CREATE VIEW vw_clients AS 
SELECT id_client,
		nom_client,
        prenom_client,
        departement,
        courriel,
        telephone,
        CONCAT(type_id, ' - ', description) AS type
FROM clients
INNER JOIN types_clients ON type_id = id_type_client;

CREATE VIEW vw_derniere_location AS
SELECT * 
FROM locations
ORDER BY id_location DESC
LIMIT 1;

CREATE TABLE statuts
(
id_statut INTEGER AUTO_INCREMENT NOT NULL,
description VARCHAR(10) NOT NULL,
CONSTRAINT pk_statuts PRIMARY KEY (`id_statut`)
);

INSERT INTO statuts
VALUES
(1, 'Actif'),
(2, 'Inactif');

ALTER TABLE equipements
ADD `condition` INTEGER;

ALTER TABLE equipements
ADD `statut` INTEGER;

ALTER TABLE equipements
ADD CONSTRAINT fk_equipements_statuts
FOREIGN KEY (statut) REFERENCES statuts (id_statut);

 

ALTER TABLE equipements
ADD CONSTRAINT fk_equipements_statut_equipement
FOREIGN KEY (`condition`) REFERENCES statut_equipement (id_statut);

CREATE VIEW vw_equipements AS
    SELECT e.id_equipement, e.no_serie_equipement,
            c.description AS 'categorie', e.description_equipement, s.description AS 'condition'
    FROM equipements e
    INNER JOIN categories_equipements c ON categorie_id = id_categorie
    INNER JOIN statut_equipement s ON e.condition = s.id_statut;

CREATE VIEW vw_equipements_empruntes AS
    SELECT e.id_equipement, e.no_serie_equipement,
            c.description AS 'categorie', e.description_equipement, s.description AS 'condition'
    FROM equipements e
    INNER JOIN categories_equipements c ON categorie_id = id_categorie
    INNER JOIN locations_equipements l ON e.id_equipement = l.equipement_id
    INNER JOIN statut_equipement s ON e.condition = s.id_statut
    WHERE l.retour_id IS NULL;

CREATE VIEW vw_equipements_disponibles AS
	SELECT e.id_equipement, e.no_serie_equipement,
            c.description AS 'categorie', e.description_equipement, s.description AS 'condition'
    FROM equipements e
    LEFT JOIN locations_equipements l ON e.id_equipement = l.equipement_id
    INNER JOIN categories_equipements c ON e.categorie_id = c.id_categorie
    INNER JOIN statut_equipement s ON e.condition = s.id_statut
    WHERE e.id_equipement NOT IN (SELECT equipement_id FROM locations_equipements WHERE retour_id IS NULL) AND e.statut = 1;

CREATE VIEW vw_locations_courantes AS
SELECT CONCAT(nom_client, ', ', prenom_client) AS client,
        description_equipement,
        date_debut,
        date_retour_prevu,location_id,
        client_id,
        id_equipement
FROM locations
INNER JOIN locations_equipements ON id_location = location_id
INNER JOIN clients ON id_client = client_id
INNER JOIN equipements ON equipement_id = id_equipement
WHERE retour_id IS NULL
ORDER BY date_retour_prevu DESC;

CREATE VIEW vw_retards_locations AS
SELECT id_location,
        CONCAT(nom_client, ', ', prenom_client) AS client,
        description_equipement,
        date_retour_prevu,
        DATEDIFF(CURDATE(), date_retour_prevu) AS nb_jour_retard
FROM locations
INNER JOIN locations_equipements ON id_location = location_id
INNER JOIN clients ON id_client = client_id
INNER JOIN equipements ON equipement_id = id_equipement
WHERE retour_id IS NULL AND DATE(date_retour_prevu) < CURDATE()
ORDER BY date_retour_prevu;

CREATE VIEW vw_retours_journee AS
SELECT id_location,
        CONCAT(nom_client, ', ', prenom_client) AS client,
        description_equipement,
        date_retour_prevu
FROM locations
INNER JOIN locations_equipements ON id_location = location_id
INNER JOIN clients ON id_client = client_id
INNER JOIN equipements ON equipement_id = id_equipement
WHERE retour_id IS NULL AND DATE(date_retour_prevu) = CURDATE();

CREATE VIEW vw_locations_clients AS
SELECT id_location,
		date_debut,
        description_equipement,
        description,
        date_retour_prevu,
        client_id
FROM locations
INNER JOIN locations_equipements ON location_id = id_location
INNER JOIN equipements ON equipement_id = id_equipement
INNER JOIN statut_equipement ON statut_equipement_av_location = id_statut
WHERE retour_id IS NULL;

CREATE VIEW vw_location_retour AS
SELECT equipement_id,
        description_equipement,
        CONCAT(id_statut, ' - ', description) AS etat,
        date_retour_prevu,
        location_id AS location,
        client_id
FROM locations_equipements
INNER JOIN locations ON id_location = location_id
INNER JOIN equipements ON id_equipement = equipement_id
INNER JOIN statut_equipement ON statut_equipement_av_location = id_statut
WHERE retour_id IS NULL;

CREATE VIEW vw_dernier_retour AS
SELECT *
FROM retours
ORDER BY id_retour DESC
LIMIT 1;

CREATE VIEW vw_equipements_locations AS
SELECT location_id,
equipement_id,
description_equipement,
CONCAT(a.id_statut, ' - ', a.description),
date_retour_prevu,
CONCAT(p.id_statut, ' - ', p.description),
retour_id,
date_retour,
frais_retard
FROM locations_equipements
INNER JOIN equipements ON equipement_id = id_equipement
LEFT JOIN retours ON retour_id = id_retour
INNER JOIN statut_equipement a ON statut_equipement_av_location = a.id_statut
LEFT JOIN statut_equipement p ON statut_equipement_ap_retour = p.id_statut;

CREATE VIEW vw_jours_ouvert AS
SELECT *
FROM horaire_ouverture
INNER JOIN horaire_periodes ON periode_id = id_periode
WHERE is_ouvert = 1;