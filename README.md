
# 📘 DCIT 318: Programming II — Assignment 2

This project demonstrates key concepts of **Object-Oriented Programming (OOP)** in C# through three simple console applications. The tasks are structured to show:

- ✅ Inheritance & Method Overriding  
- ✅ Abstract Classes and Methods  
- ✅ Interfaces

---

## 🛠 Technologies Used

- Language: **C#**
- Framework: **.NET 9.0**
- IDE: **Visual Studio Code**
- Version Control: **Git & GitHub**

---

## 📂 Project Structure

```
OOPDemo/
│
├── InheritanceDemo.cs       // Animal, Dog, Cat classes with overridden MakeSound()
├── AbstractClassDemo.cs     // Shape, Circle, Rectangle with GetArea()
├── InterfaceDemo.cs         // IMovable, Car, Bicycle with Move()
├── Program.cs               // Main method to test all components
├── OOPDemo.csproj           // .NET project file
└── OOPDemo.sln              // Solution file
```

---

## 🧪 Features Demonstrated

### 🔸 1. Inheritance and Method Overriding
Defines a base `Animal` class with a virtual `MakeSound()` method, and two derived classes (`Dog`, `Cat`) that override it.

### 🔸 2. Abstract Classes and Methods
Defines an abstract `Shape` class with a method `GetArea()`, implemented by `Circle` and `Rectangle`.

### 🔸 3. Interfaces
Defines an `IMovable` interface with a `Move()` method, implemented by `Car` and `Bicycle`.

---

## 🚀 How to Run the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/GyabaahFelix/dcit318-assignment2-11227253.git
   cd dcit318-assignment2-11227253/OOPDemo
   ```

2. Run the program:
   ```bash
   dotnet run
   ```

---

## ✅ Commit History

Each part of the assignment is committed separately for clarity:
- `InheritanceDemo.cs` — Implements inheritance
- `AbstractClassDemo.cs` — Implements abstract class behavior
- `InterfaceDemo.cs` — Implements interface behavior
- `Program.cs` — Entry point calling all demo parts

---

## 📌 Author

**Felix Gyabaah**  
University of Ghana  
Student ID: `11227253`
