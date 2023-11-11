# Elements: A C# Library for the Periodic Table of Elements

Elements is a C# library that contains a readonly static collection of the elements from the periodic table of elements.

## Features

- Elements provides a simple and convenient way to access the properties of the elements, such as their name, symbol, atomic number, atomic mass, group, period, and more.
- Elements also supports some basic operations on the elements, such as comparing them by atomic number, mass, or name, or finding the element with a given symbol or name.
- Elements is compatible with .NET Standard 2.0 and .NET 7.0

## Usage

To use Elements, you need to add the following using directive to your C# file:

```csharp
using Brysageek.Elements;
```

Then, you can access the elements collection as `Elements.All`, which is an `IReadOnlyList<Element>` that contains all the elements in the periodic table. For example, you can print the name and symbol of each element using a foreach loop:

```csharp
foreach (var element in Elements.All)
{
    Console.WriteLine($"{element.Name} ({element.Symbol})");
}
```

You can also access a specific element by its name:

```csharp
Console.WriteLine($"Name: {Elements.Hydrogen.Name} Atomic Mass: {Elements.Hydrogen.AtomicMass});
```

Or by its symbol or name using the `Find` method:

```csharp
var carbon = Elements.Find("C"); // Find the element with symbol "C"
Console.WriteLine(carbon.AtomicNumber); // Prints "6"

var oxygen = Elements.FindByName("Oxygen"); // Find the element with name "Oxygen"
Console.WriteLine(oxygen.AtomicMass); // Prints "15.9994"
```

You can also you access the collection using LINQ expressions:

```csharp
var sortedByMass = Elements.All.OrderBy(element => element.AtomicMass));
foreach (var element in sortedByMass)
{
    Console.WriteLine($"{element.Name} ({element.AtomicMass})");
}
```

## License

Elements is licensed under the [MIT License], which means you can use, modify, and distribute it freely, as long as you give credit to the original author and include a copy of the license in your project.

## Feedback

If you have any questions, suggestions, or issues with Elements, please feel free to [open an issue] or [submit a pull request] on GitHub. Brysageek welcomes any feedback and contributions from the community.