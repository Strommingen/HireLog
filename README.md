## Database connection
Create a file named .env in the root directory of the project. Add your connection string to it;
```ConnectionString__DB="ADD_YOUR_CONNECTION_STRING```

Install EF Core tools by running the following command;
```dotnet tool install --global dotnet-ef```

In the project directory, run;
```dotnet ef migrations add InitialCreate```
This will create a folder called *Migrations* with code for building your database schema.

Run;
```dotnet ef database update```
This will apply the migration to your database and create the tables.
