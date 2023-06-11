<p align="center">
	<a href="https://github.com/Roslan1419/IOT1026-Assignment-4/actions/workflows/ci.yml">
    <img src="https://github.com/Roslan1419/IOT1026-Assignment-4/actions/workflows/ci.yml/badge.svg"/>
    </a>
	<a href="https://github.com/Roslan1419/IOT1026-Assignment-4/actions/workflows/formatting.yml">
    <img src="https://github.com/GwGibson/IOT1026-Assignment-4/actions/workflows/formatting.yml/badge.svg"/>
	<br/>
    <a href="https://codecov.io/gh/Roslan1419/IOT1026-Assignment-4" > 
    <img src="https://codecov.io/gh/Roslan1419/IOT1026-Assignment-4/branch/main/graph/badge.svg?token=JS0857X5JD"/> 
	<img title="MIT License" alt="license" src="https://img.shields.io/badge/license-MIT-informational?style=flat-square">	
    </a>
</p>

# IOT1026-Assignment-4
        
Command Design Pattern Implementation for Robot Control in C#
This project focuses on implementing the Command design pattern using interfaces in C#. The objective is to develop a system that controls a robot through various commands. The project includes the following steps:

Replacing the Abstract Class: The initial code provides an abstract class called RobotCommand. As part of the project, the abstract class is replaced with an interface called IRobotCommand. This interface defines the contract for command objects.

Recreating Command Classes: The existing command classes, such as OffCommand, OnCommand, WestCommand, EastCommand, SouthCommand, and NorthCommand, are recreated to implement the IRobotCommand interface instead of inheriting from the abstract class. The Run() method implementation of each command class is updated accordingly.

Updating the Robot Class: The Robot class is updated to use the Assignment.InterfaceCommand namespace instead of the previous Assignment.AbstractCommand namespace. This ensures that the Robot class is compatible with the new IRobotCommand interface.

Designing and Implementing a New Command Class: A new command class is created to introduce a unique action for the robot. This new command class implements the IRobotCommand interface and provides a distinct functionality for controlling the robot.

Writing Unit Tests: Comprehensive unit tests are written to validate the functionality of the Robot class and the command classes. These tests cover various scenarios, including edge cases, to ensure the proper execution of commands and the expected behavior of the robot.

Creating a RobotTester Class: A RobotTester class is implemented to allow user input for loading and executing robot commands. The RobotTester class prompts the user to enter command strings, converts the input strings into command objects, loads the commands into a robot instance, and executes them. The state of the robot is displayed after each command execution.

Once the implementation is completed, the project is submitted by providing a link to the GitHub repository containing the code. The repository should include a README file that provides an overview of the implementation, instructions for running the code, and any additional details about the project. An embedded image is included in the README to demonstrate the output of the RobotTester class during testing.

The project is evaluated based on the accuracy of implementing the Command design pattern using interfaces, correct utilization of the IRobotCommand interface, thorough unit testing, clear naming conventions, sufficient comments and documentation, and proper code formatting.


[![ci](https://github.com/Roslan1419/IOT1026-Assignment-4/actions/workflows/ci.yml/badge.svg?branch=Command-implentation)](https://github.com/Roslan1419/IOT1026-Assignment-4/actions/workflows/ci.yml) 

[Assignment Instructions](docs/instructions.md)  
[How to start coding](docs/how-to-use.md)  
[How to update status badges](docs/how-to-update-badges.md)
