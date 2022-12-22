-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: localhost    Database: test
-- ------------------------------------------------------
-- Server version	8.0.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `studentinfo`
--

DROP TABLE IF EXISTS `studentinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `studentinfo` (
  `Canditate_ID` int NOT NULL AUTO_INCREMENT,
  `Canditate_First_Name` varchar(45) NOT NULL,
  `Canditate_Last_Name` varchar(45) NOT NULL,
  `Canditate_Aadhar` varchar(25) NOT NULL,
  `Canditate_PANCard` varchar(45) NOT NULL,
  `Canditate_Email` varchar(45) NOT NULL,
  `Canditate_Gender` int NOT NULL,
  `Canditate_Location` int NOT NULL,
  `Canditate_maritial_Status` int NOT NULL,
  `Canditate_DOJ` datetime(6) DEFAULT NULL,
  `Canditate_Department` varchar(45) DEFAULT NULL,
  `Canditate_Address_1` varchar(1000) DEFAULT NULL,
  `Canditate_Alt_Number` varchar(45) DEFAULT NULL,
  `Entered_By` varchar(45) DEFAULT NULL,
  `Entered_Date` datetime(6) DEFAULT NULL,
  `Updated_By` varchar(45) DEFAULT NULL,
  `Updated_Date` datetime(6) DEFAULT NULL,
  `IsActive` tinyint DEFAULT NULL,
  `DeleteFlag` tinyint DEFAULT NULL,
  `Canditate_ID_Number` varchar(45) DEFAULT NULL,
  `Canditate_Base_Location` varchar(45) DEFAULT NULL,
  `Canditate_Mobile` varchar(45) DEFAULT NULL,
  `Canditate_Prefix` int NOT NULL,
  `Canditate_Address_2` varchar(45) DEFAULT NULL,
  `Canditate_Address_3` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Canditate_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentinfo`
--

LOCK TABLES `studentinfo` WRITE;
/*!40000 ALTER TABLE `studentinfo` DISABLE KEYS */;
INSERT INTO `studentinfo` VALUES (3,'fasd','fasd','fasd','fsad','fasd',1,1,1,'2022-12-23 22:29:00.000000','fas','fasd','fasd',NULL,NULL,NULL,NULL,NULL,NULL,'fsad','fasd','fsad',2,'fas','fasd');
/*!40000 ALTER TABLE `studentinfo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-22 23:29:04
