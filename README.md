# Task management
It's web application for managing the tasks the team is working on and what projects they are working on.
____
## What application does.
1. Application have forms personal account settings if you register, registration and lodging.
2. Application have database with 3 lists and 3 pages: Employees, Tasks, Projects.
   + 2.1 On the page "Projects" forms: "Add new project", "Edit project", "Delete project" and list "Projects". List have table with fields: name, description. All fields have type string.
   + 2.2 On the page "Tasks" forms: "Add new task", "Edit task", "Delete task" and list "Tasks". List have table with fields: Status, Name, Project name, Work, DateStart, DateEnd, Performer. Fields: Status,Name, Project Name, Work, Performer have type string, DateStart, DateEnd have type Date.
   + 2.3 On the page "Employees" forms: "Add new employee", "Edit employee", "Delete employee" and list "Employees". List have table with fields: Last Name, First name, Surname, Job Titel. Fields: Last Name, First name, Sure name, Job Titel have type string.
____
## Database description
### Table "Projects"(example).
| Name | Description |
|----------------|:---------:|
| Task management | It's web application for managing the tasks the team is working on and what projects they are working on.|
### Table "Tasks"(example).
| Status | Name | Project name | Work | DateStart | DateEnd | Performer |
|----------------|:---------:|----------------:|----------------|:---------:|----------------:|----------------:|
| In progress | Write file "README.md" | Task management | 5 hours | 06.12.24 | 27.12.24 | Savitski N.S. |
### Table "Employees"(example).
| Last Name | First Name | SurName | Job Title |
|----------------|:---------:|----------------:|----------------:|
| Savitski | Nikolai | Sergeevich | .Net developer |
____
## How to Install and Run the Project
### If you have Visual Studio
1. Open VS
2. Click field "Clone a repository".
3. Open browser and past link: https://github.com/kolyasav00/PetProject
4. Click the green button "Code".
5. Copy HTTPS link.
6. Go to VS and past in field "Repository location" link and click button clone.
7. Wait and after application load click green triangle button "Pet Project".

### If you dont have Visual Studio
1. Download rep project.
2. Open file in folder project ...\PetProject\PetProject\bin\Debug\net6.0\PetProject.exe
3. In browser open page: https://localhost:7262/swagger/index.html
____
## How to Use the Project
Project have 4 fields: "TableEmployees", "TabelProjects", "TableTasks" and "Schemas".

### Field TableEmployees have lines:
1. Get - find all tasks in table.
2. Post - add new task in table.
3. Get(id) - find task in table by ID.
4. Put - Update task in table by ID.
5. Delete - Delete task in table by ID.

#### Get
Have 2 fields: 
1. Parameters - no parameters in this type of HTTP Request and have only button "try it out".
   1.1. If you click button "Try it out" will appear 2 buttons: Execute(appear all table), Clear(clear field "Responses").
2. Responses - show codes response.
   2.1. If you click button "Try it out" and next "Execute" will appear fields: curl, request url and server response.
   2.2. Server response have 2 columns: code and details. Column "code" show code response; column "Details" have field response body and response headers.

#### Post
Have 2 fields: 
1. Parameters - no parameters in this type of HTTP Request, have "Request body", "Example value" and button "Try it out".
   1.1. If you click button "Try it out" will appear 2 buttons: Execute(appear all table), after click "Execute" appeared button "Clear"(clear field "Responses"), field where need enter data. 
2. Responses - show codes response.
   2.1. If you click button "Try it out", enter data and click "Execute" will appear fields: curl, request url and server response.
   2.2. Server response have 2 columns: code and details. Column "code" show code response; column "Details" have response headers.

#### Get(id)
Have 2 fields: 
1. Parameters - columns "Name" and "Description" and have button "try it out".
   1.1. Column "Name" have name searching field(id).
   1.2. Column "Description" have field where need enter searching field by id. 
   1.3. If you click button "Try it out" will appear 2 buttons: Execute(appear all table), Clear(clear field "Responses").
3. Responses - show codes response.
   2.1. If you click button "Try it out" and next "Execute" will appear fields: curl, request url and server response.
   2.2. Server response have 2 columns: code and details. Column "code" show code response; column "Details" have field response body and response headers.
   
#### Put(id)
Have 2 fields: 
1. Parameters - columns "Name" and "Description" and have button "try it out".
   1.1. Column "Name" have name searching field(id).
   1.2. Column "Description" have field where need enter searching field by id. 
   1.3. If you click button "Try it out" will appear 2 buttons: Execute(appear all table), Clear(clear field "Responses") and field where need enter editing data.
2. Responses - show codes response.
   2.1. If you click button "Try it out", enter data, enter id and click "Execute" will appear fields: curl, request url and server response.
   2.2. Server response have 2 columns: code and details. Column "code" show code response; column "Details" have response headers.
   
#### Delete(id)
Have 2 fields: 
1. Parameters - columns "Name" and "Description" and have button "try it out".
   1.1. Column "Name" have name searching field(id).
   1.2. Column "Description" have field where need enter deleting data by id
   1.3. If you click button "Try it out" will appear 2 buttons: Execute(appear all table), Clear(clear field "Responses").
3. Responses - show codes response.
   2.1. If you click button "Try it out", enter id and next "Execute" will appear fields: curl, request url and server response.
   2.2. Server response have 2 columns: code and details. Column "code" show code response; column "Details" have field response headers.
   
### Field TableProject have lines:
1. Get - find all projects in table.
2. Post - add new project in table.
3. Get(id) - find project in table by ID.
4. Put - Update task in table by ID.
5. Delete - Delete task in table by ID.

#### Get
Have 2 fields: 
1. Parameters - no parameters in this type of HTTP Request and have only button "try it out".
   1.1. If you click button "Try it out" will appear 2 buttons: Execute(appear all table), Clear(clear field "Responses").
2. Responses - show codes response.
   2.1. If you click button "Try it out" and next "Execute" will appear fields: curl, request url and server response.
   2.2. Server response have 2 columns: code and details. Column "code" show code response; column "Details" have field response body and response headers.

#### Post
Have 2 fields: 
1. Parameters - no parameters in this type of HTTP Request, have "Request body", "Example value" and button "Try it out".
   1.1. If you click button "Try it out" will appear 2 buttons: Execute(appear all table), after click "Execute" appeared button "Clear"(clear field "Responses"), field where need enter data. 
2. Responses - show codes response.
   2.1. If you click button "Try it out", enter data and click "Execute" will appear fields: curl, request url and server response.
   2.2. Server response have 2 columns: code and details. Column "code" show code response; column "Details" have response headers.

#### Get(id)
Have 2 fields: 
1. Parameters - columns "Name" and "Description" and have button "try it out".
   1.1. Column "Name" have name searching field(id).
   1.2. Column "Description" have field where need enter searching field by id. 
   1.3. If you click button "Try it out" will appear 2 buttons: Execute(appear all table), Clear(clear field "Responses").
3. Responses - show codes response.
   2.1. If you click button "Try it out" and next "Execute" will appear fields: curl, request url and server response.
   2.2. Server response have 2 columns: code and details. Column "code" show code response; column "Details" have field response body and response headers.
   
#### Put(id)
Have 2 fields: 
1. Parameters - columns "Name" and "Description" and have button "try it out".
   1.1. Column "Name" have name searching field(id).
   1.2. Column "Description" have field where need enter searching field by id. 
   1.3. If you click button "Try it out" will appear 2 buttons: Execute(appear all table), Clear(clear field "Responses") and field where need enter editing data.
2. Responses - show codes response.
   2.1. If you click button "Try it out", enter data, enter id and click "Execute" will appear fields: curl, request url and server response.
   2.2. Server response have 2 columns: code and details. Column "code" show code response; column "Details" have response headers.
   
#### Delete(id)
Have 2 fields: 
1. Parameters - columns "Name" and "Description" and have button "try it out".
   1.1. Column "Name" have name searching field(id).
   1.2. Column "Description" have field where need enter deleting data by id
   1.3. If you click button "Try it out" will appear 2 buttons: Execute(appear all table), Clear(clear field "Responses").
3. Responses - show codes response.
   2.1. If you click button "Try it out", enter id and next "Execute" will appear fields: curl, request url and server response.
   2.2. Server response have 2 columns: code and details. Column "code" show code response; column "Details" have field response headers.
   
### Field TableTasks have lines:
1. Get - find all tasks in table.
2. Post - add new task in table.
3. Get(id) - find task in table by ID.
4. Put - Update task in table by ID.
5. Delete - Delete task in table by ID.

#### Get
Have 2 fields: 
1. Parameters - no parameters in this type of HTTP Request and have only button "try it out".
   1.1. If you click button "Try it out" will appear 2 buttons: Execute(appear all table), Clear(clear field "Responses").
2. Responses - show codes response.
   2.1. If you click button "Try it out" and next "Execute" will appear fields: curl, request url and server response.
   2.2. Server response have 2 columns: code and details. Column "code" show code response; column "Details" have field response body and response headers.

#### Post
Have 2 fields: 
1. Parameters - no parameters in this type of HTTP Request, have "Request body", "Example value" and button "Try it out".
   1.1. If you click button "Try it out" will appear 2 buttons: Execute(appear all table), after click "Execute" appear button "Clear"(clear field "Responses"), field where need enter data. 
2. Responses - show codes response.
   2.1. If you click button "Try it out", enter data and click "Execute" will appear fields: curl, request url and server response.
   2.2. Server response have 2 columns: code and details. Column "code" show code response; column "Details" have response headers.

#### Get(id)
Have 2 fields: 
1. Parameters - columns "Name" and "Description" and have button "try it out".
   1.1. Column "Name" have name searching field(id).
   1.2. Column "Description" have field where need enter searching field by id. 
   1.3. If you click button "Try it out" will appear 2 buttons: Execute(appear all table), Clear(clear field "Responses").
3. Responses - show codes response.
   2.1. If you click button "Try it out" and next "Execute" will appear fields: curl, request url and server response.
   2.2. Server response have 2 columns: code and details. Column "code" show code response; column "Details" have field response body and response headers.
   
#### Put(id)
Have 2 fields: 
1. Parameters - columns "Name" and "Description" and have button "try it out".
   1.1. Column "Name" have name searching field(id).
   1.2. Column "Description" have field where need enter searching field by id. 
   1.3. If you click button "Try it out" will appear 2 buttons: Execute(appear all table), Clear(clear field "Responses") and field where need enter editing data.
2. Responses - show codes response.
   2.1. If you click button "Try it out", enter data, enter id and click "Execute" will appear fields: curl, request url and server response.
   2.2. Server response have 2 columns: code and details. Column "code" show code response; column "Details" have response headers.
   
#### Delete(id)
Have 2 fields: 
1. Parameters - columns "Name" and "Description" and have button "try it out".
   1.1. Column "Name" have name searching field(id).
   1.2. Column "Description" have field where need enter deleting data by id
   1.3. If you click button "Try it out" will appear 2 buttons: Execute(appear all table), Clear(clear field "Responses").
3. Responses - show codes response.
   2.1. If you click button "Try it out", enter id and next "Execute" will appear fields: curl, request url and server response.
   2.2. Server response have 2 columns: code and details. Column "code" show code response; column "Details" have field response headers.

   
### Field "Schemas" have lines: 
1. TableEmployees
2. TableProject
3. TableTasks

All schemas have same fields - entered types data in lines.
