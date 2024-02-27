## Project Guide
It is a Dating App.

# Following steps are followed to create the app
1. Create a project repo
`mkdir DatingApp`

2. Add a solution file to the project
`dotnet new sln`

3. Create a dotnet project
`dotnet new webapi -o API`

4. Add the project to the solution
`dotnet sln add API`

5. Add Microsoft.EntityFrameworkCore.Sqlite &  Microsoft.EntityFrameworkCore.Design packages to the project
`dotnet add package Microsoft.EntityFrameworkCore.Sqlite`
`dotnet add package Microsoft.EntityFrameworkCore.Design`

6. Add Initial Migrations for creating the database tables:
`dotnet ef migrations add InitialCreate --context AppDbContext`

7. Run the following command to apply the InitialCreate migration:
`dotnet ef database update --context AppDbContext`