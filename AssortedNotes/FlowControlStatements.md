# Flow Control Statements - Grammar

## If-Else

TBA

## Switch

TBA

## Do-While

```csharp
do
  statementOrStatementBlock
while(conditionalExpression);
```

**The key point to remember about the `do-while` statement is that the decision to repeat happens *after* the body of the loop. This means that the repeating logic occurs at least *once*.**

- `statementOrStatementBlock` is either a single C# statement, or a set of statements enclosed inside of a **statement block** `{  }`
- `conditionalExpression` is any expression involving variables, values, and arithmetic/relational/logical operations *as long as the final data type is a **boolean**.*

## While

```csharp
while(conditionalExpression)
  statementOrStatementBlock
```

**The key point to remember about the `while` statement is that the decision to repeat happens *before* the body of the loop. This means that the repeating logic occurs at least *zero times*.**

- `statementOrStatementBlock` is either a single C# statement, or a set of statements enclosed inside of a **statement block** `{  }`
- `conditionalExpression` is any expression involving variables, values, and arithmetic/relational/logical operations *as long as the final data type is a **boolean**.*

For example, imagine for the following program, the user entered the following series of numbers at each prompt: 5, 6, 7. The final answer of running the program would give a `total` of 18.

```csharp
// Imagine that this is inside a Main() method....
int total = 0;
int number;
int count = 0;
while(count < 3) // a true value will enter the loop
{
    Console.WriteLine("Enter a number to add (0 to stop): ");
    number = int.Parse(Console.ReadLine());	
    total += number; // Add the number onto the total
    count++;
}
Console.WriteLine("The total is " + total);
```

## For

```csharp
for(initialization;conditionalExpression;changeValues)
  statementOrStatementBlock
```

**The key point to remember about the `while` statement is that the decision to repeat happens *before* the body of the loop. This means that the repeating logic occurs at least *zero times*.**

- `initialization` is where you can initialize/set values for variable(s) that you want to use in your loop (typically, variables that you'll also use in the `conditionalExpression` and in the `changeValues` sections).
- `conditionalExpression` is any expression involving variables, values, and arithmetic/relational/logical operations *as long as the final data type is a **boolean**.*
- `changeValues` is where you can change the value of any variable(s) that you use in your `initialization` and/or `conditionalExpression`. For example, if you had a variable called `count`, you could increment it (`count++`) or decrement it (`count--`) or do some other change (`count += 3`)
- `statementOrStatementBlock` is either a single C# statement, or a set of statements enclosed inside of a **statement block** `{  }`

For example, imagine for the following program, the user entered the following series of numbers at each prompt: 5, 6, 7. The final answer of running the program would give a `total` of 18.

```csharp
// Imagine that this is inside a Main() method....
int total = 0;
int number;
for(int count = 0; count < 3; count++) // a true value will enter the loop
{
    Console.WriteLine("Enter a number to add (0 to stop): ");
    number = int.Parse(Console.ReadLine());	
    total += number; // Add the number onto the total
}
Console.WriteLine("The total is " + total);
```

## ForEach

