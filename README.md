# _Hair Salon_

#### _Program to keep track of stylists and clients, 07.31.2020_

#### By _**Erich Richter**_


## Description

_Keep track of your stylists and their clients._


## Specifications

1. **Behavior:** The user is welcomed with a splash page and given the option to view Stylists or view Clients.
* **Input Example:** "View Stylists" or "View Clients"
* **Output Example:** / or / 

2. **Behavior:** The user can add a new Stylist
* **Input Example:** "Add a Stylist"
* **Output Example:** //

3. **Behavior:** The user can add a new Client
* **Input Example:** "Add new Client"
* **Output Example:** //

4. **Behavior:** The user can assign clients to a stylist(a single stylist can have many clients).
* **Input Example:** "Add client to stylist"
* **Output Example:** ///{}

## Setup/Installation Requirements

  1. Follow this [link to the project repository](https://github.com/RichterBros/Eau-Claires-Salon) on GitHub.  
  2. Click on the "Clone or download" button to copy the project link.     
  3. If you are comfortable with the command line, you can copy the project link and clone it through your command line with the command `git clone`. Otherwise, I recommend choosing "**Download ZIP**".     
   4. Once the ZIP file has finished downloading, you can right click on the file to view the zip folder in your downloads.     
  5. Right click on the project ZIP folder that you have just downloaded and choose the option "**Copy To...**", then choose the location where you would like to save this folder.      
  6. Navigate to the final location where you have chosen to save the project folder.      
  7. To view the code itself, right click, choose **open with...** and open using a text editor such as VS Code or Atom, etc.
  8. Once you are inside of your text editor, open the terminal. If you are in VS Code for example, this can be done by clicking on `Terminal` at the top of the editor and then selecting `New Terminal`. **You can navigate to different directories in the project by typing `cd DirectoryName` to go down into specific directories or `cd ..` to go back up one directory. 
  9. Navigate to the Restaurant directory by typing `cd HairSalon` in your terminal and hitting `enter`. Then type the command `dotnet restore`,`dotnet build`, then `dotnet run` into your terminal and hit enter. You should see files appear inside of your bin folder. The bin folder should appear greyed out. 
  10. Click on the link provided after you see `now listening on: ... ` appear in your terminal.

## MySQL Installation and Setup

1. Download the MySQL Web Installer from the [MySQL Downloads](https://dev.mysql.com/downloads/file/?id=484914) with the "No thanks, just start my download" link.
2. Follow along with the installer:
* Click "Yes" if prompted to update.
* Accept license terms.
* Choose Custom setup type.
* When prompted to Select Products and Features, choose the following:
  * MySQL Server 8.0.19 (This will be under "MySQL Servers > MySQL Server > MySQL Server 8.0")
  * MySQL Workbench 8.0.19 (This will be under "Applications > MySQL Workbench > MySQL Workbench 8.0")
* Select "Next", then "Execute". Wait for download and installation. (This can take a few minutes.)
* Advance through Configuration as follows:
  * High Availability set to "Standalone".
  * "Defaults are OK" under Type and Networking.
  * Authentication Method set to Use Legacy Authentication Method.
  * Set password to epicodus. You can use your own if you want but epicodus will be assumed in the lessons.
  * Defaults are OK under Windows Service. Make sure that checkboxes are checked for the options "Configure MySQL Server as a Windows Service" and "Start the MySQL Server at System Startup". Under Run Windows Service as..., the "Standard System Account" should be selected.
* Complete Installation process.

Create a local database:
1. Open MySQL WorkBench and the click on Local Insstance 3306.
2. Click the plus symbol in the top left corner of the window "Create a new SQL tab for executing queries"
3. Then copy and pase the following code into the window to create your database.
-- Table structure for table `clients`
```
DROP DATABASE IF EXISTS `erich_richter`;
CREATE DATABASE `erich_richter`;

DROP TABLE IF EXISTS `clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `clients` (
  `Address` varchar(255) COLLATE utf8mb4_vi_0900_ai_ci DEFAULT NULL,
  `PhoneNumber` varchar(255) COLLATE utf8mb4_vi_0900_ai_ci DEFAULT NULL,
  `Name` varchar(255) COLLATE utf8mb4_vi_0900_ai_ci DEFAULT NULL,
  `ClientId` int(11) NOT NULL AUTO_INCREMENT,
  `StylistId` int(11) NOT NULL,
  PRIMARY KEY (`ClientId`,`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vi_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `stylists`
--

DROP TABLE IF EXISTS `stylists`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `stylists` (
  `StylistId` int(11) NOT NULL AUTO_INCREMENT,
  `Type` varchar(255) COLLATE utf8mb4_vi_0900_ai_ci DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vi_0900_ai_ci;
```

#### Additional Setup/Installation Notes:

* No additional code is necessary to view this project.   
* Do not alter the bin/ or obj/ directories or any of the files in them.

## Known Bugs

| Bug : Message |  Situation  | Resolved (Y/N) |  How was the issue resolved?  |
| ------- | ----- | ------ | ------- |



## Support and contact details

_Please feel free to contact the author through GitHub (RichterBros) with any feedback, questions or concerns._


## Technologies Used

* C#
* .NET-Core 2.2
* ASP.NET Core MVC
* Visual Studio Code
* Git Version Control
* GitHub


### License

*This site is licensed under the MIT license.*

Copyright (c) 2020 **_Erich Richter_**