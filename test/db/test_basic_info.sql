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
-- Table structure for table `basic_info`
--

DROP TABLE IF EXISTS `basic_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `basic_info` (
  `Employee_Id` int NOT NULL,
  `Employee_Prefix` int DEFAULT NULL,
  `Employee_First_Name` varchar(45) DEFAULT NULL,
  `Employee_Last_Name` varchar(45) DEFAULT NULL,
  `Employee_Designation` varchar(45) DEFAULT NULL,
  `Employee_Department` varchar(45) DEFAULT NULL,
  `Employee_DOB` datetime(6) DEFAULT NULL,
  `Employee_Age` varchar(45) DEFAULT NULL,
  `Employee_Religion` varchar(45) DEFAULT NULL,
  `Employee _Father/Husband` int DEFAULT NULL,
  `Employee_Father_Name` varchar(45) DEFAULT NULL,
  `Employee_Husband_Name` varchar(45) DEFAULT NULL,
  `Employee_Marital_Status` int DEFAULT NULL,
  `Employee_Phone_Number` varchar(45) DEFAULT NULL,
  `Employee_Mobile_Number` varchar(45) DEFAULT NULL,
  `Employee_Email` varchar(45) DEFAULT NULL,
  `Employee_Permanent_Address` varchar(45) DEFAULT NULL,
  `Employee_Permanent_Village` varchar(45) DEFAULT NULL,
  `Employee_Permanent_Taluka` varchar(45) DEFAULT NULL,
  `Employee_Permanent_City` varchar(45) DEFAULT NULL,
  `Employee_Permanent_District` varchar(45) DEFAULT NULL,
  `Employee_Permanent_State` varchar(45) DEFAULT NULL,
  `Employee_Permanent_Country` varchar(45) DEFAULT NULL,
  `Employee_Permanent_Pincode` varchar(45) DEFAULT NULL,
  `Employee_Permanent_Postoffice` varchar(45) DEFAULT NULL,
  `Employee_Permanent_PoliceStation` varchar(45) DEFAULT NULL,
  `Employee_Residential_Address` varchar(45) DEFAULT NULL,
  `Employee_Residential_City` varchar(45) DEFAULT NULL,
  `Employee_Residential_State` varchar(45) DEFAULT NULL,
  `Employee_Residential_Country` varchar(45) DEFAULT NULL,
  `Employee_Residential_Pincode` varchar(45) DEFAULT NULL,
  `Employee_Blood_Group` varchar(45) DEFAULT NULL,
  `Employee_Transport_Request_Status` int DEFAULT NULL,
  `Employee_Transport_Phone_Number` varchar(45) DEFAULT NULL,
  `Employee_Aadhar` varchar(45) DEFAULT NULL,
  `Employee_Aadhar_Linked_Phone` varchar(45) DEFAULT NULL,
  `Employee_Pancard` varchar(45) DEFAULT NULL,
  `Canditate_DOJ` datetime(6) DEFAULT NULL,
  `Entered_By` varchar(45) DEFAULT NULL,
  `Entered_Date` datetime(6) DEFAULT NULL,
  `Updated_By` varchar(45) DEFAULT NULL,
  `Update_Datetime` datetime(6) DEFAULT NULL,
  `Isactive` tinyint DEFAULT NULL,
  `DeleteFlag` tinyint DEFAULT NULL,
  `isaddresssame` tinyint DEFAULT NULL,
  `isphonesame` tinyint DEFAULT NULL,
  `isaddharnumbersame` tinyint DEFAULT NULL,
  PRIMARY KEY (`Employee_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `basic_info`
--

LOCK TABLES `basic_info` WRITE;
/*!40000 ALTER TABLE `basic_info` DISABLE KEYS */;
INSERT INTO `basic_info` VALUES (1,2,'fasd','fasd',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1),(2,1,'kaushik','guru',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(3,1,'fasd','fsad',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(4,1,'fsad','fsad',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(5,1,'fasd','fasd',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `basic_info` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-01-03 15:46:44
