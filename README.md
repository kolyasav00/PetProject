# Task management
It's web application for managing the tasks the team is working on and what projects they are working on.
____
## What application does.
1. Application have forms personal account settings if you registe, registration and loging.
2. Application have database with 3 lists and 3 pages: Emplayees, Tasks, Projects.
   + 2.1 On the page "Projects" forms: "Add new project", "Edit project", "Delete project" and list "Projects". List have table with fields: name, description. All filds have type string.
   + 2.2 On the page "Tasks" forms: "Add new task", "Edit task", "Delete task" and list "Tasks". List have table with fields: Status, Name, Project name, Work, DateStart, DateEnd, Performer. Filds: Status,Name, Project Name, Work, Performer have type string, DateStart, DateEnd have type Date.
   + 2.3 On the page "Employees" forms: "Add new employee", "Edit employee", "Delete employee" and list "Employees". List have table with fields: Last Name, First name, Surname, Job Titel. Filds: Last Name, First name, Sure name, Job Titel have type string.
____
## Database description
### Tabel "Projects"(example).
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
//TODO 
## How to Install and Run the Project
### If you have Visual Studio
1. Open VS
2. Click field "Clone a repository".
3. Open browser and past link: https://github.com/kolyasav00/PetProject
4. Click the green button "Code".
5. Copy HTTPS link.
6. Go to VS and past in field "Repository location" link and click button clone.
7. Wait and after application load click green triangle button "Pet Project".

