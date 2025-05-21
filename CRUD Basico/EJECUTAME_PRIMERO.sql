CREATE DATABASE IF NOT EXISTS prueba;

CREATE USER IF NOT EXISTS 'usu'@'%' IDENTIFIED BY 'contra';

GRANT ALL PRIVILEGES ON prueba.* TO 'usu'@'%';
FLUSH PRIVILEGES;
SHOW GRANTS FOR 'usu'@'%';

USE prueba;

CREATE TABLE IF NOT EXISTS Buscaminas
(
 idBuscaminas  INT AUTO_INCREMENT PRIMARY KEY,
 nombreJugador VARCHAR(100),
 movimientos   INT,
 gano          BIT
);

CREATE TABLE IF NOT EXISTS Dificultad
(
 idNivel  INT AUTO_INCREMENT PRIMARY KEY,
 nombre   VARCHAR(100),
 filas    INT,
 columnas INT,
 minas    INT
);
INSERT INTO Buscaminas (nombreJugador, movimientos, gano)
SELECT 'Panfilo', 12, false
WHERE NOT EXISTS (
                  SELECT 1 FROM Buscaminas WHERE nombreJugador = 'Panfilo' AND movimientos = 12 AND gano = false
                 );

INSERT INTO Buscaminas (nombreJugador, movimientos, gano)
SELECT 'Velarmino', 10, 0
WHERE NOT EXISTS (
                  SELECT 1 FROM Buscaminas WHERE nombreJugador = 'Velarmino' AND movimientos = 10 AND gano = 0
                 );

INSERT INTO Buscaminas (nombreJugador, movimientos, gano)
SELECT 'Pacifuentes', 1, 0
WHERE NOT EXISTS (
                  SELECT 1 FROM Buscaminas WHERE nombreJugador = 'Pacifuentes' AND movimientos = 1 AND gano = 0
                 );

INSERT INTO Buscaminas (nombreJugador, movimientos, gano)
SELECT 'De', 2, 1
WHERE NOT EXISTS (
                  SELECT 1 FROM Buscaminas WHERE nombreJugador = 'De' AND movimientos = 2 AND gano = 1
                 );

INSERT INTO Buscaminas (nombreJugador, movimientos, gano)
SELECT 'Leon', 2, 1
WHERE NOT EXISTS (
                  SELECT 1 FROM Buscaminas WHERE nombreJugador = 'Leon' AND movimientos = 2 AND gano = 1
                 );

INSERT INTO Buscaminas (nombreJugador, movimientos, gano)
SELECT 'Manso', 3, 1
WHERE NOT EXISTS (
                  SELECT 1 FROM Buscaminas WHERE nombreJugador = 'Manso' AND movimientos = 3 AND gano = 1
                 );
