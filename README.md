# _Cafe Vendors_

#### _C# ASP.NET Core MVC practice for Epicodus, 07.24.2020_

#### By _**Brittany Lindgren**_


## Description

_Keep track of your Vendors with this easy to use organizer. Add new Vendors and view a list of those you work with regularly to make your job easier and your business more organized _


## Specifications

| Behavior   |   Input   |  Output |  Met? (Y/N)  |
|----------|:-------------:|------:|-----------:|
| Program should create instances of Vendor class with Name, Description and Orders List properties and Id | Vendor ritasShop = new Vendor() {"Rita's Flowers", "A flower shop that sells pastries", {Order 1, Order 2, Order 3}} | ritasShop {Name: "Rita's Flowers", Description: "A flower shop that sells pastries", Orders List: {Order 1, Order 2, Order 3}, Id: 1} | Y |  
| Program should add each new Vendor to a list and return the list of Vendors | Vendor ritasShop = new Vendor() {}, Vendor katesShop = new Vendor() {} | Vendors List = ritasShop, katesShop ,... | Y |
| Program will find a Vendor by Id | 2 | Vendor: katesShop | Y |
| Program will clear list of all Vendors | Delete | All Vendors deleted | Y |
| Program should create and instance of Order class with Title, Description, Price, Date and Id | Order ritasWeeklyOrder = new Order() {"Croissants", "A weekly order of 15 croissants for Rita's flower shop", 20, "Weekly"} | ritasWeeklyOrder = {Title: "Croissants", Description: "A weekly order of 15 croissants for Rita's flower shop", Price: 20, Date: "Weekly", Id: 1} | Y |
| Program should add each new Order to a list associated with a Vendor and return the list | Order ritasCroissants = new Order() {}, Order ritasMuffins = new Order() {} | Rita's Orders List = ritasCroissants, ritasMuffins ,... | Y |

| Program will find a Vendor by Id | 2 | Vendor: katesShop | N |

| Program will clear list of all Vendors | Delete | All Vendors deleted | N |


|  |  |  |  |
|  |  |  |  |
|  |  |  |  |


## Stretch Goals
| Behavior   |   Input   |  Output |  Met? (Y/N)  |
|----------|:-------------:|------:|-----------:|
| Program will delete an Order by Id | 2 | "Kate's Blackberry Tarts order has been deleted" | N |

| Program will delete a Vendor by Id | 2 | "Kate's shop has been deleted." | N |
|  |  |  |  |


## Setup/Installation Requirements

  1. Follow this [link to the project repository](PUT A GITHUB LINK HERE) on GitHub.  
  2. Click on the "Clone or download" button to copy the project link.     
  3. If you are comfortable with the command line, you can copy the project link and clone it through your command line with the command `git clone`. Otherwise, I recommend choosing "**Download ZIP**".     
   4. Once the ZIP file has finished downloading, you can right click on the file to view the zip folder in your downloads.     
  5. Right click on the project ZIP folder that you have just downloaded and choose the option "**Copy To...**", then choose the location where you would like to save this folder.      
  6. Navigate to the final location where you have chosen to save the project folder.      
  7. To view the code itself, right click, choose **open with...** and open using a text editor such as VS Code or Atom, etc.
  8. Once you are inside of your text editor, open the terminal. If you are in VS Code for example, this can be done by clicking on `Terminal` at the top of the editor and then selecting `New Terminal`. **You can navigate to different directories in the project by typing `cd DirectoryName` to go down into specific directories or `cd ..` to go back up one directory. 
  9. Navigate to the Vendors directory by typing `cd Places` in your terminal and hitting `enter`. Then type the command `dotnet restore`,`dotnet build`, then `dotnet run` into your terminal and hit enter. You should see files appear inside of your bin folder. The bin folder should appear greyed out. 
  10. Click on the link provided after you see `now listening on: ... ` appear in your terminal.


#### Additional Setup/Installation Notes:

* No additional code is necessary to view this project.   
* Do not alter the bin/ or obj/ directories or any of the files in them.

## Known Bugs

| Bug : Message |  Resolved (Y/N) |  How was the issue resolved?  |
| ------- | ----- | ------ | 
| Cannot create an instance of the variable type 'Order' because it does not have the new() constraint [CafeVendors.Tests] | Y |  Correct name of test from `GetList_GetsListOfOrders_List<Order>()` to `GetList_GetsListOfOrders_OrderList()` |


## Support and contact details

_Please feel free to contact the authors through GitHub (LINDGRENBA) with any feedback, questions or concerns._


## Technologies Used

* C# 
* .NET-Core 2.2
* ASP.NET Core MVC
* Visual Studio Code
* Git Version Control 
* GitHub


### License

*This site is licensed under the MIT license.*

Copyright (c) 2020 **_{Brittany Lindgren}_**