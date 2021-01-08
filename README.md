# _Dr.SillyStringz Factory_

#### _An app to keep track of the Doctor's Engineers and Machines. Created 1/8/2021_

#### Created By _**Garrett Dean Brown**_

## Description

A website specially made for the infamous Dr.SillyStringz to keep track of his engineers as well as his machines in order to maximize efficiency as well as organization.

## User Stories:

* As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines.

* As the factory manager, I need to be able to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it.

* As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed.

* As the factory manager, I should be able to add new machines even if no engineers are employed. I should also be able to add new engineers even if no machines are installed

* As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine.

* I should be able to navigate to a splash page that lists all engineers and machines. Users should be able to click on an individual engineer or machine to see all the engineers/machines that belong to it.


## Machine Object Properties
* Id
* Name
* Status
* Assigned Engineer
--------

## Engineer Object Properties
* Id
* Name
* Status
* Licensed Machine

* Cloning options
  * For cloning please use the following GitHub [tutorial](https://docs.github.com/en/enterprise/2.16/user/github/creating-cloning-and-archiving-repositories/cloning-a-repository)
  * Place files into a single directory 
  * Run GitBASH in directory
  * Type "dotnet run" in GitBash to run the program

## Setup/Installation Requirements

* Database setup instructions:
  * Ensure Garrett_Brown.sql was downloaded
  * Create an appsettings.json file
  * add localhost port, database name (garrett_brown) and your mysql password. 
  * navigate to Factory directory.
  * Run dotnet ef database update.
  * Enjoy, Doctor S!

* Download option
  * Download files from GitHub repository by click Code and Download Zip
  * Extract files into a single directory 
  * Run GitBASH in directory
  * Navigate to Factory directory.
  * Type "dotnet ef database update" in dotnet to run the program
  * Enjoy, Doctor S!


## Known Bugs

_No known bugs!_

## Support and contact details

_Feel free to email me with any questions, comments, or reports!: gman9mm@live.com_

## Technologies Used

* C#
* cshtml
* CSS
* MySQL
* Entity
* Linq
* MVCTest
* MarkDown

### License

_Copyright (c) 2020 **_{Garrett Brown}_**
_Licensed under MIT_

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.