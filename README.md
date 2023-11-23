# Elements: A C# Library for the Periodic Table of Elements

Elements is a C# library that contains a readonly static collection of the elements from the periodic table of elements. Use it anywhere and everywhere !!

## Features

- Elements provides a simple and convenient way to access the properties of the elements, such as their name, symbol, atomic number, atomic mass, group, period, and more.
- Elements is compatible with .NET 8.0

## Usage

To use Elements, you need to add the following using directive to your C# file:
```csharp
using Brysageek.Elements;
```

Then, you can access the elements collection as `Chemicals.All`, which is an `ReadOnlyCollection<ChemicalElement>` that contains all the elements in the periodic table. For example, you can print the name and symbol of each element using a foreach loop:
```csharp
foreach (var element in Chemicals.All)
{
    Console.WriteLine($"{element.Name} ({element.Symbol})");
}
```

`ToString()` is overloaded to provide the chemical name:
```csharp
Console.WriteLine(Chemicals.Hydrogen.ToString());
Console.WriteLine(Chemicals.Hydrogen);
```

You can also access a specific element by its name:
```csharp
Console.WriteLine($"Name: {Chemicals.Hydrogen} Atomic Mass: {Chemicals.Hydrogen.AtomicMass});
```

You can also you access the collection using LINQ expressions:
```csharp
var sortedByMass = Chemicals.All.OrderBy(element => element.AtomicMass));
foreach (var element in sortedByMass)
{
    Console.WriteLine($"{element} ({element.AtomicMass})");
}
```

Get Radioactive Elements:
```csharp
var radioactiveElements = Chemicals.All.Where(element => element.Radioactive));
foreach (var element in radioactiveElements)
{
    Console.WriteLine($"{element} ({element.Radiactive.ToString()})");
}
```

Get Elements based off their Metal Type:
```csharp
var alkalines = Chemicals.All.Any(element => element.MetalType == MetalClassificationTypes.AlkalineMetal);
foreach (var element in alkalines)
{
    Console.WriteLine($"{element} ({element.MetalType.ToString()})");
}
```

Included overloads for `Equals(object)` and `Equals(ChemicalElement)` Comparing Atomic Mass (may not prove that useful):
```csharp
if(!Chemicals.Hydrogen.Equals(Chemicals.Calcium))
    Console.WriteLine("Not Equal");
```

Included operator overloads for `==` and `!=` (may not prove that useful):
```csharp
if(Chemicals.Hydrogen == Chemicals.Hydrogen)
    Console.Writeline("Equal");

if(Chemicals.Hydrogen != Chemicals.Neon)
    Console.WriteLine("Not Equal");
```

Included overload for `GetHashCode()` as well:
```csharp
Console.WriteLine(Chemicals.Hydrogen.GetHasCode().ToString());
```

## License

Elements is licensed under the [MIT License], which means you can use, modify, and distribute it freely, as long as you give credit to myself and include a copy of the license in your project.

## Feedback

If you have any questions, suggestions, or issues with Elements, please feel free to [open an issue] on GitHub. Brysageek welcomes any feedback and contributions from the community.