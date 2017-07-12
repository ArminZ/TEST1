# ANR Scoring And Visualisation
#### What is this?
Air Navigation Race (ANR) is an official competition discipline in General Aviation. 
For more details please refer to the FAI pages on http://www.fai.org/gac-our-sport/air-navigation-race  
The ANR scoring and visualisation software presented below is an application used in Air Navigation Race (ANR) competitions.
In brief, this software is used to create & manage ANR competitions and competition tasks, and -maps. 
Data collected during the competition flight is imported into the application, and penalty points for the flight will be calculated. 
This application allows to import map data, to design a competition tasks (referred to as 'parcour') in Google Earth, 
and to print out the map with the competition task overlay.

---
#### Technical
The application is a Microsoft Windows Forms (stand-alone) application written in C# (.NET Framework 4.5, and Entity Framework 6.1). 
Data is stored in a local MS SQL database file (SQLLocalDB).

---
#### History
With the original ANR rules and specifications by Heini Schawalder and Maurice Ducret, the development for the ANR scoring and visualisation 
software was initiated during 2009-2010 at the Commercial and Industrial Training College, Berne, Switzerland (GIBBS), 
under the technical lead of **Luc Baumann/SharpSoft**. Luc has been maintaining the application since its beginnings in 2009.
Old code can be found from the google code archive https://code.google.com/archive/p/anrl/downloads. 
At this time the application was basically a client-server application with a centralized database server. Later on a first stand-alone version was tested. There has been some development in 2015, probably from the 2013 stand-alone version of the 'Anrl.zip (workaround-local-app)' version of above google code. Luc has stored the latest code of the 2015 stand-alone version in a dedicated GitHub repository ( https://github.com/helios57/anrl). This repository served as the starting point for the code presented here.

During 2016 the user interface was entirely renewed and improved, bugs fixed, unused and outdated code removed. The most important new functionality was the Route Generator, allowing parcour generation from Google Earth kml files. Also some documentation was provided, including the important subjects of map conversion/map import, and parcour creation/import.

#### Next version 2.0.0 (Summer/autumn 2017)

* Move from Entity Framework (EF) 6.1 database-first to EF 6.1 Code-first, and implementation of EF Migration functionality
* This will allow to keep existing database files from previous versions compatible, and include more tables/fields as required on code side
* Removal of unused code, some rework on the grapical side
* Disabled old Beta-code for Route generation

--- 
#### What is new in this version?

Changes for each version are listed in the [Release section](../../releases) of this repository.

---
#### Download?
Binaries and documentation are available in the [Release section](../../releases) of this repository.
