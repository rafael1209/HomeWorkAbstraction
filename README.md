# Vehicle Information System

This project implements a simple vehicle information system using C# with a focus on object-oriented programming concepts such as abstraction and inheritance. It provides functionality to manage various types of vehicles including cars, airplanes, and cargo planes.

## Features

- **Vehicle Class Hierarchy:** The project defines a class hierarchy for vehicles, with a base class `Vehicle` and derived classes `Car`, `Airplane`, and `CargoPlane`, demonstrating the use of inheritance.
- **Abstraction:** Abstraction is utilized to define common properties and behaviors of vehicles in the base class, while specific details are implemented in derived classes.
- **Polymorphism:** The program demonstrates polymorphic behavior through method overriding, allowing different types of vehicles to be processed uniformly.
- **Data Analysis:** The system analyzes an array of vehicles to determine the count of airplanes and cargo planes, as well as identifying specific details such as the lowest flying airplane and the cargo plane with the highest cargo capacity.

## Usage

To use the program, simply run the `Program.cs` file. It initializes an array of vehicles with sample data and provides information about the vehicles present in the array.

## Classes

- **Vehicle:** Defines basic properties common to all vehicles such as `Way` (land, air), `MaxSpeed`, and methods for retrieving information.
- **Car:** Represents a car with additional properties like `MaxPassengers`.
- **Airplane:** Inherits from `Vehicle` and represents an airplane with an added property `MaxHeight`.
- **CargoPlane:** Inherits from `Airplane` and represents a cargo plane with an additional property `MaxCargo`. It also includes a method to compare cargo capacities between cargo planes.

## Getting Started

1. Clone this repository.
2. Open the solution in your preferred C# IDE.
3. Compile and run the `Program.cs` file.
4. Explore the functionality and code to understand how abstraction and inheritance are implemented.

## Contributors

- [Rafael Chasman](https://github.com/rafael1209)

## License

This project is not licensed and is provided as-is without any warranty or support. Feel free to use, modify, and distribute the code as you see fit.
