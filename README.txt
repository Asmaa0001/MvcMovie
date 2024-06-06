Student Name: Asma Farhana Mohideen Nazar
Student Id: 0847949
1405 EDT

Recreated the program, ASP.NET MVC core application using .Net 7

Ran the program, confirmed the default works:
https://localhost:7033/
modified the index.cshtml title to say 'Hello World' and confirmed 
Created a ReadMe.txt for documentation.
Ran the application again to confirm the changes.

1439
Confirm part 1 of the tutorial is complete
I tried changed 'Welcome' to Hello Word' in index.cshtml
https://localhost:7033/HelloWorld/Welcome
Did not get Hello world on the browser so changed the default browser
It is successful 
then started part 2

1445
Part 2 - Controller 
added new controller named as HelloWorldController.cs
Replaced few commands in Controllers/HelloWorldController.cs 
Modified some codes and passed parameter to URL
https://localhost:7033/HelloWorld/Welcome?name=Asma&numTimes=4
It is successful

1522
Modified with other codes and passed parameter to URL
https://localhost:7033/HelloWorld/Welcome/1122?name=Asma
It is successfully displayed 'Hello Asma, ID:1122'

1406
Part 3 - View
Add new folder named as HelloWorld under View
Replaced few commands in index.cshtml razor view file
Ran the command and changed the url respectively
https://localhost:7033/HelloWorld
It is successfully displayed Index - MVC movie

1415
Changed the title, footer and menu link in the layout file
that is view/shared/_Layout.cshtml
Changed MVCMovie to Movie App
http://localhost:7033/Home/privacy
It successfully displayed Privacy Policy

1422
Here passing data from controller to the view
Edited few commands using Tutotial
Then created Welcome.cshtml
https://localhost:7033/HelloWorld/Wecome?name=Asma&numtimes=4
It displayed passing data.

1425
Part 4 - Model
changed few codes accordingly
Added Nuget Package and used the scaffolding tool to produce Create, Read, Update, and Delete
Initiated the migration file
The timestamp migration 20240530163134_InitialCreate

1440
Part 5 - Work with Database
Examined for the SQL Server Express LocalDB
Created new class named SeedData
Added the seed initializer in program.cs
Movie DataBase created successfully
https://localhost:7033/Movies

2024-05-30
1120
Part 6 - Controller actions and views
Modified few commands because Release Date should be two words
Validating the Edit,Delete,Details
In edit action method added Ratings
It is successful

0115
Part 7 - Add Search
Updated the option to search for Genre and Title of the movies
For an instance 
https://localhost:7033/Movies?searchString=Ghost
Ran this on browser so it showed the title which included Ghost in it
https://localhost:7033/Movies?searchString=Comedy
Ran this on browser so it showed the comedy Genre movie

0145
Part 8 - Add a new field
Added a rating property to the movie model
Updated the bind attribute for both the edit and create option to include rating property
Edited index.cshtml to add rating field
Updated in create.cshtml as well
Modified in the seeddata class file to create a new column for each movie
Again initiated the NuGet package manager
Rating field added
https://localhost:7033/Movies
It is successful!










part7


https://localhost:7033/Movies/index/ghost

https://localhost:7033/Movies?SearchString=ghost

https://localhost:7033/Movies?MovieGenre=Comedy&SearchString=ghost



