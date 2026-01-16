# C# Object-Oriented Programming Portfolio

> **Status:** High Distinction Achieved 🏆
> **Focus:** System Architecture, TDD, & Clean Code Principles

This repository documents my progression from fundamental logic to complex, scalable system architecture in C# .NET. It demonstrates a mastery of polymorphic design, robust error handling, and test-driven development.

## 🌟 Featured Engines & Systems

### 1. Polynomial Mathematics Engine (Test-Driven Development)
A robust mathematical library designed to handle complex polynomial operations without relying on built-in math shortcuts.
* **The Challenge:** Accurately adding, multiplying, and evaluating polynomials of varying degrees (e.g., 3x^2 + 2x) while preventing array index errors.
* **Engineering approach:**
  * **Encapsulation:** Protected coefficient arrays using properties to prevent external corruption.
  * **Algorithm Design:** Implemented custom logic for **Horner’s Method** (evaluation) and convolution algorithms (multiplication) to handle degree shifting.
  * **TDD (Test Driven Development):** Built using a separate **xUnit** project (`Task3D.Tests`) to validate logic before implementation, ensuring 100% pass rates on edge cases.

### 2. Intelligent Task Planner (Refactoring Challenge)
Refactored a monolithic "spaghetti-code" script into a modular, object-oriented Category-Task system.
* **Dynamic UI:** Built a console-based table renderer that calculates column widths on the fly.
* **Data Structures:** Utilized LINQ for efficient searching and List manipulation for reordering tasks.

### 3. Robust Banking System
A transaction simulator prioritizing data integrity and financial accuracy.
* **Defensive Coding:** Implemented `decimal` types for currency precision and `TryParse` patterns to prevent runtime crashes from invalid user input.
* **State Management:** Used immutable design patterns (init-only properties) to ensure account identities cannot be tampered with after creation.

---

## 🏗 Architecture & Design Patterns

### 🔹 Interfaces & Contracts (`ISearchable`)
* **Project:** *Polymorphic Search Engine*
* **Concept:** Created a loosely coupled search system where a `SearchEngine` can process *any* object (`Document`, `UserAccount`) as long as it signs the `ISearchable` contract.
* **Result:** The engine operates blindly on the interface, proving the **Dependency Inversion Principle**.

### 🔹 Abstraction & Base Classes
* **Project:** *Fleet Management System* (`Vehicle`, `ElectricCar`, `Truck`)
* **Concept:** Utilized `abstract` base classes to enforce mandatory behaviors (`StartEngine`, `GetRange`) while allowing derived classes to implement unique logic (e.g., calculating range based on Battery kWh vs. Diesel Cargo Load).
* **Key Skill:** `protected` constructors and method overriding.

### 🔹 Advanced Polymorphism & Covariance
* **Project:** *Biological Taxonomy Simulation* (`Bird`, `Penguin`, `Duck`)
* **Concept:** Mastered the "Is-A" relationship.
* **Covariance:** Demonstrated how to treat a `List<Duck>` as an `IEnumerable<Bird>`, essential for writing scalable code that can process collections of specific types as generic groups.

---

## 🛠 Technical Keywords
| Category | Skills Demonstrated |
| :--- | :--- |
| **Core C#** | `Properties`, `Enums`, `TryParse`, `Virtual/Override`, `Abstract`, `Interfaces` |
| **Collections** | `List<T>`, `Dictionary<K,V>`, `IEnumerable`, `Arrays (1D/2D)` |
| **Testing** | **xUnit Framework**, Unit Testing, Test-Driven Development (TDD) |
| **Principles** | **OOP**, **DRY** (Don't Repeat Yourself), **Encapsulation**, **Polymorphism** |
