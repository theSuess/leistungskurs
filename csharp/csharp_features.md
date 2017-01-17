# v1.0 

* Erschienen 2002

# v2.0

* Erschienen 2005 - 2006

* Generics
* Partielle Typen
* Anonyme Typen
* Iteratoren
* Nullable-Datentyp
* Private setters
* Delegates
* Kovarianz und Kontravarianz
* statische Klassen

# v3.0

## Erweiterungsmethoden

~~~csharp
public static class MyStringExtensions
{
  public static string MySubstring(this string me, int position, int length)
  {
     //beliebige Logik
     return "My" + me.Substring(position, length);
  }
}
~~~

## Verwendung

~~~csharp
string teststring = "test";
teststring.MySubstring(1, 2);
~~~

## LINQ

* Funktionale Programmierung in C#
* Schleifen los werden -> sowas wie SQL


~~~csharp
List<int> Numbers = new List<int>() {1,2,3,4}; // list with 4 numbers

// query is defined but not evaluated
var query = from x in Numbers
            select x;

Numbers.Add(5); // add a 5th number

// now the query gets evaluated
Console.WriteLine(query.Count()); // 5

Numbers.Add(6); // add a 6th number

Console.WriteLine(query.Count()); // 6
~~~

# v5.0

## Asynchrone Methoden

## Caller-Info Attribute

# v6.0

## Exception Filters

~~~csharp
try { … }
catch (MyException e) when (myfilter(e))
{
    …
}
~~~

## Null-Conditional Operator

~~~csharp
public static string Truncate(string value, int length)
{          
  return value?.Substring(0, Math.Min(value.Length, length));
}
~~~

## nameof - Ausdruck

~~~csharp
WriteLine(nameof(person.Address.ZipCode)); // prints "ZipCode"
~~~

## String Interpolation

~~~csharp
var s = $"{p.Name} is {p.Age} year{{s}} old";
~~~

# v7.0

## param Schlüsselwort auf IEnumerable<T>

## Deklarationsausdrücke auf `out`

Vorher:

~~~csharp
public void PrintCoordinates(Point p)
{
    int x, y; // have to "predeclare"
    p.GetCoordinates(out x, out y);
    WriteLine($"({x}, {y})");
}
~~~

Nacher:

~~~csharp
public void PrintCoordinates(Point p)
{
    p.GetCoordinates(out int x, out int y);
    WriteLine($"({x}, {y})");
}
~~~

## Syntax für Tuples

~~~csharp
public readonly (string firstName, string lastName) Names; // a tuple
~~~

## Typeswitch - Ausdrücke (Pattern Matching)

~~~csharp
switch(obj) {
  case 42:
    // ...
  case Color.Red:
    // ...
  case string s:
    // ...
  case Point(int x, 42) where (Y > 42):
    // ...
  case Point(490, 42): // fine
    // ...
  default:
    // ...
}

~~~

## lokal deklarierte Funktionen

~~~csharp
public int Fibonacci(int x)
{
    if (x < 0) throw new ArgumentException("Less negativity please!", nameof(x));
    return Fib(x).current;

    (int current, int previous) Fib(int i)
    {
        if (i == 0) return (1, 0);
        var (p, pp) = Fib(i - 1);
        return (p + pp, p);
    }
}
~~~
