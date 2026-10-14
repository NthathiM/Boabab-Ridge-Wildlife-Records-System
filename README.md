Baobab Ridge Wildlife Records System

1. Project Overview

The Records System is a C# windows forms desktop application developed for the PRG 282 Project.
The purpose of the system is to assist Baobab Ridge Wildlife Rehabilitation Centre manage their animal records. The system allows users to record animal information, update their details, remove records and generate a report based on all of the animal's recovery.

We made use of text files instead of a database.

2.Project Members

Ruvan Nienaber 603284
Michaela Snyman 602276
Nthathi Mpyana 604869
Wiets Swart 603352

3. Features(upcoming)(10/14/2026)
   
Add Animals: Capture an animal's ID, name, species, age, and recovery score.
View Animals: Display stored animal records in a data grid.
Update Animals: Edit an existing animal's details while keeping its ID unchanged.
Delete Animals: Remove an animal record after user confirmation.
Automatic Classification: Determine an animal's rehabilitation status and housing unit from its recovery score.
Summary Report: Calculate the total number of animals, average age, average recovery score, and number of animals in each rehabilitation status.
Input Validation: Check required fields, ID format, text length, and numeric ranges.
File Storage: Read and write animal records using text files.

4. Limitations
   
Text files are used instead of a database.
Data is stored locally so backups need to be managed by users.
The application is strictly a windows desktop application.
