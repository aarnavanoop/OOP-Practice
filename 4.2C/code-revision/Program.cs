using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskPlanner.Models
{
    // 1. THE TASK OBJECT
    public class Task
    {
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsImportant { get; set; }

        public Task(string name, DateTime dueDate, bool isImportant = false)
        {
            Name = name.Length > 20 ? name.Substring(0, 20) : name;
            DueDate = dueDate;
            IsImportant = isImportant;
        }

        public override string ToString()
        {
            return $"{Name} ({DueDate:MM/dd})";
        }
    }

    // 2. THE CATEGORY OBJECT
    public class Category
    {
        public string Name { get; set; }
        public List<Task> Tasks { get; private set; } = new List<Task>();

        public Category(string name) => Name = name;

        public void AddTask(Task task) => Tasks.Add(task);
        
        public void RemoveTaskAt(int index)
        {
            if (index >= 0 && index < Tasks.Count) Tasks.RemoveAt(index);
        }

        public void ReorderTask(int oldIndex, int newIndex)
        {
            if (oldIndex < 0 || oldIndex >= Tasks.Count || newIndex < 0 || newIndex >= Tasks.Count) return;
            var item = Tasks[oldIndex];
            Tasks.RemoveAt(oldIndex);
            Tasks.Insert(newIndex, item);
        }
    }
}

namespace TaskPlanner.App
{
    using TaskPlanner.Models;

    class Program
    {
        static List<Category> categories = new List<Category>();

        static void Main(string[] args)
        {
            // Seed initial data
            categories.Add(new Category("Personal"));
            categories.Add(new Category("Work"));

            while (true)
            {
                RenderTable();
                Console.WriteLine("\nOptions: [1] Add Cat [2] Del Cat [3] Add Task [4] Del Task [5] Reorder [6] Move Cat [7] Exit");
                Console.Write(">> ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddCategory(); break;
                    case "2": DeleteCategory(); break;
                    case "3": AddTask(); break;
                    case "4": DeleteTask(); break;
                    case "5": ReorderTask(); break;
                    case "6": MoveTaskBetweenCategories(); break;
                    case "7": return;
                }
            }
        }

        static void RenderTable()
        {
            Console.Clear();
            if (categories.Count == 0) { Console.WriteLine("No categories available."); return; }

            int maxTasks = categories.Max(c => c.Tasks.Count);
            int colWidth = 35;

            // Print Headers
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0,5} |", "ID");
            foreach (var cat in categories) Console.Write("{0," + colWidth + "} |", cat.Name);
            Console.WriteLine("\n" + new string('-', 5 + (categories.Count * (colWidth + 2))));
            Console.ResetColor();

            // Print Rows
            for (int i = 0; i < Math.Max(maxTasks, 1); i++)
            {
                Console.Write("{0,5} |", i);
                foreach (var cat in categories)
                {
                    if (i < cat.Tasks.Count)
                    {
                        var task = cat.Tasks[i];
                        if (task.IsImportant) Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0," + colWidth + "} |", task.ToString());
                        Console.ResetColor();
                    }
                    else Console.Write("{0," + colWidth + "} |", "---");
                }
                Console.WriteLine();
            }
        }

        // --- FUNCTIONALITY METHODS ---

        static void AddCategory()
        {
            Console.Write("New category name: ");
            categories.Add(new Category(Console.ReadLine()));
        }

        static void DeleteCategory()
        {
            Console.Write("Enter Category Name to delete: ");
            string name = Console.ReadLine();
            categories.RemoveAll(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        static void AddTask()
        {
            Console.Write("Category Name: ");
            var cat = categories.FirstOrDefault(c => c.Name.Equals(Console.ReadLine(), StringComparison.OrdinalIgnoreCase));
            if (cat == null) return;

            Console.Write("Task Description: ");
            string desc = Console.ReadLine();
            Console.Write("Due Date (yyyy-mm-dd): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime date);
            Console.Write("Important? (y/n): ");
            bool imp = Console.ReadLine().ToLower() == "y";

            cat.AddTask(new Task(desc, date, imp));
        }

        static void DeleteTask()
        {
            Console.Write("Category Name: ");
            var cat = categories.FirstOrDefault(c => c.Name.Equals(Console.ReadLine(), StringComparison.OrdinalIgnoreCase));
            Console.Write("Task Index: ");
            if (int.TryParse(Console.ReadLine(), out int idx)) cat?.RemoveTaskAt(idx);
        }

        static void ReorderTask()
        {
            Console.Write("Category Name: ");
            var cat = categories.FirstOrDefault(c => c.Name.Equals(Console.ReadLine(), StringComparison.OrdinalIgnoreCase));
            Console.Write("Current Index: ");
            int oldIdx = int.Parse(Console.ReadLine());
            Console.Write("New Priority Index: ");
            int newIdx = int.Parse(Console.ReadLine());
            cat?.ReorderTask(oldIdx, newIdx);
        }

        static void MoveTaskBetweenCategories()
        {
            Console.Write("From Category: ");
            var from = categories.FirstOrDefault(c => c.Name.Equals(Console.ReadLine(), StringComparison.OrdinalIgnoreCase));
            Console.Write("Task Index: ");
            int idx = int.Parse(Console.ReadLine());
            Console.Write("To Category: ");
            var to = categories.FirstOrDefault(c => c.Name.Equals(Console.ReadLine(), StringComparison.OrdinalIgnoreCase));

            if (from != null && to != null && idx < from.Tasks.Count)
            {
                var task = from.Tasks[idx];
                from.RemoveTaskAt(idx);
                to.AddTask(task);
            }
        }
    }
}