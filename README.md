# How To Train Your Dragon Database
## By Stephen Reilly

## About
This project is my Final Project for Elevenfity.
It is a MVC of a How To Train Your Dragon Database. It covers this entire franchise of locations, dragons, human characters, and parternships.
## Getting Started
If you just want to see my C# and cshtml of the project, everything is on GitHub and up to date. Just Click on the folders. HowToTrainYourDragon.Data has the data layers, the codes to have the ApplicationDbContext, and my Seed Data. HowToTrainYourDragon.Model folder has my model layers of each of my data tables. The HowToTrainYourDragon.Service has all my service layers. Last but no least, my HowToTrainYourDragon.WebMVC which makes my program go. It has my all my controllers, view pages that lays out how each page will look, and my web configuration.


## My Planning Process

https://docs.google.com/document/d/1FhAfYpOpOS8LA_o3nz5ypC7qLd9RhaMTIh1htciG8AU/edit

![alt text](relative/path/to/HowToDragonDiagram.png?raw=true "WireFram")


## Process
Now you want if you want to see the actual database, here's want you do.
1. Clone my project of GitHub into Visual Studio.
2. Probably do a clean and rebuild before doing anything just to be safe.
3. Right Click on HowToTrainYourDragon.WebMVC, Debug, then start instance. Or press the just press the play button at the top. This should open the home page of my MVC.
4. As you can see, it's beautiful.
5. First order of business, in order to anything special on this webpage, you got to register an email. So click on Register and enter an email, and password.  Now you are able to navigate through my page.
6. Navigating is pretty easy: clicking on the Location link in the nav bar or the button in the Location box takes you to my list of Location. The dragon links in the nav bar and Dragon box takes you to the list of dragons. Human links takes you to the list of Human Characters. And the Partnership links takes you to the list of human and dragon duos. The About Me takes you to the About me page. And the Contact takes you to the contact page.
7. For all  Tables- You are at the Index of any of my tables. To create a new object, click "Create New". Then enter all the information. The click create. Should be at the bottom of the corresponding list. Click on details to see the detail of the. If you ever need to edit, click edit. If you need to delete, click delete, and delete again.
8. Dragons and Humans both have Images you can upload if you go wish. They work better if they are save first as a jpeg or jpg.
9. Now for the delete, it's tricky. Since Location has a list of human and dragons, deleting the location will also delete all the humand and dragons that are attached to it. So make sure to edit the dragon and humans that are attach to first by editing them to a new location. Deleting a Dragon will delete the Human(if there is one) corresponding to it and also the Partnership, if there is one. Deleting the Human will delete the partnership(if there is one).

## Experience

I really love this assignment. It is a great send off from the ElevenFifty academy. I learned so much through the process that I didn't think I would. The one thing I did love was actually designing the webpage itself with cshtml; just letting my creative juices flow was great I have come a long way from when I first started here. 

## Contributers
Stephen Reilly
