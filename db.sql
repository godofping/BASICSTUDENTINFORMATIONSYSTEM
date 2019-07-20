/*
SQLyog Ultimate v8.53 
MySQL - 5.5.5-10.3.16-MariaDB : Database - student_information_db
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`student_information_db` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `student_information_db`;

/*Table structure for table `sections_table` */

DROP TABLE IF EXISTS `sections_table`;

CREATE TABLE `sections_table` (
  `sectionId` int(6) NOT NULL AUTO_INCREMENT,
  `section` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`sectionId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

/*Data for the table `sections_table` */

insert  into `sections_table`(`sectionId`,`section`) values (1,'Section 1'),(2,'Section 2'),(3,'Section 3'),(4,'Section 4');

/*Table structure for table `students_table` */

DROP TABLE IF EXISTS `students_table`;

CREATE TABLE `students_table` (
  `studentId` int(6) NOT NULL AUTO_INCREMENT,
  `firstName` varchar(60) DEFAULT NULL,
  `lastName` varchar(60) DEFAULT NULL,
  `sectionId` int(6) DEFAULT NULL,
  PRIMARY KEY (`studentId`),
  KEY `FK_student_table` (`sectionId`),
  CONSTRAINT `FK_student_table` FOREIGN KEY (`sectionId`) REFERENCES `sections_table` (`sectionId`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

/*Data for the table `students_table` */

insert  into `students_table`(`studentId`,`firstName`,`lastName`,`sectionId`) values (1,'trest','tes2',2),(2,'trest','tes2',2),(3,'trest1','tes21',1),(4,'test','test1',3),(5,'asd','asd',2),(6,'asda','asdasd',3),(7,'asd','asd',2),(8,'as','asd',1),(9,'asd','asdasd',2),(10,'asd','sd',1),(11,'as','asd',3);

/* Procedure structure for procedure `addStudents` */

/*!50003 DROP PROCEDURE IF EXISTS  `addStudents` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `addStudents`(
    
    tb_firstName VARCHAR(60),
    tb_lastName VARCHAR(60),
    cb_section INT(6)
	
    
    
    )
BEGIN
    
    insert into students_table (firstName, lastName, sectionId) values (tb_firstName, tb_lastName, cb_section);
    END */$$
DELIMITER ;

/*Table structure for table `students_view` */

DROP TABLE IF EXISTS `students_view`;

/*!50001 DROP VIEW IF EXISTS `students_view` */;
/*!50001 DROP TABLE IF EXISTS `students_view` */;

/*!50001 CREATE TABLE  `students_view`(
 `studentId` int(6) ,
 `firstName` varchar(60) ,
 `lastName` varchar(60) ,
 `sectionId` int(6) ,
 `section` varchar(60) 
)*/;

/*View structure for view students_view */

/*!50001 DROP TABLE IF EXISTS `students_view` */;
/*!50001 DROP VIEW IF EXISTS `students_view` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `students_view` AS select `students_table`.`studentId` AS `studentId`,`students_table`.`firstName` AS `firstName`,`students_table`.`lastName` AS `lastName`,`students_table`.`sectionId` AS `sectionId`,`sections_table`.`section` AS `section` from (`students_table` join `sections_table` on(`students_table`.`sectionId` = `sections_table`.`sectionId`)) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
