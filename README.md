# Conventions
## PascalCase
Use pascal casing ("PascalCasing") when naming a `class`, `record`, or `struct`.

```csharp
public class DataService
{
}
```
## camelCase
Use camel casing ("camelCasing") when naming `private` or `internal` fields.

```csharp
public class Person
{
    // Fields
    private firstName; 
}
```
## Singular for class names
use singular for classes
```csharp
public class DataService
{
}

public class Person
{
}

public class Car
{
}
```


## Dont repeat yourself
Dont unnecessary use the same code

```csharp
for(counter=0 counter<=10 counter++){
    Console.Writeline(counter);
}
```

## Recognizeable names
Use variable and file names that are easily recognizeable.

```csharp
string name;
string age;
string dateOfBirth;
```