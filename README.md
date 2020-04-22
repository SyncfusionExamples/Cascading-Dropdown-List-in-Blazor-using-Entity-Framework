# Cascading-Dropdown-List-in-Blazor-using-Entity-Framework
Cascading Dropdown List in Blazor using Entity Framework, The cascading Dropdown List is a series of Dropdown List, where the value of one Dropdown List depends upon another’s value.

## Project pre-requisites
Make sure that you have the compatible versions of Visual Studio Code and .NET Core SDK 3.1.2 in your machine before starting to work on this project.

## How to run this application?
To run this application, you need to first clone the `getting-started-with-blazor-dropdown-list` repository and then open it in Visual Studio Code. 

* Need to change the Database connection string in Shared/DataAccess/DataContext.cs

```
optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DropDownList\EFDropDown\Shared\App_Data\NORTHWND.MDF;Integrated Security=True;Connect Timeout=30");

```

* Now, open the `Integrated Terminal` in VS Code and run the following command to build and run this project.

```
dotnet watch run
```

Navigate to `http://localhost:5000/` or `http://localhost:5001/` in the browser to view the output.
