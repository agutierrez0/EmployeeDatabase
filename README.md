# by Angel Gutierrez (Templum Inc)


This program's purpose is to build a database of Employees.

The employees can have the following attributes:
- ID (int)
- firstName (str)
- lastName (str)
- age (int)
- phoneNumber (str)
- over21 (char)


This program was optimized using Postman.
Get postman at www.getpostman.com


# Directions :
## Adding/Creating an employee
To add an employee, one must POST that employee's attributes.
Address: localhost:<port>/api/employees
Parameters for posting:


	"firstName" : [STRING],
  
	"lastName": [STRING],
  
	"age" : [INT],
  
	"phoneNumber": [STRING],
  
	"position" : [STRING],
  
	"over21": [CHAR]
  

Every new employee will increment the ID# once. You CAN NOT do it manually.
After adding the employee to the database, please refer to "Viewing all employees".


## Viewing all employees
  To view all employees, simply select GET and send. OR simply type in "localhost:<port>/api/employees" into your address bar
  Address: localhost:<port>/api/employees
  
  *NOTE - The first employee will have null as most of it's values, 1 as it's ID and Item as it's firstName. This can be changed using    PUT. Please refer to "Editting an existing employee". 
  
## Viewing a specific employee
  To View a specific employee, adjust the URL to be "localhost:<port>/api/employees/[DESIRED EMPLOYEE ID#]"
  
  This can also be done with postman or just on your browser.
  (IN PROGRESS: View a specific employee using other parameters, eg: firstName, lastName, position, etc..)
  
## Updating an Employee
  To update an employee, it must be done through Postman.
 
 FIRST: the URL must be in this format: localhost:<port>/api/employees/<DESIRED EMPLOYEE ID#>
        After this has been done you will have to specify the Employee's ID in the parameters. 
  
  The parameters should look like this:

	"id" : [INT],
  
	"firstName" : [STRING],
  
	"lastName": [STRING],
  
	"age" : [INT],
  
	"phoneNumber": [STRING],
  
	"position" : [STRING],
  
	"over21": [CHAR]
  

After the ID has been specific and the URL has been specified, all the other parameters can be changed to whatever the user wishes.
