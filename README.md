# _PIERRE'S BAKERY_

#### _First Project for C# unit of Epicodus, 02.28.2020_

#### By _**Drake Wilcox**_

## Description

_This project is an exercise in the using custom classes, namespaces, and auto-implementation in C#. The goal of this project was to emulate a take-home technical challenge where we were required to build a C# console application for a bakery._

## Setup/Installation Requirements

To use this application, follow the following instructions. 

#### Installing .NET core

##### For macOS: 

* Dowload [this .NET Core SDK](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) which will prompt a .pkg file download from Microsoft.

* Open the file. This will launch and walk you through installation steps. Use default settings. 

* Confirm the installation is successful by opening the terminal and running the command ``$ dotnet --version``. You should see something like ``2.2.105`` in response.

##### For Windows: 
* Visit the [Microsoft .NET Installation Guide](https://docs.microsoft.com/en-us/dotnet/framework/install/).

#### Installing donet script

* After installing .NET Core, run the command `` dotnet tool install -g dotnet-script `` in Terminal. 

#### Application Setup:
_Clone this repository via Terminal using the following commands:_
* ``$ cd desktop``
* ``$ git clone "repository link" ``
* ``$ cd bakery-project``

_To Run this Console Application, enter the following command in the Terminal:_

* ``$ dotnet run``

_To view the source code of this application, open the folder in the Text Editor of your choice. (Example: to open via Visual Code enter the command ``code . `` in Terminal.)_


## Specifications

| Specification | Input | Output |
|:--------------|:------|:-------|
| When user starts the application a menu with prices is returned | "Enter" | Bakery Menu|
| User has the ability to choose if they would like to order Pastry or Bread | Pastry | "What type of Pastry would you like to order?"
| When the user chooses type of bread or pastry, a second question that includes that type is returned | Country Bread | "How many of the Country Bread would you like to order?" |
| When the user inputs the amount of bread in the order the number and final price is returned | Amount: 2 | $10.00 |
| When the order amoount is 3, the price is returned as a "2 for 1" discount | Amount: 3 | $10.00 |
| The returned price still accounts for the 2 for 1 discount when the order number is more than 3 loaves | Amount: 4 | $15.00 |
| For Pastries, when the order amount is 3, the "Buy 2 get one 1/2 off" discount is applied | 3 ($2 Pastries) | $5.00 |
| For Pastries, when the order amount is more than 3, the pastry discount is still accounted for | 4 | $7.00 | 

## Known Bugs
No known bugs at this time. 

## Technologies Used

* C#
* .NET Core 2.2
* Git
* VS Code

### License

*This webpage is licesnsed under the MIT license.*

Copyright (c) 2020 **_Drake Wilcox_**