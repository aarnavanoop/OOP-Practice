SIT232: Object-Oriented Development Portfolio
This repository documents my journey through Object-Oriented Development in C#, progressing from fundamental logic to complex system architecture. My work here earned a High Distinction, reflecting a deep dive into clean code practices, robust error handling, and polymorphic design.

Featured Projects
1. Intelligent Task Planner (Refactoring Challenge)
One of the most significant builds in this portfolio was the transition from a "spaghetti-code" procedural task list to a fully modular Category-Task System.

The Problem: A monolithic script using fragmented arrays and duplicate logic for different categories.

The Solution: I refactored the system into a clean Category and Task model. It features a dynamic console-based table renderer that calculates column widths on the fly and highlights "Important" tasks in color.

Key Logic: Implemented task reordering, moving items between categories, and LINQ-based searching.

2. Robust Banking & Transaction System
I developed a banking simulator that prioritizes data integrity and user experience.

Safety First: Uses decimal for currency precision and TryParse patterns to ensure the system never crashes on invalid user input.

State Management: Utilizes Enums for menu navigation and init properties to ensure account names remain immutable once created.

3. The "Zoo Park" & Avian Hierarchies
To master the "is-a" relationship, I built several simulation engines modeling biological hierarchies (Animals, Felines, Birds).

Polymorphic Behavior: Created a system where a List<Bird> can contain Penguins, Ducks, and Eagles. While they all "Fly," the Penguin class overrides this to explain why it can't, demonstrating how specialized classes can refine base behaviors.

🧠 Key Concepts Covered
Advanced Inheritance & Polymorphism
Virtual/Override: Used to allow specialized subclasses (like Tiger or Eagle) to implement their own versions of MakeNoise() and Eat().

Upcasting & Covariance: Explored how to treat a collection of specific objects (like List<Duck>) as a more general collection (IEnumerable<Bird>), which is essential for building scalable systems.

Defensive Programming & Error Handling
Exception Catching: Implemented targeted try-catch blocks to handle common runtime errors such as IndexOutOfRangeException (array boundaries) and NullReferenceException (handling null objects gracefully).

Input Validation: Moving beyond basic checks to ensure objects always exist in a "valid state" (e.g., preventing negative withdrawals or empty task descriptions).

Algorithmic Data Management
Complex Collections: Worked extensively with 1D and 2D arrays, as well as List<T>.

Custom Logic: Built algorithms from scratch for:

Palindromes: Efficiently checking symmetry in arrays.

Sorted Merging: Combining two sorted lists into a single sorted result.

Grid Processing: Converting specific elements of a 2D matrix into a filtered 1D array.

Clean Code & Engineering Practices
Encapsulation: Protecting the internal state of objects using private set and properties.

Code Reusability: Identifying duplicate logic and abstracting it into methods or base classes to follow the DRY (Don't Repeat Yourself) principle.