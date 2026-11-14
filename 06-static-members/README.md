# Static Members Practice: Course Counter

A C# console application designed to demonstrate the concept of `static` class members and how data can be shared across multiple object instances.

## Features
* **Static Field Integration:** The `Course` class includes a `public static int TotalCourses = 0;` variable, which acts as a global counter shared among all instances.
* **Automatic Incrementing:** The constructor automatically increments the static counter (`TotalCourses++`) every time a new `Course` object is created.
* **Instance vs. Global State:** Demonstrates the difference between instance-specific data (the `Name` field) and class-level data (the `TotalCourses` field).
* **Execution:** The `Program` class creates two `Course` objects ("Misha" and "Fedr") and calls `PrintInfo()` to show how the global counter updates dynamically.

## What I learned in this project
* The purpose and behavior of the `static` keyword in Object-Oriented Programming.
* How to use constructors to automatically track the number of created objects without manually counting them in the main program.
* How to access and output static fields alongside regular instance fields using string interpolation.
