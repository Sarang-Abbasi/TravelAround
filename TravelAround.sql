-- MySQL dump 10.13  Distrib 8.0.43, for Win64 (x86_64)
--
-- Host: localhost    Database: travelaround
-- ------------------------------------------------------
-- Server version	8.0.43

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
-- Table structure for table `tblaccessibility`
--

DROP TABLE IF EXISTS `tblaccessibility`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblaccessibility` (
  `accessID` int NOT NULL AUTO_INCREMENT,
  `userID` int NOT NULL,
  `fontSize` int NOT NULL,
  `highContrast` tinyint(1) NOT NULL DEFAULT '0',
  `voiceNavigation` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`accessID`),
  UNIQUE KEY `userID` (`userID`),
  CONSTRAINT `tblaccessibility_ibfk_1` FOREIGN KEY (`userID`) REFERENCES `tblusers` (`userID`) ON DELETE CASCADE,
  CONSTRAINT `tblaccessibility_chk_1` CHECK ((`fontSize` between 1 and 5))
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblaccessibility`
--

LOCK TABLES `tblaccessibility` WRITE;
/*!40000 ALTER TABLE `tblaccessibility` DISABLE KEYS */;
INSERT INTO `tblaccessibility` VALUES (1,1,2,1,0),(2,7,1,1,0),(3,8,1,1,0);
/*!40000 ALTER TABLE `tblaccessibility` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblcities`
--

DROP TABLE IF EXISTS `tblcities`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblcities` (
  `cityID` int NOT NULL AUTO_INCREMENT,
  `cityName` varchar(100) NOT NULL,
  PRIMARY KEY (`cityID`),
  UNIQUE KEY `cityName` (`cityName`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblcities`
--

LOCK TABLES `tblcities` WRITE;
/*!40000 ALTER TABLE `tblcities` DISABLE KEYS */;
INSERT INTO `tblcities` VALUES (1,'Birmingham'),(2,'Bradford'),(3,'Brighton'),(4,'Bristol'),(5,'Cambridge'),(6,'Cardiff'),(7,'Coventry'),(8,'Edinburgh'),(9,'Glasgow'),(10,'Leeds'),(11,'Leicester'),(12,'Liverpool'),(13,'London'),(14,'Manchester'),(15,'Newcastle'),(16,'Norwich'),(17,'Nottingham'),(18,'Oxford'),(19,'Plymouth'),(20,'Sheffield'),(21,'Southampton'),(22,'York');
/*!40000 ALTER TABLE `tblcities` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblcitydistances`
--

DROP TABLE IF EXISTS `tblcitydistances`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblcitydistances` (
  `distanceID` int NOT NULL AUTO_INCREMENT,
  `cityA` varchar(100) NOT NULL,
  `cityB` varchar(100) NOT NULL,
  `distanceKm` decimal(8,2) NOT NULL,
  PRIMARY KEY (`distanceID`)
) ENGINE=InnoDB AUTO_INCREMENT=463 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblcitydistances`
--

LOCK TABLES `tblcitydistances` WRITE;
/*!40000 ALTER TABLE `tblcitydistances` DISABLE KEYS */;
INSERT INTO `tblcitydistances` VALUES (1,'Birmingham','Bradford',149.00),(2,'Bradford','Birmingham',149.00),(3,'Birmingham','Brighton',247.00),(4,'Brighton','Birmingham',247.00),(5,'Birmingham','Bristol',142.00),(6,'Bristol','Birmingham',142.00),(7,'Birmingham','Cambridge',160.00),(8,'Cambridge','Birmingham',160.00),(9,'Birmingham','Cardiff',155.00),(10,'Cardiff','Birmingham',155.00),(11,'Birmingham','Coventry',32.00),(12,'Coventry','Birmingham',32.00),(13,'Birmingham','Edinburgh',503.00),(14,'Edinburgh','Birmingham',503.00),(15,'Birmingham','Glasgow',531.00),(16,'Glasgow','Birmingham',531.00),(17,'Birmingham','Leeds',165.00),(18,'Leeds','Birmingham',165.00),(19,'Birmingham','Leicester',67.00),(20,'Leicester','Birmingham',67.00),(21,'Birmingham','Liverpool',157.00),(22,'Liverpool','Birmingham',157.00),(23,'Birmingham','London',163.00),(24,'London','Birmingham',163.00),(25,'Birmingham','Manchester',147.00),(26,'Manchester','Birmingham',147.00),(27,'Birmingham','Newcastle',296.00),(28,'Newcastle','Birmingham',296.00),(29,'Birmingham','Norwich',211.00),(30,'Norwich','Birmingham',211.00),(31,'Birmingham','Nottingham',86.00),(32,'Nottingham','Birmingham',86.00),(33,'Birmingham','Oxford',97.00),(34,'Oxford','Birmingham',97.00),(35,'Birmingham','Plymouth',282.00),(36,'Plymouth','Birmingham',282.00),(37,'Birmingham','Sheffield',119.00),(38,'Sheffield','Birmingham',119.00),(39,'Birmingham','Southampton',170.00),(40,'Southampton','Birmingham',170.00),(41,'Birmingham','York',215.00),(42,'York','Birmingham',215.00),(43,'Bradford','Brighton',398.00),(44,'Brighton','Bradford',398.00),(45,'Bradford','Bristol',310.00),(46,'Bristol','Bradford',310.00),(47,'Bradford','Cambridge',253.00),(48,'Cambridge','Bradford',253.00),(49,'Bradford','Cardiff',345.00),(50,'Cardiff','Bradford',345.00),(51,'Bradford','Coventry',181.00),(52,'Coventry','Bradford',181.00),(53,'Bradford','Edinburgh',294.00),(54,'Edinburgh','Bradford',294.00),(55,'Bradford','Glasgow',322.00),(56,'Glasgow','Bradford',322.00),(57,'Bradford','Leeds',14.00),(58,'Leeds','Bradford',14.00),(59,'Bradford','Leicester',170.00),(60,'Leicester','Bradford',170.00),(61,'Bradford','Liverpool',119.00),(62,'Liverpool','Bradford',119.00),(63,'Bradford','London',305.00),(64,'London','Bradford',305.00),(65,'Bradford','Manchester',51.00),(66,'Manchester','Bradford',51.00),(67,'Bradford','Newcastle',162.00),(68,'Newcastle','Bradford',162.00),(69,'Bradford','Norwich',288.00),(70,'Norwich','Bradford',288.00),(71,'Bradford','Nottingham',131.00),(72,'Nottingham','Bradford',131.00),(73,'Bradford','Oxford',283.00),(74,'Oxford','Bradford',283.00),(75,'Bradford','Plymouth',463.00),(76,'Plymouth','Bradford',463.00),(77,'Bradford','Sheffield',60.00),(78,'Sheffield','Bradford',60.00),(79,'Bradford','Southampton',383.00),(80,'Southampton','Bradford',383.00),(81,'Bradford','York',30.00),(82,'York','Bradford',30.00),(83,'Brighton','Bristol',262.00),(84,'Bristol','Brighton',262.00),(85,'Brighton','Cambridge',166.00),(86,'Cambridge','Brighton',166.00),(87,'Brighton','Cardiff',305.00),(88,'Cardiff','Brighton',305.00),(89,'Brighton','Coventry',221.00),(90,'Coventry','Brighton',221.00),(91,'Brighton','Edinburgh',737.00),(92,'Edinburgh','Brighton',737.00),(93,'Brighton','Glasgow',765.00),(94,'Glasgow','Brighton',765.00),(95,'Brighton','Leeds',371.00),(96,'Leeds','Brighton',371.00),(97,'Brighton','Leicester',228.00),(98,'Leicester','Brighton',228.00),(99,'Brighton','Liverpool',418.00),(100,'Liverpool','Brighton',418.00),(101,'Brighton','London',84.00),(102,'London','Brighton',84.00),(103,'Brighton','Manchester',397.00),(104,'Manchester','Brighton',397.00),(105,'Brighton','Newcastle',527.00),(106,'Newcastle','Brighton',527.00),(107,'Brighton','Norwich',201.00),(108,'Norwich','Brighton',201.00),(109,'Brighton','Nottingham',278.00),(110,'Nottingham','Brighton',278.00),(111,'Brighton','Oxford',150.00),(112,'Oxford','Brighton',150.00),(113,'Brighton','Plymouth',320.00),(114,'Plymouth','Brighton',320.00),(115,'Brighton','Sheffield',334.00),(116,'Sheffield','Brighton',334.00),(117,'Brighton','Southampton',79.00),(118,'Southampton','Brighton',79.00),(119,'Brighton','York',403.00),(120,'York','Brighton',403.00),(121,'Bristol','Cambridge',254.00),(122,'Cambridge','Bristol',254.00),(123,'Bristol','Cardiff',65.00),(124,'Cardiff','Bristol',65.00),(125,'Bristol','Coventry',157.00),(126,'Coventry','Bristol',157.00),(127,'Bristol','Edinburgh',628.00),(128,'Edinburgh','Bristol',628.00),(129,'Bristol','Glasgow',568.00),(130,'Glasgow','Bristol',568.00),(131,'Bristol','Leeds',295.00),(132,'Leeds','Bristol',295.00),(133,'Bristol','Leicester',204.00),(134,'Leicester','Bristol',204.00),(135,'Bristol','Liverpool',286.00),(136,'Liverpool','Bristol',286.00),(137,'Bristol','London',189.00),(138,'London','Bristol',189.00),(139,'Bristol','Manchester',277.00),(140,'Manchester','Bristol',277.00),(141,'Bristol','Newcastle',437.00),(142,'Newcastle','Bristol',437.00),(143,'Bristol','Norwich',323.00),(144,'Norwich','Bristol',323.00),(145,'Bristol','Nottingham',218.00),(146,'Nottingham','Bristol',218.00),(147,'Bristol','Oxford',116.00),(148,'Oxford','Bristol',116.00),(149,'Bristol','Plymouth',126.00),(150,'Plymouth','Bristol',126.00),(151,'Bristol','Sheffield',248.00),(152,'Sheffield','Bristol',248.00),(153,'Bristol','Southampton',110.00),(154,'Southampton','Bristol',110.00),(155,'Bristol','York',352.00),(156,'York','Bristol',352.00),(157,'Cambridge','Cardiff',302.00),(158,'Cardiff','Cambridge',302.00),(159,'Cambridge','Coventry',152.00),(160,'Coventry','Cambridge',152.00),(161,'Cambridge','Edinburgh',559.00),(162,'Edinburgh','Cambridge',559.00),(163,'Cambridge','Glasgow',587.00),(164,'Glasgow','Cambridge',587.00),(165,'Cambridge','Leeds',226.00),(166,'Leeds','Cambridge',226.00),(167,'Cambridge','Leicester',103.00),(168,'Leicester','Cambridge',103.00),(169,'Cambridge','Liverpool',282.00),(170,'Liverpool','Cambridge',282.00),(171,'Cambridge','London',97.00),(172,'London','Cambridge',97.00),(173,'Cambridge','Manchester',249.00),(174,'Manchester','Cambridge',249.00),(175,'Cambridge','Newcastle',371.00),(176,'Newcastle','Cambridge',371.00),(177,'Cambridge','Norwich',99.00),(178,'Norwich','Cambridge',99.00),(179,'Cambridge','Nottingham',131.00),(180,'Nottingham','Cambridge',131.00),(181,'Cambridge','Oxford',131.00),(182,'Oxford','Cambridge',131.00),(183,'Cambridge','Plymouth',376.00),(184,'Plymouth','Cambridge',376.00),(185,'Cambridge','Sheffield',195.00),(186,'Sheffield','Cambridge',195.00),(187,'Cambridge','Southampton',175.00),(188,'Southampton','Cambridge',175.00),(189,'Cambridge','York',252.00),(190,'York','Cambridge',252.00),(191,'Cardiff','Coventry',152.00),(192,'Coventry','Cardiff',152.00),(193,'Cardiff','Edinburgh',668.00),(194,'Edinburgh','Cardiff',668.00),(195,'Cardiff','Glasgow',600.00),(196,'Glasgow','Cardiff',600.00),(197,'Cardiff','Leeds',335.00),(198,'Leeds','Cardiff',335.00),(199,'Cardiff','Leicester',213.00),(200,'Leicester','Cardiff',213.00),(201,'Cardiff','Liverpool',266.00),(202,'Liverpool','Cardiff',266.00),(203,'Cardiff','London',249.00),(204,'London','Cardiff',249.00),(205,'Cardiff','Manchester',299.00),(206,'Manchester','Cardiff',299.00),(207,'Cardiff','Newcastle',442.00),(208,'Newcastle','Cardiff',442.00),(209,'Cardiff','Norwich',371.00),(210,'Norwich','Cardiff',371.00),(211,'Cardiff','Nottingham',254.00),(212,'Nottingham','Cardiff',254.00),(213,'Cardiff','Oxford',168.00),(214,'Oxford','Cardiff',168.00),(215,'Cardiff','Plymouth',186.00),(216,'Plymouth','Cardiff',186.00),(217,'Cardiff','Sheffield',283.00),(218,'Sheffield','Cardiff',283.00),(219,'Cardiff','Southampton',178.00),(220,'Southampton','Cardiff',178.00),(221,'Cardiff','York',384.00),(222,'York','Cardiff',384.00),(223,'Coventry','Edinburgh',475.00),(224,'Edinburgh','Coventry',475.00),(225,'Coventry','Glasgow',503.00),(226,'Glasgow','Coventry',503.00),(227,'Coventry','Leeds',185.00),(228,'Leeds','Coventry',185.00),(229,'Coventry','Leicester',40.00),(230,'Leicester','Coventry',40.00),(231,'Coventry','Liverpool',162.00),(232,'Liverpool','Coventry',162.00),(233,'Coventry','London',153.00),(234,'London','Coventry',153.00),(235,'Coventry','Manchester',162.00),(236,'Manchester','Coventry',162.00),(237,'Coventry','Newcastle',295.00),(238,'Newcastle','Coventry',295.00),(239,'Coventry','Norwich',206.00),(240,'Norwich','Coventry',206.00),(241,'Coventry','Nottingham',68.00),(242,'Nottingham','Coventry',68.00),(243,'Coventry','Oxford',77.00),(244,'Oxford','Coventry',77.00),(245,'Coventry','Plymouth',280.00),(246,'Plymouth','Coventry',280.00),(247,'Coventry','Sheffield',104.00),(248,'Sheffield','Coventry',104.00),(249,'Coventry','Southampton',163.00),(250,'Southampton','Coventry',163.00),(251,'Coventry','York',218.00),(252,'York','Coventry',218.00),(253,'Edinburgh','Glasgow',73.00),(254,'Glasgow','Edinburgh',73.00),(255,'Edinburgh','Leeds',335.00),(256,'Leeds','Edinburgh',335.00),(257,'Edinburgh','Leicester',491.00),(258,'Leicester','Edinburgh',491.00),(259,'Edinburgh','Liverpool',450.00),(260,'Liverpool','Edinburgh',450.00),(261,'Edinburgh','London',667.00),(262,'London','Edinburgh',667.00),(263,'Edinburgh','Manchester',341.00),(264,'Manchester','Edinburgh',341.00),(265,'Edinburgh','Newcastle',172.00),(266,'Newcastle','Edinburgh',172.00),(267,'Edinburgh','Norwich',635.00),(268,'Norwich','Edinburgh',635.00),(269,'Edinburgh','Nottingham',440.00),(270,'Nottingham','Edinburgh',440.00),(271,'Edinburgh','Oxford',614.00),(272,'Oxford','Edinburgh',614.00),(273,'Edinburgh','Plymouth',795.00),(274,'Plymouth','Edinburgh',795.00),(275,'Edinburgh','Sheffield',392.00),(276,'Sheffield','Edinburgh',392.00),(277,'Edinburgh','Southampton',720.00),(278,'Southampton','Edinburgh',720.00),(279,'Edinburgh','York',334.00),(280,'York','Edinburgh',334.00),(281,'Glasgow','Leeds',334.00),(282,'Leeds','Glasgow',334.00),(283,'Glasgow','Leicester',516.00),(284,'Leicester','Glasgow',516.00),(285,'Glasgow','Liverpool',355.00),(286,'Liverpool','Glasgow',355.00),(287,'Glasgow','London',695.00),(288,'London','Glasgow',695.00),(289,'Glasgow','Manchester',349.00),(290,'Manchester','Glasgow',349.00),(291,'Glasgow','Newcastle',232.00),(292,'Newcastle','Glasgow',232.00),(293,'Glasgow','Norwich',663.00),(294,'Norwich','Glasgow',663.00),(295,'Glasgow','Nottingham',468.00),(296,'Nottingham','Glasgow',468.00),(297,'Glasgow','Oxford',642.00),(298,'Oxford','Glasgow',642.00),(299,'Glasgow','Plymouth',823.00),(300,'Plymouth','Glasgow',823.00),(301,'Glasgow','Sheffield',382.00),(302,'Sheffield','Glasgow',382.00),(303,'Glasgow','Southampton',747.00),(304,'Southampton','Glasgow',747.00),(305,'Glasgow','York',361.00),(306,'York','Glasgow',361.00),(307,'Leeds','Leicester',157.00),(308,'Leicester','Leeds',157.00),(309,'Leeds','Liverpool',120.00),(310,'Liverpool','Leeds',120.00),(311,'Leeds','London',311.00),(312,'London','Leeds',311.00),(313,'Leeds','Manchester',69.00),(314,'Manchester','Leeds',69.00),(315,'Leeds','Newcastle',149.00),(316,'Newcastle','Leeds',149.00),(317,'Leeds','Norwich',255.00),(318,'Norwich','Leeds',255.00),(319,'Leeds','Nottingham',117.00),(320,'Nottingham','Leeds',117.00),(321,'Leeds','Oxford',270.00),(322,'Oxford','Leeds',270.00),(323,'Leeds','Plymouth',450.00),(324,'Plymouth','Leeds',450.00),(325,'Leeds','Sheffield',52.00),(326,'Sheffield','Leeds',52.00),(327,'Leeds','Southampton',370.00),(328,'Southampton','Leeds',370.00),(329,'Leeds','York',38.00),(330,'York','Leeds',38.00),(331,'Leicester','Liverpool',192.00),(332,'Liverpool','Leicester',192.00),(333,'Leicester','London',162.00),(334,'London','Leicester',162.00),(335,'Leicester','Manchester',183.00),(336,'Manchester','Leicester',183.00),(337,'Leicester','Newcastle',262.00),(338,'Newcastle','Leicester',262.00),(339,'Leicester','Norwich',176.00),(340,'Norwich','Leicester',176.00),(341,'Leicester','Nottingham',43.00),(342,'Nottingham','Leicester',43.00),(343,'Leicester','Oxford',107.00),(344,'Oxford','Leicester',107.00),(345,'Leicester','Plymouth',320.00),(346,'Plymouth','Leicester',320.00),(347,'Leicester','Sheffield',93.00),(348,'Sheffield','Leicester',93.00),(349,'Leicester','Southampton',210.00),(350,'Southampton','Leicester',210.00),(351,'Leicester','York',182.00),(352,'York','Leicester',182.00),(353,'Liverpool','London',353.00),(354,'London','Liverpool',353.00),(355,'Liverpool','Manchester',56.00),(356,'Manchester','Liverpool',56.00),(357,'Liverpool','Newcastle',271.00),(358,'Newcastle','Liverpool',271.00),(359,'Liverpool','Norwich',342.00),(360,'Norwich','Liverpool',342.00),(361,'Liverpool','Nottingham',188.00),(362,'Nottingham','Liverpool',188.00),(363,'Liverpool','Oxford',265.00),(364,'Oxford','Liverpool',265.00),(365,'Liverpool','Plymouth',407.00),(366,'Plymouth','Liverpool',407.00),(367,'Liverpool','Sheffield',130.00),(368,'Sheffield','Liverpool',130.00),(369,'Liverpool','Southampton',367.00),(370,'Southampton','Liverpool',367.00),(371,'Liverpool','York',168.00),(372,'York','Liverpool',168.00),(373,'London','Manchester',335.00),(374,'Manchester','London',335.00),(375,'London','Newcastle',461.00),(376,'Newcastle','London',461.00),(377,'London','Norwich',185.00),(378,'Norwich','London',185.00),(379,'London','Nottingham',212.00),(380,'Nottingham','London',212.00),(381,'London','Oxford',100.00),(382,'Oxford','London',100.00),(383,'London','Plymouth',339.00),(384,'Plymouth','London',339.00),(385,'London','Sheffield',268.00),(386,'Sheffield','London',268.00),(387,'London','Southampton',78.00),(388,'Southampton','London',78.00),(389,'London','York',338.00),(390,'York','London',338.00),(391,'Manchester','Newcastle',231.00),(392,'Newcastle','Manchester',231.00),(393,'Manchester','Norwich',320.00),(394,'Norwich','Manchester',320.00),(395,'Manchester','Nottingham',145.00),(396,'Nottingham','Manchester',145.00),(397,'Manchester','Oxford',261.00),(398,'Oxford','Manchester',261.00),(399,'Manchester','Plymouth',430.00),(400,'Plymouth','Manchester',430.00),(401,'Manchester','Sheffield',67.00),(402,'Sheffield','Manchester',67.00),(403,'Manchester','Southampton',347.00),(404,'Southampton','Manchester',347.00),(405,'Manchester','York',105.00),(406,'York','Manchester',105.00),(407,'Newcastle','Norwich',415.00),(408,'Norwich','Newcastle',415.00),(409,'Newcastle','Nottingham',230.00),(410,'Nottingham','Newcastle',230.00),(411,'Newcastle','Oxford',443.00),(412,'Oxford','Newcastle',443.00),(413,'Newcastle','Plymouth',597.00),(414,'Plymouth','Newcastle',597.00),(415,'Newcastle','Sheffield',174.00),(416,'Sheffield','Newcastle',174.00),(417,'Newcastle','Southampton',547.00),(418,'Southampton','Newcastle',547.00),(419,'Newcastle','York',120.00),(420,'York','Newcastle',120.00),(421,'Norwich','Nottingham',195.00),(422,'Nottingham','Norwich',195.00),(423,'Norwich','Oxford',229.00),(424,'Oxford','Norwich',229.00),(425,'Norwich','Plymouth',487.00),(426,'Plymouth','Norwich',487.00),(427,'Norwich','Sheffield',243.00),(428,'Sheffield','Norwich',243.00),(429,'Norwich','Southampton',260.00),(430,'Southampton','Norwich',260.00),(431,'Norwich','York',270.00),(432,'York','Norwich',270.00),(433,'Nottingham','Oxford',168.00),(434,'Oxford','Nottingham',168.00),(435,'Nottingham','Plymouth',348.00),(436,'Plymouth','Nottingham',348.00),(437,'Nottingham','Sheffield',55.00),(438,'Sheffield','Nottingham',55.00),(439,'Nottingham','Southampton',243.00),(440,'Southampton','Nottingham',243.00),(441,'Nottingham','York',136.00),(442,'York','Nottingham',136.00),(443,'Oxford','Plymouth',239.00),(444,'Plymouth','Oxford',239.00),(445,'Oxford','Sheffield',218.00),(446,'Sheffield','Oxford',218.00),(447,'Oxford','Southampton',93.00),(448,'Southampton','Oxford',93.00),(449,'Oxford','York',298.00),(450,'York','Oxford',298.00),(451,'Plymouth','Sheffield',388.00),(452,'Sheffield','Plymouth',388.00),(453,'Plymouth','Southampton',168.00),(454,'Southampton','Plymouth',168.00),(455,'Plymouth','York',494.00),(456,'York','Plymouth',494.00),(457,'Sheffield','Southampton',321.00),(458,'Southampton','Sheffield',321.00),(459,'Sheffield','York',57.00),(460,'York','Sheffield',57.00),(461,'Southampton','York',395.00),(462,'York','Southampton',395.00);
/*!40000 ALTER TABLE `tblcitydistances` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblroutes`
--

DROP TABLE IF EXISTS `tblroutes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblroutes` (
  `routeID` int NOT NULL AUTO_INCREMENT,
  `userID` int NOT NULL,
  `startLocation` varchar(100) NOT NULL,
  `endLocation` varchar(100) NOT NULL,
  `routeDistance` decimal(10,2) NOT NULL,
  `routeTime` decimal(10,2) NOT NULL,
  `transportID` int NOT NULL,
  `dateCreated` datetime DEFAULT CURRENT_TIMESTAMP,
  `stopLocations` text,
  PRIMARY KEY (`routeID`),
  KEY `userID` (`userID`),
  KEY `transportID` (`transportID`),
  CONSTRAINT `tblroutes_ibfk_1` FOREIGN KEY (`userID`) REFERENCES `tblusers` (`userID`) ON DELETE CASCADE,
  CONSTRAINT `tblroutes_ibfk_2` FOREIGN KEY (`transportID`) REFERENCES `tbltransport` (`transportID`),
  CONSTRAINT `tblroutes_chk_1` CHECK ((`routeDistance` >= 0)),
  CONSTRAINT `tblroutes_chk_2` CHECK ((`routeTime` >= 0))
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblroutes`
--

LOCK TABLES `tblroutes` WRITE;
/*!40000 ALTER TABLE `tblroutes` DISABLE KEYS */;
INSERT INTO `tblroutes` VALUES (4,7,'London','Paris',135.00,2.25,1,'2026-01-29 20:50:10','Berlin'),(5,1,'Ankara','Tokyo',150.00,2.50,3,'2026-02-23 17:03:25','Paris|Osaka'),(6,8,'UK','London',150.00,10.00,2,'2026-02-23 17:14:24','Paris|Osaka'),(7,8,'London','Alexzandiea',150.00,2.50,4,'2026-02-23 17:27:18','Paris|Berlin'),(8,8,'Birmingham','Liverpool',187.00,0.23,4,'2026-02-23 20:01:50','Glasgow|London'),(9,8,'Leeds','Cardiff',350.00,4.38,3,'2026-02-23 20:24:55','Edinburgh'),(10,8,'Birmingham','Norwich',226.00,0.28,4,'2026-02-24 00:23:29','Leeds');
/*!40000 ALTER TABLE `tblroutes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblsavedroutes`
--

DROP TABLE IF EXISTS `tblsavedroutes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblsavedroutes` (
  `savedRouteID` int NOT NULL AUTO_INCREMENT,
  `userID` int NOT NULL,
  `routeID` int NOT NULL,
  `savedName` varchar(50) DEFAULT NULL,
  `dateSaved` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`savedRouteID`),
  KEY `userID` (`userID`),
  KEY `routeID` (`routeID`),
  CONSTRAINT `tblsavedroutes_ibfk_1` FOREIGN KEY (`userID`) REFERENCES `tblusers` (`userID`) ON DELETE CASCADE,
  CONSTRAINT `tblsavedroutes_ibfk_2` FOREIGN KEY (`routeID`) REFERENCES `tblroutes` (`routeID`) ON DELETE CASCADE,
  CONSTRAINT `tblsavedroutes_chk_1` CHECK ((char_length(`savedName`) <= 50))
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblsavedroutes`
--

LOCK TABLES `tblsavedroutes` WRITE;
/*!40000 ALTER TABLE `tblsavedroutes` DISABLE KEYS */;
INSERT INTO `tblsavedroutes` VALUES (4,7,4,'London → Paris','2026-01-29 20:50:10'),(5,1,5,'Berlin → Tokyo','2026-02-23 17:03:25'),(6,8,6,'London → Tokyo','2026-02-23 17:14:24'),(7,8,7,'London → Alexzandiea','2026-02-23 17:27:18'),(8,8,8,'Birmingham → Liverpool','2026-02-23 20:01:50'),(9,8,9,'Leeds → Cardiff','2026-02-23 20:24:55'),(10,8,10,'Birmingham → Norwich','2026-02-24 00:23:29');
/*!40000 ALTER TABLE `tblsavedroutes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbltransport`
--

DROP TABLE IF EXISTS `tbltransport`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbltransport` (
  `transportID` int NOT NULL AUTO_INCREMENT,
  `transportType` varchar(20) NOT NULL,
  `averageSpeed` decimal(10,2) NOT NULL,
  `ecoRating` int NOT NULL,
  PRIMARY KEY (`transportID`),
  UNIQUE KEY `transportType` (`transportType`),
  CONSTRAINT `tbltransport_chk_1` CHECK ((`averageSpeed` >= 0)),
  CONSTRAINT `tbltransport_chk_2` CHECK ((`ecoRating` between 1 and 5))
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbltransport`
--

LOCK TABLES `tbltransport` WRITE;
/*!40000 ALTER TABLE `tbltransport` DISABLE KEYS */;
INSERT INTO `tbltransport` VALUES (1,'Car',60.00,3),(2,'Bike',15.00,4),(3,'Walk',5.00,5),(4,'Plane',800.00,2);
/*!40000 ALTER TABLE `tbltransport` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblusers`
--

DROP TABLE IF EXISTS `tblusers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblusers` (
  `userID` int NOT NULL AUTO_INCREMENT,
  `userName` varchar(30) NOT NULL,
  `userEmail` varchar(100) NOT NULL,
  `userPassword` varchar(255) NOT NULL,
  `userJoinDate` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`userID`),
  UNIQUE KEY `userName` (`userName`),
  UNIQUE KEY `userEmail` (`userEmail`),
  CONSTRAINT `tblusers_chk_1` CHECK ((char_length(`userName`) <= 30)),
  CONSTRAINT `tblusers_chk_2` CHECK ((char_length(`userPassword`) >= 8))
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblusers`
--

LOCK TABLES `tblusers` WRITE;
/*!40000 ALTER TABLE `tblusers` DISABLE KEYS */;
INSERT INTO `tblusers` VALUES (1,'testuser','test@test.com','c3fcd3d76192e4007dfb496cca67e13b','2026-01-29 19:56:15'),(7,'abc','abc@123.com','ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f','2026-01-29 20:28:21'),(8,'qw','1@1.com','ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f','2026-01-31 01:49:01');
/*!40000 ALTER TABLE `tblusers` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-02-24  0:36:24
