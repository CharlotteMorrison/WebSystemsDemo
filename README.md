# WebSystemsDemo

Sample demo file for asp.net MVC.  
---
MVC: Model-View-Controler is a type of software architecture (or design pattern) that separates the user interface, the application logic and the data model.  The separation of concerns in MVC keeps the system loosly coupled between layers and allows for reusability and maintainability.

## What is MVC?
*  The model is a representation of the data and provides the method for communicating the data in and out of storage.  It has no method for a person to view its function it is essentially an API for the controller to use to access the data.  The communication to the model is one-way, it only recieves instructions from the controller.  The controller knows how to interact with the model, while the model doesn't know anything about the controller.  
*  The controller contains the logic for the program. The controller is responsible for interacting with the model and determining what information will be sent to the view for display.  The controller determines what views will be displayed on the page, the updates to the views, and controls the data flow into the model.
*  The view layer is concerned with displaying a user interface for the system.  The manipulation of data from the model should have occured prior to being sent to the presentation (view) layer.  

## Helpful Links
1.  How to create your first ASP.NET Web Application [Create a Web App](https://www.tutorialsteacher.com/mvc/create-first-asp.net-mvc-application)
2.  Github and VisualStudio: [How to make them play nicely together](https://www.infragistics.com/community/blogs/b/dhananjay_kumar/posts/step-by-step-working-with-github-repository-and-visual-studio-2015)
3.  Setting up a Foreign Key [SQL Foreign Keys](https://www.techonthenet.com/sql_server/foreign_keys/foreign_keys.php)
4.  Create a Primary key that auto-increments [AUTO_INCREMENT](https://www.w3schools.com/sql/sql_autoincrement.asp)
5.  Microsofts MVC documenation site, includes good high level overview, how-to instructions and videos. [Microsoft MVC](https://docs.microsoft.com/en-us/aspnet/mvc/)
6.  Simple login with sessions [Login Demo](https://www.c-sharpcorner.com/article/simple-login-application-using-Asp-Net-mvc/)
