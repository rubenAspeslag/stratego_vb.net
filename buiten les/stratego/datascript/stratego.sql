drop database if  EXISTS stratego;
create database if not EXISTS stratego ;
CREATE TABLE `stratego`.`player` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(300) NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC)
  );
  CREATE TABLE `stratego`.`strategoplay` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `player1` INT NULL,
  `player2` INT NULL,
  `start` DATETIME NULL,
  PRIMARY KEY (`id`));
CREATE TABLE `stratego`.`strategounits` (
  `id` INT NOT NULL,
  `rank` INT NULL,
  `strategoUnitscol` INT NULL,
  `img` VARCHAR(300) NULL,
  PRIMARY KEY (`id`));
  CREATE TABLE `stratego`.`strategounitplay` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `idunit` INT NULL,
  `idgame` INT NULL,
   `x` INT NULL,
  `y` INT NULL,
  PRIMARY KEY (`id`));



