# _Bakery_

#### By _**Tim Empey**_

#### _Pierres Treats_

## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _CSS_
* _MySQL_
* _Entity_
* _Identity_

## Description

_Website designed for users to create pastries, and flavors and make connections between the two which can be manipulated. There is also functionality to edit, and delete flavors and treats. This is all locked behind an authorization wall which can only be accessed through authorization._

## Setup/Installation Requirements

* _Open up your terminal and navigate to the desired landing folder_
* _In terminal enter, ' "git clone https://github.com/TimEmpey/Treats-Flavors '_
* _In terminal enter 'code .' to open files in Visual Studio Code_
* _In VS Code terminal navigate to the Bakery directory (file path ex. user/desktop/epicodus/projects/pierre-treats.Solutions/Bakery)_
* _Configure files with:_
```json
$ dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0 
$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
```
* _Install Lazy Loading:_
```json
$ dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
```
* _Create file named 'appsettings.json'_
* _Enter the following into the file_
```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=bakery;uid=root;pwd=YOUR_PASSWORD;"
  }
}
```
* _To setup the database you open up MySQL and under 'Administration' select 'Data Import'_
* _Check the 'Import from self contained file' option and enter the file path of the Database within Factory, then start Import_
* _Start live site with:_
```json
$ dotnet run to start program
```

## Known Bugs

* _None_

## License

_[MIT](https://en.wikipedia.org/wiki/MIT_License)_

Copyright (c) _2022_ _Timothy Empey_