# Cascading-Dropdown-List-in-Blazor-using-Entity-Framework
Cascading Dropdown List in Blazor using Entity Framework, The cascading Dropdown List is a series of Dropdown List, where the value of one Dropdown List depends upon another’s value.

## Project pre-requisites
Make sure that you have the compatible versions of Visual Studio Code and .NET Core SDK 3.1.2 in your machine before starting to work on this project.

## How to run this application?
To run this application, you need to first clone the `Cascading-Dropdown-List-in-Blazor-using-Entity-Framework` repository and then open the project or solution file in Visual Studio 2019. 

* Need to change the Database connection string in Shared/DataAccess/DataContext.cs

```
optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DropDownList\EFDropDown\Shared\App_Data\NORTHWND.MDF;Integrated Security=True;Connect Timeout=30");

```

* Now, run the run the project Visual Studio and able to get the output in Browser.

