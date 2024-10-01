# MovieSite sample solution
This repository contains an ASP.NET MVC solution with two projects:  
- MovieSite.DAL (the data access layer)
- MovieSite.Website (the actual website)

<img width="472" alt="image" src="https://github.com/user-attachments/assets/8a9acb63-1252-4cef-b5c2-9e22ec4651a2">

## MovieSite.DAL
This project defines the interface for the DAO classes that the website's Movie controller depends on for CRUD operations. 
<img width="1358" alt="image" src="https://github.com/user-attachments/assets/ad74c7f1-683a-4b01-96c6-412062c01928">

The two implementations of IMovieDAO are
- InMemoryMovieDAO, which has an internal List<Movie> for easy testing in usecases where there is no database available
- MsSqlMovieDAO, which is for connecting to an SQL server and is only a stub for now.
