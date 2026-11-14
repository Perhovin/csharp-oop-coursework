# C# OOP Coursework

Consolidated collection of small C# console projects written while learning Object-Oriented Programming, progressing from basic classes to a final project. All projects target .NET 10.

| # | Folder | Topic | What it does | Original repo |
|---|--------|-------|--------------|---------------|
| 01 | [01-class-basics](01-class-basics) | Classes & objects | Defines a `Course` class with public fields, instantiates it, and prints course details. | [CSharp-Class-Basics-Course](https://github.com/Perhovin/CSharp-Class-Basics-Course) |
| 02 | [02-constructors](02-constructors) | Constructors | Creates two `Product` objects via a parameterized constructor and prints them. | [CSharp-Constructors-Product](https://github.com/Perhovin/CSharp-Constructors-Product) |
| 03 | [03-methods](03-methods) | Methods | `BankAccount` class with `Deposit`, `Withdraw`, and `ShowBalance` methods. | [CSharp-Methods-BankAccount](https://github.com/Perhovin/CSharp-Methods-BankAccount) |
| 04 | [04-encapsulation](04-encapsulation) | Encapsulation | `Person` class with private fields and properties that validate input (e.g. non-negative age). | [CSharp-Encapsulation-Person](https://github.com/Perhovin/CSharp-Encapsulation-Person) |
| 05 | [05-lists-foreach](05-lists-foreach) | Lists & `foreach` | Stores `Course` objects in a `List<Course>` and prints them with `foreach`, flagging room numbers over 400. | [CSharp-Static-Members-Course](https://github.com/Perhovin/CSharp-Static-Members-Course) |
| 06 | [06-static-members](06-static-members) | Static members | Counts created `Course` objects via a static `TotalCourses` field incremented in the constructor. | [CSharp-Lists-Foreach-Course](https://github.com/Perhovin/CSharp-Lists-Foreach-Course) |
| 07 | [07-collections](07-collections) | Collections | Keeps `Book` objects in a `List<Book>` and prints title/pages of each via `foreach`. | [CSharp-Collections-Book](https://github.com/Perhovin/CSharp-Collections-Book) |
| 08 | [08-inheritance-minigame](08-inheritance-minigame) | Inheritance | Turn-based arena RPG: `Character` base class with `Warrior`/`Mage`/`Goblin`/`Dragon` subclasses fighting a `Queue` of enemies. | [Inheritance-Minigame-Basic](https://github.com/Perhovin/Inheritance-Minigame-Basic) |
| 09 | [09-polymorphism-minigame](09-polymorphism-minigame) | Polymorphism | Extended arena variant adding an `EliteWarrior` subclass and runtime type checks (`is`/`as`/casts). | [Polymorphism-Minigame](https://github.com/Perhovin/Polymorphism-Minigame) |
| 10 | [10-interfaces](10-interfaces) | Interfaces | Demonstrates interface contracts, polymorphism, interface inheritance, and explicit implementation. | [CSharp-Interfaces-Demo](https://github.com/Perhovin/CSharp-Interfaces-Demo) |
| 11 | [11-dice-game](11-dice-game) | Console game | Player-vs-computer dice game with tie re-rolls and a replay option. | [DiceGame](https://github.com/Perhovin/DiceGame) |
| 12 | [12-student-information](12-student-information) | LINQ & input | Prompts for 5 grades (validated 1–5) and prints max, min, and average via LINQ. | [StudentInformation](https://github.com/Perhovin/StudentInformation) |
| 13 | [13-student-task-manager](13-student-task-manager) | Menu app | Interactive task manager: add/view/remove tasks with a priority enum and a 10-task limit. | [StudentTaskManager](https://github.com/Perhovin/StudentTaskManager) |
| 14 | [14-bank-app](14-bank-app) | Properties & exceptions | `BankAccount` with validated properties that throw on empty names/negative balance; demo with `try`/`catch`. | [bankapp](https://github.com/Perhovin/bankapp) |
| 15 | [15-teacher-system-final](15-teacher-system-final) | Final project | Interactive menu-driven teacher management system: add/list teachers, count, average experience. | [CSharp-OOP-Final-TeacherSystem](https://github.com/Perhovin/CSharp-OOP-Final-TeacherSystem) |

Original repositories are kept (archived) and linked above.

## Run

Each folder contains a self-contained console project:

```bash
cd <folder>/<project-dir>   # e.g. cd 01-class-basics/Course
dotnet run
```
