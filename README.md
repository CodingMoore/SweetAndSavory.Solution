# **SweetAndSavory.Solution**
Project Initiated: 2021-01-15<br>
Updated: 2021-01-15

## **Project Description**

This project was created to help us further our knowledge with using join statements to help connect tables in our database. We are also practicing with using many to many relationships within our application and database tables. This application is designed to help a factory owner keep track of the machines used in their factory(s) and the engineers that maintain these machines.  The User Story is below.

//USER STORIES PUT IN TABLE (optional)
* As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines.
* As the factory manager, I need to be able to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it.
* As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed.
* As the factory manager, I should be able to add new machines even if no engineers are employed. I should also be able to add new engineers even if no machines are installed
* As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine.
* As the factory manager, I should be able to navigate to a splash page that lists all engineers and machines. Users should be able to click on an individual engineer or machine to see all the engineers/machines that belong to it.



## **Required for Use**
* C# and .Net Core installed on your local machine. (Developed on .Net Core v2.2.4)
* Console/Terminal access.
* Code Editor like [Visual Studio Code](https://code.visualstudio.com/)
* MySQL Community Server
* MySQL Workbench


## **Installation Instructions**
Download [.Net Core](https://dotnet.microsoft.com/download) and follow the installation instructions for your computer's
operating system.



### **Installing C#, .NET**
Install C# and .Net according to your operating system below:

**For Mac**
1. Download this .NET Core SDK Software Development Kit. 
2. Open the .pkg file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
3. Confirm the installation is successful by opening your terminal and running the command <code>dotnet --version</code>, which should return the correct version number.

**For Windows (10+)**
1. Download either the the 64-bit .NET Core SDK Software Development Kit
2. Open the file and follow the steps provided by the installer for your OS.
3. Confirm the installation is successful by opening a new Windows PowerShell window and running the command <code>dotnet --version</code> You should see a response with the correct version number.

**My SQL Installation Below** 

**Windows 10 -**

Start by downloading the MySQL Web Installer from the [MySQL Downloads](https://dev.mysql.com/downloads/file/?id=484919) page. (Use the No thanks, just start my download link.)

Follow along with the installer:

1) Click "Yes" if prompted to update.
2) Accept license terms.
3) Choose Custom setup type.
4) When prompted to Select Products and Features, choose the following:
* MySQL Server 8.0.19 (This will be under "MySQL Servers > MySQL Server > MySQL Server 8.0")

* MySQL Workbench 8.0.19 (This will be under "Applications > MySQL Workbench > MySQL Workbench 8.0")

5) Select "Next", then "Execute". Wait for download and installation. (This can take a few minutes.)

6) Advance through Configuration as follows:

* High Availability set to "Standalone".

* "Defaults are OK" under Type and Networking.

* Authentication Method set to Use Legacy Authentication Method.

* Set password to something you will remember. 

* Defaults are OK under Windows Service. Make sure that checkboxes are checked for the options "Configure MySQL Server as a Windows Service" and "Start the MySQL Server at System Startup". Under Run Windows Service as..., the "Standard System Account" should be selected.

7) Complete Installation process.
Next, add the MySQL environment variable to the System PATH. We must include MySQL in the System Environment Path Variable. This is its own multi-step process:

8) Open the Control Panel and visit System and "Security > System". Select "Change Settings" and a pop-up window will display. Select the tab "Advanced" and select the "Environment Variables" button.
9) Within the System Variables navigator window, select PATH..., click Edit..., and then New.

10) Add the exact location of your MySQL installation, and click OK. (This location is likely C:\Program Files\MySQL\MySQL Server 8.0\bin, but may differ depending on your specific installation.)

**MacOS -**

Start by downloading the MySQL Community Server .dmg file from the [MySQL Community Server page](https://dev.mysql.com/downloads/file/?id=484914). Click the download icon. Use the No thanks, just start my download link.

Next, follow along with the Installer until you reach the Configuration page. Once you've reached Configuration, select or set the following options (use default if not specified):

1) Use Legacy Password Encryption.

2) Set password to something you will remember.

3) Click Finish.

4) Open the terminal and enter the command echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile. This will save this path in .bash_profile, which is where our terminal is configured.

5) Type in source ~/.bash_profile (or restart the terminal) in order to actually verify that MySQL was installed.

Next, verify MySQL installation by opening terminal and entering the command mysql -uroot -pepicodus. You'll know it's working and connected if you gain access and see the MySQL command line. If it's not working, you'll likely get a -bash: mysql: command not found error.

You can exit the mysql program by entering exit.

Next, download the MySQL Workbench .dmg file from the MySQL Workbench page. (Use the No thanks, just start my download link.)

Install MySQL Workbench to Applications folder.

Then open MySQL Workbench and select the Local instance 3306 server. You will need to enter the password you set. (We used epicodus.) If it connects, you're all set.


### **Install/Setup Project** ###

**Option 1** (download zip file)
1) Copy and paste the following GitHub project link into your web browser's url bar and hit enter/return. https://github.com/RMGit-it/SweetAndSavory.Solution.git
2) Download a .zip copy the repository by clicking on the large green "Code" button near the upper right corner of the screen.
3) Right click the .zip file and extract(unzip) it's contents.
4) Open your computer's terminal/console, and navigate to folder called "__SweetAndSavory.Solution__". 


**Option 2** (via git console/terminal)
1) Open your Git enabled terminal/console and navigate to a directory that you wish to download this project to.
2) Type the following line of code into your terminal/console to automatically download the project to your current direcory and hit return/enter

    <code>git clone https://github.com/RMGit-it/SweetAndSavory.Solution.git</code>

3) Once the project has finished downloading, use the terminal/console to navigate to the "__SweetAndSavory.Solution__" folder of the project.


**Setup Database Connection**

Create a new file in the root directory of the _SweetAndSavory.Solution/SweetAndSavory__ directory named "appsettings.json".  Copy and past the following code inside of the file.

```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=randel_moore_sweetandsavory;uid=YourId;pwd=YourPassword;"
  }
}
```
Replace "YourId" and "YourPassword" in the code above with the user id and user password you use for logging into MySQL Workbench.  Save the "appsettings.json" file.

Type the following code and hit enter/return to install the necessary dependencies. 

<code>dotnet restore</code>

Once the dependencies have installed, type the following commands into your console, hitting enter/return after each.

<code>dotnet ef migrations add Initial</code>

<code>dotnet ef database update</code>


You can now type the follow code to launch the program...

<code>dotnet run</code>

The program should launch using your default web browser at URL: localhost:5000.

## **SQL Schema Diagram**
<img src="./readme_assests/factory_schema_diagram.PNG" alt="Factor Schema" style="float: left" />

## **SQL Schema**

```
CREATE DATABASE  IF NOT EXISTS `randel_moore_factory`;
USE `randel_moore_factory`;

DROP TABLE IF EXISTS `__efmigrationshistory`;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `__efmigrationshistory` WRITE;
INSERT INTO `__efmigrationshistory` VALUES ('20210108173230_Initial','2.2.4-servicing-10062'),('20210108180809_Add_Machine_Istall_Date','2.2.4-servicing-10062'),('20210110203536_DateTimeToStringTest','2.2.4-servicing-10062'),('20210110204421_StringToDateTimeReset','2.2.4-servicing-10062');
UNLOCK TABLES;

DROP TABLE IF EXISTS `engineermachine`;
CREATE TABLE `engineermachine` (
  `EngineerMachineId` int NOT NULL AUTO_INCREMENT,
  `EngineerId` int NOT NULL,
  `MachineId` int NOT NULL,
  PRIMARY KEY (`EngineerMachineId`),
  KEY `IX_EngineerMachine_EngineerId` (`EngineerId`),
  KEY `IX_EngineerMachine_MachineId` (`MachineId`),
  CONSTRAINT `FK_EngineerMachine_Engineers_EngineerId` FOREIGN KEY (`EngineerId`) REFERENCES `engineers` (`EngineerId`) ON DELETE CASCADE,
  CONSTRAINT `FK_EngineerMachine_Machines_MachineId` FOREIGN KEY (`MachineId`) REFERENCES `machines` (`MachineId`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `engineermachine` WRITE;
INSERT INTO `engineermachine` VALUES (51,13,10),(52,13,11),(53,5,8),(54,5,9),(55,5,10),(56,5,11),(57,5,12),(58,6,10),(61,9,12),(62,9,8),(63,10,9),(64,10,11),(65,13,12),(66,14,9),(67,14,11);
UNLOCK TABLES;

DROP TABLE IF EXISTS `engineers`;
CREATE TABLE `engineers` (
  `EngineerId` int NOT NULL AUTO_INCREMENT,
  `StartDate` datetime(6) NOT NULL,
  `EngineerName` longtext,
  PRIMARY KEY (`EngineerId`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `engineers` WRITE;
INSERT INTO `engineers` VALUES (5,'2021-01-08 00:00:00.000000','Kiki Smith'),(6,'2020-11-20 00:00:00.000000','Jackson Pollock'),(9,'2020-06-10 00:00:00.000000','Bob Ross'),(10,'2021-01-02 00:00:00.000000','Yayoi Kusama'),(13,'2020-07-19 00:00:00.000000','Marilyn Minter'),(14,'2020-06-20 00:00:00.000000','Rick Bartow');
UNLOCK TABLES;

DROP TABLE IF EXISTS `machines`;
CREATE TABLE `machines` (
  `MachineId` int NOT NULL AUTO_INCREMENT,
  `MachineName` longtext,
  `InstallDate` datetime(6) NOT NULL,
  PRIMARY KEY (`MachineId`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `machines` WRITE;
INSERT INTO `machines` VALUES (8,'The Fluff-If-Fier','2020-11-01 00:00:00.000000'),(9,'The Inspect-O-Matic','2020-09-24 00:00:00.000000'),(10,'The Dimpler','2021-01-01 00:00:00.000000'),(11,'The Shineification Machine','2020-12-19 00:00:00.000000'),(12,'Hal 9000','2001-01-01 00:00:00.000000');
UNLOCK TABLES;
```
## **Usage / Examples**

## **Planned Features**
No new features are planned at this time.

## **Known Bugs**
There are no known bugs

## **Technology Used**
* C# 7.3
* .NET Core 2.2
* Entity
* Git
* MySQL
* CSS
* HMTL
* Bootstrap
* Razor
* dotnet script, REPL
  
## **Authors and Contributors**
Authored by: Randel Moore

## **Contact**
Randel Moore
RMGit.it@gmail.com

## **License**

GPLv3

Copyright © 2020 Randel Moore

