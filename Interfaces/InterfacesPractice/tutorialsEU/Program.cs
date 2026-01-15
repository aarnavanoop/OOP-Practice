using System;
using System.Collections;


public class Car
{
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Year} {Model}";
    }
}


public class Garage : IEnumerable
{

    private Car[] _cars;

    public Garage(Car[] carArray)
    {
        _cars = carArray;
    }

    public IEnumerator GetEnumerator()
    {
        return new GarageEnumerator(_cars);
    }
}

// This is the "Cursor" or the "Worker".
public class GarageEnumerator : IEnumerator
{
    // 1. A reference to the collection we are looping through
    private Car[] _cars;

    // 2. The current position index.
    // IMPORTANT: We start at -1 because we are technically "before" the first item.
    // The loop calls MoveNext() FIRST, which moves us to 0.
    private int _position = -1;

    // Constructor: The Garage passes its cars to us here
    public GarageEnumerator(Car[] list)
    {
        _cars = list;
    }

    // 3. MoveNext()
    // Tries to move the cursor forward one step.
    // Returns true if successful, false if we ran out of items.
    public bool MoveNext()
    {
        _position++; // Move index from -1 to 0, or 0 to 1, etc.

        // Check if we have gone past the end of the array
        if (_position < _cars.Length)
        {
            return true; // Yes, we are pointing at a valid car
        }
        else
        {
            return false; // No, we reached the end
        }
    }

    // 4. Reset()
    // Sets the position back to "before the start"
    public void Reset()
    {
        _position = -1;
    }

    // 5. Current
    // This returns the object at the current position.
    public object Current
    {
        get
        {
            // Just try to return the car at the current index
            try
            {
                return _cars[_position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}