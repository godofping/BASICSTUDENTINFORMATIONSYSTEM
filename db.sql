/*
SQLyog Ultimate v8.53 
MySQL - 5.5.5-10.1.38-MariaDB : Database - student_information_db
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`student_information_db` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `student_information_db`;

/*Table structure for table `section_table` */

DROP TABLE IF EXISTS `section_table`;

CREATE TABLE `section_table` (
  `sectionId` int(6) NOT NULL AUTO_INCREMENT,
  `section` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`sectionId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `section_table` */

/*Table structure for table `student_table` */

DROP TABLE IF EXISTS `student_table`;

CREATE TABLE `student_table` (
  `studentId` int(6) NOT NULL AUTO_INCREMENT,
  `firstName` varchar(60) DEFAULT NULL,
  `lastName` varchar(60) DEFAULT NULL,
  `sectionId` int(6) DEFAULT NULL,
  PRIMARY KEY (`studentId`),
  KEY `FK_student_table` (`sectionId`),
  CONSTRAINT `FK_student_table` FOREIGN KEY (`sectionId`) REFERENCES `section_table` (`sectionId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `student_table` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
