drop database if EXISTS cityBuilder;  ;
create database  IF NOT EXISTS cityBuilder   ;

  use  cityBuilder; 
    DROP TABLE IF EXISTS `user`;
  CREATE TABLE `user` (
  `iduser` int(11) NOT NULL AUTO_INCREMENT,
  `voornaam` varchar(45) DEFAULT NULL,
  `naam` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `vegan` tinyint(4) DEFAULT NULL,
  `veganistisch` tinyint(4) DEFAULT NULL,
  `admin` tinyint(4) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`iduser`));
  