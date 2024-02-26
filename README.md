ASP.NET MVC CORE
----------------
1.what is ASP.NET MVC Core?
A.Its a open source.cross platform web development framework to develop web application
 created by Microsoft.
 there if we created in web application in ASP.NET Core it will work in windows linux mac

2. difference between Webforms(2003) vs ASP.NET MVC5(2009) vs ASP.NET MVC Core(2017)
A.Cross platform --    No                       No                      Yes
  performance    --    worst               less than core        Best of all versions
  Simplification --    Quite Complicated       medium               Very Simplified
  Cloud redy     --    Not meant for cloud  not complete                yes
  HTML control   --    very less            Godd due to razor views  good due to razor views
  
3.Explain MVC Architecture ?
A.MVC stands for Model View Controller
    In This Architecture We devide the project into 3 layers 
    Model :has bussiness logic
    View  :look and feel
    Controller: it interconnects the View and Model

4.why do we have wwwroot folder?
A. in wwwroot we store static content like HTML,CSS,JS and image files

5.Explain the importance of appsettings.json?
A.it helps to store config information like connectionstring

6.how to read configuratios from appsettings.json?
A.To read data from appsettings.json, we use the IConfiguration interface objcet which is injected by
  MVC Core Dependency injection Framework
  we provide  the IConfiguration object in Constructor as parameter
  
7.What is dependency injection?
A. Dependency injection (DI) is a software design pattern that allows us to seperate the dependencies of a class
   from its implementation.This Makes our code more loosely coupled and easier to test.
   
8. why do we need de injection?
A. Loose coupling
   Testability
   Extensibility
   Reusability
   
9.What is Program.cs in asp.net mvc core?

A. Program. cs file in ASP.NET Core MVC application is an entry point of an application. It contains logic to start the server
 and listen for the requests and also configure the application.
 Every ASP.NET Core web applications starts like a console application then turn into web application.
   
10.what is Startup.css file do?
A.

11.ConfigureService and CongigureMethod?
A.

   1.what is Normal View and Shared View?
A.Normal View: The view available to specific controller action method is called normal view.
  In This case view will private to a controller
  Shared View: the view available to all the controllers of web app is called Shared view.
  in this case view will be public to all the controllers.
  
2.what is state management?
A.website mainatining user information from action to view OR action to action OR common to all users called state management

3.different techniques for state management?
A.viewdata
  ViewBag
  tempdata
  Cookies
  session Object
  Application Object
  Cache object
    
4.Explain ViewBag And ViewData?
A.Both are used to mainatin user information(i.e.Variable) from controller to view.
  -Viewbag is developer friendly 
  -viewData provides beter performance over ViewBag

5.explain tempdata?
A.Tempadata can be used to maintain user information from one action to another action.
  tempdata information can be maintained across different requests using 2 methods
  a) peek method
  b) keep method

6.peek vs keep ?
A. peek method: this can be used to read and maintain the tempdata variable for next requests
               tempdata.Peek(variablename);
			   
   keep method:this can be used to read and maintain the tempdata variable for next requests
               this can be used with combination of normal read.   
			   int n=(int)Tempdata["n1"];
			   Tempadata.keep("n");

7.What is cookie?
A.website storing a variable with in client system is called Cookies .stores only string type, memeory is 4kb only
  it is maintain the info across all the actions.
  The main advantage of cookies is reducing the memory burden on server
  
8. explain seesion objct:
A. website allocationg the black of memory unique to client with in server system is called "Session Object"
   the main problem with session is burden on server
   store any type of data and no memeory restrictions.
   
   session["VarName"]=value;
   reading session: session["varname"].ToString();
   
9.application Object?
  web site allocating the a black of memory to all common to all the user within server system is called Application Object.
  global.asax--application["varname"]
  Controller class--HttpContext.Application["varname"]
  View--HttpContext.current.application[--] 

10.How to Persist tempdata?
We can persist tempdata by calling the keep method.

11.If I Restart the Server Does Tempdata, Session Stay?
No, tempdata and session do not persist in server restarts.  

   
Entity Framework:
-----------------

Entity Framework is an Object-Relational Mapping (ORM) framework used in ASP.NET (including ASP.NET Core) for data access. 
It enables developers to work with databases using .NET objects and eliminates the need for most of the data-access code 
that developers usually need to write.

1.What is Entity Framework?
A.Entity Framework is an Object-Relational Mapping (ORM) framework that enables developers to work with relational databases using 
  .NET objects. It eliminates the need for most of the data-access code that developers usually need to write.
  
2.What are the key components of Entity Framework?
A.DbContext: Represents a session with the database and allows querying and saving data.
  DbSet: Represents a collection of entities of a specific type in the context.
  Entity: Represents a class that maps to a database table. 

3.What are the different approaches to configure Entity Framework in ASP.NET MVC Core?
A.Code First: Define entity classes and relationships in code, and let Entity Framework generate the database schema.
 Database First: Generate entity classes and DbContext from an existing database schema.
 Model First: Design entity classes using a designer, and Entity Framework generates the database schema.  
 
4.What is DbContext in Entity Framework Core?
A. DbContext is the primary class that is responsible for interacting with the database in Entity Framework Core.
   It represents a session with the database and allows querying and saving data. 
   
5.Explain how to perform database migrations in Entity Framework Core.?
A. Database migrations are used to propagate changes made to the data model to the underlying database schema.
   To perform migrations, developers use the dotnet ef migrations command-line tool or 
  the Package Manager Console commands like Add-Migration and Update-Database.   
  
6.  
