# Traffic-Sim
 A traffic control simulation created in Spring of 2022 with the following capabilities:
 
    1. Contains an additional class that allows the user to define car objects. Assigns a sequence
       number variable, arrival time variable and an exit time variable to each car. 
    
    2. Reads the data file which contains the direction that the car comes from and the time that   
       it arrives at the intersection (e.g. "W103") and has cars arrive in sequence in each      
       direction. The cars are then lined up waiting to get through the light while the light is  
       yellow or red. A C# list variable represents this line. 

    3. Cars will only pass through the intersection when the light is green. They will not enter 
       the intersection when the light is yellow or red. 
       
    4. In this simulation, it takes one second for a car to pass through the intersection. 
       Every car takes one second to pass through the intersection. 
       
    5. The program runs for 240 seconds. It then prints a complete display of the current state of 
       each light every time a light changes color and print the current time. 
       
     6. A notification is printed each time a car passes through the intersection: the car's 
        sequence number, arrival time, exit time, and total time waiting. 
        
     7. System terminates the program at the 240 second mark.
     
     8. Once the simulation is complete, program outputs the following: 
        a. Number of cars coming from each direction
        b. The maximum size of the line of cars that had to wait to get through the light. 
        c. The average amount of time that cars wait based on which direction they are coming 
           from (four values)

To run the program:
  Compile and import all files at once into Visual Studio by running hw1.sln 
