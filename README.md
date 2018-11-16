# ColonyGaming Angular Web API
##Application
Application using ASP.NET Core Web API, Angular 6.0, Angular Material UI 6 and Visual Studio Code. 

### Prerequisite 
.Net Core 2.0.3<br />
NodeJS 8.11.0 <br />
npm 5.6.0 <br />
Angular CLI 6.0 <br />

### install npm packages and restore dotnet nuget pakages in command promt:
npm install <br />
dotnet restore  

### Update Connectionstring in Appsettings.json file
 "ConnectionStrings": {
    "ContactDb": "Data Source=LOCALNAME\\SQLEXPRESS;Initial Catalog=ContactDb;Integrated Security=True"
	}

### Update Database
dotnet ef database update

### build angular component
ng build

### run project
dotnet run
