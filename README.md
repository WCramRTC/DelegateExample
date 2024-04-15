Here's a basic overview of how delegates work in C# along with some code snippets:

### Declaring a Delegate:
```csharp
// Declare a delegate named MyDelegate
public delegate void MyDelegate(string message);

```

### Defining Methods to be Referenced by the Delegate:
```csharp
public class MyClass
{
    // Method to be referenced by the delegate
    public void Method1(string message)
    {
        Console.WriteLine("Method1: " + message);
    }

    // Another method to be referenced by the delegate
    public void Method2(string message)
    {
        Console.WriteLine("Method2: " + message);
    }
}
```

### Using the Delegate:
```csharp
class Program
{
    static void Main(string[] args)
    {
        // Instantiate MyClass
        MyClass obj = new MyClass();

        // Create an instance of the delegate and associate it with Method1
        MyDelegate del = new MyDelegate(obj.Method1);

        // Invoke the delegate
        del("Hello from Method1");

        // Reassign the delegate to Method2
        del = new MyDelegate(obj.Method2);

        // Invoke the delegate again
        del("Hello from Method2");
    }
}
```

In this example:
- We declare a delegate `MyDelegate` that can reference methods taking a string parameter and returning void.
- We define two methods (`Method1` and `Method2`) in `MyClass`, which will be referenced by the delegate.
- In the `Main` method, we instantiate `MyClass` and create an instance of the delegate `MyDelegate` associated with `Method1`.
- We invoke the delegate, which in turn calls `Method1`.
- Then, we reassign the delegate to `Method2` and invoke it again, which now calls `Method2`.

Delegates are extensively used in C# for implementing events, callbacks, and LINQ query expressions, among other things. They provide a flexible and type-safe way to work with methods as first-class objects.