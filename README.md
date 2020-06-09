 **Our First API**

#### Author: **_Steven Ly, Matt Stroud, and Brevin Cronk_**
#### June 8, 2020


### Description

_The purpose of this application was to practice and demonstarate out understanding of many to many relationships in databases, as well as constructing our own API using our database._

### Instructions for use:

1. Open Terminal (macOS) or PowerShell (Windows)
2. To download the project directory to your desktop enter the following commands:
```
cd Desktop
git clone https://github.com/BrevinCronk98/C-Sharp-APIs
cd C-Sharp-APIs (or the file name you created for the main directory of the download)
```
3. To view the downloaded files, open them in a text editor or IDE of your choice.
* if you have VSCode for example, when your terminal is within the main project directory you can open all of the files with the command:
```
code .
```
4. Create a file within the C-Sharp-APIs folder named appsettings.json.
5. Add the following code:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=travel_api;uid=root;pwd=YOURMYSQLPASSWORDHERE;"
  }
}
```
* Make any other changes needed if you have an alternative server, port, or uid selected. These are the default settings.

5. If you need to install the REPL dotnet script enter the following command in your terminal: 
```
dotnet tool install -g dotnet-script
```
6. To install the necessary dependencies and start a local host, after replicating the database steps below run the following commands:
```
dotnet restore
dotnet build
dotnet run
```

#### If you need to install and configure MySQL:
1. Download the MySQL Community Server DMG file [here](https://dev.mysql.com/downloads/file/?id=484914) with the "No thanks, just start my download" link.
2. On the configuration page of the installer select the following options:
* Use legacy password encryption
* Set your password
3. Open the terminal and enter the command:
*'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile
4. Download the MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391)
5. Open Local Instance 3306 with the password you set.

#### To create a local version of the database:
1. Open MySQL Workbench and Local Instance 3306.
2. Select the SQL + button in the top left of the navigation bar.
3. Paste the following in the query section to create the database:

```
CREATE DATABASE `travel_api`;

USE `travel_api`;

CREATE TABLE `locations` (
  `LocationId` int(11) NOT NULL AUTO_INCREMENT,
  `Rating` int(11) DEFAULT '0',
  `Review` varchar(255) DEFAULT NULL,
  `Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`LocationId`)
);

CREATE TABLE `users` (
  `UserId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`UserId`)
);

```

4. Press the lightning bolt button to run this command.
5. If the database does not appear, right click in the schemas bar and select Refresh All.

### Known Bugs

No bugs have been identified at the time of this update.

### Support and Contact Information

Please contact me with any suggestions or questions at cronkbrevin98@gmail.com.s Thank you for your input!  
_Have a bug or an issue with this application? [Open a new issue](https://github.com/BrevinCronk98/C-Sharp-APIs/issues) here on GitHub._

### Technologies Used

* C#
* `ASP.NET` Core
* `ASP.NET` Core MVC
* Entity Framework Core
* `ASP.NET` Core Identity
* MySQL
* Git and GitHub



<!-- &#9745; -->

### Resources

#### License

This software is licensed under the MIT license.

Copyright © 2020 **_Matt Stroud, Steven Ly, and Brevin Cronk_**
