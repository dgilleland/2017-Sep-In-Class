# Learning Outcome Guide Review

Learning Outcome Guides (LOGs) are an excellent tool for instructors in the classroom and for students when they are reviewing their notes for each class. A Learning Outcome Guide is simply a list of specific things that the student (or reader, in this case) should be able to do or understand as a result of learning the material. LOGs give the learner the ability to self-check their progress ("Can I do *X*?").

This appendix provides a shortened review of what each learning outcome is all about. For instructors, it provides a quick summary of the intent of the LOG. For students, it provides the answers. :)

## Topic A - Starting Classes

### OOP Basics
Define the term "class" as used in OOP
> A class is a template that acts as the basis for creating objects and describes a) What it "looks like", and b) How it "works". 

Explain the purpose of classes in computer programs
> Classes allow programmers to define their own complex data types, complete with their own internal data (fields) and behaviours (methods).

Describe the primary keywords used in declaring a class
> public/private - identifies whether the class is visible to other code; public means all other code can see this class, while private means 
> class - declares that this is a class definition (tells the compiler to interpret this as a new "classification" or "kind" of data type; that is, a complex ) 

Define the term "method" and give an example
> A method is a set of instructions that manipulate information. 

Create simple classes with methods only 
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Explain what is meant by "overloading"
> Overloading describes creating more than one method with the same method name (but different parameters) in the same class. Overloaded methods allow for alternate ways to perform the same general behaviour of an object or a class.

Describe the syntax of a method declaration (aka, method implementation)
> …

Explain how classes with identical names can be distinguished from each other 
> Different classes can have identical names provided that they exist in different namespaces. (Namespaces help to prevent a "collision" or confusion on the part of a compiler when confronted with two or more classes with the same name.)

### General Programming Concepts and Terms

Define the term "keyword" as it applies to programming languages
> A keyword is a special command or instruction that is part of (that is, built in to, or "intrinsic" to) a programming language. Keywords are "reserved" words, meaning that they cannot be used for other purposes, such as being a name of a class, a variable, or a method.

Define the term "identifier" as it applies to programming languages
> An identifier is a programmer-supplied name for some item, either a class name, a field or local variable, or a method.

Define the term "program statement" and identify how the computer recognizes a program statement
> A program statement is combination of keywords, identifiers, punctuation, and/or literal values that, together, represent a single "instruction" or "command" that a compiler can translate into executable code.

Define the term "syntax" as it applies to programming languages.
> Syntax refers to the rules of a programming language that define how to combine keywords, identifiers, literal values, and other symbols to create specific instructions for a computer program.

Identify the entry point for every computer program
> Every computer program must supply a method called "main" as the method that the operating system will call (execute) to begin running the program.

Perform simple output to the console using System.Console
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Identify the basic structure of a simple C# program
> A C# program must consist of at least one class and have a single "main" method as the program's entry point. Typically, a C# program will consist of a "driver" (the class that has the main method) and other classes used to represent objects (data) in the program.

Explain what is meant by a "driver"
> A "driver" is a method or set of methods that "run" or control the execution of a program; it's responsibility is to direct and maintain the "lifetime" of a program, and makes use of classes and objects to achieve the purpose of the program. Every driver begins its execution in a method called "main" (which is the name given for the entry point for every computer program).

Explain what is meant by a "case-sensitive" programming language
> A case-sensitive language is one  where the compiler regards "identical" words as different if they differ only in their case. In other words, a case-sensitive language will regard two identifiers are distinct if the only difference is whether they are spelled with upper- or lower-case characters. For example, HelloWorld and Helloworld will be regarded as different because one has a capital "W" and the other has a lower-case "w".

Explain what is meant by a "strongly-typed" programming language
> A "strongly-typed" programming language is one that requires all variables or objects to always match or conform to whatever data type they were originally declared as. Some programming languages (such as C#Script) allow variables or objects to "change" their data type whenever a programmer wishes to use it for other purposes; strongly-typed languages do not allow variables to "change" the type of data they can store. Strongly-typed programming languages provide better security and make it more difficult for programmers to inadvertently corrupt, mangle or expose important data.

Explain what "string concatenation" is and how it works
> String concatenation is where two or more strings are "combined" to create a longer string; this is represented in C# by "adding" strings together. For example, given two literal strings whose values are "One" and "word", the result of "One" + "word" would be the string "Oneword".

Define and distinguish the terms "argument" and "parameter"
> A parameter is a variable declared in the parameter list of a method declaration; parameters are used to hold or capture information (values) that are sent or passed into the method. An argument is some value (either a literal value, a value stored in a variable, or some other value that comes from an "expression") that is sent (passed) into a method; arguments appear in the syntax of method calls.

Use single-line, multi-line and XML comments as a means of documenting code
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

List the four pieces of information to include in comments at the top of every source file
> The file name, author, creation date, and purpose of the file.

### Intro to IDEs

Define the term "IDE" as it relates to software development tools
> The acronym "IDE" stands for "Integrated Development Environment". An IDE brings together separate,  but complementary, software development tools that aide developers in creating computer programs. For example, most IDEs bring a sophisticated text editor together with file management tools, a compiler, a debugger, and a program execution environment, as well as other useful tools.

Define the terms "project" and "solution"
> A solution is a folder in which one or more projects can be managed and "kept together"; it is the "area" in which a developer can create projects. A project is as set of classes designed to achieve a particular purpose; a project may represent a complete program in and of itself, or may be a single component of a larger, more complex computer program.

Identify the various parts of the IDE (Integrated Development Environment) used in this course
> [-- image here --]

Create a new project in the IDE for this course
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Create new source files in the IDE for this course
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Add existing files to a project
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

## Topic B - Starting Classes

### OOP Basics

Define the term "object" as used in OOP
> An object is an instance of a class.
> Each object has its own "state" (values) for its fields, and all objects based on any given class are distinct from each other. The internal values (state)for an object's fields can be changed independently of other objects of the same class.

Describe the syntax of static and non-static method declarations
> Static methods are "shared" by all instances (objects) of a class, and can be called without even having to have an instance of the method's class.
> Non-static methods, on the other hand, can only be called for a given object (instance of a class) and will "act on" (or "act on behalf of") that object (and any other objects are not affected by the given object's method call).

Compare and contrast the syntax for method declarations (implementations) vs. method calls (for both static and non-static methods)
> …

Define the term "field" as used in OOP and give an example
> A field is a variable that belongs to a class and is shared by all the methods of a class. 
  `private static int sharedCount; // a static field`
  `private String name; // an instance field`

Compare and contrast instance and class members, for both methods and fields
> Static methods are shared by all instances of a class, and can be called independently from instances of a class, whereas instance methods can only be called if you have an object (an instance of a class).
> Static fields are shared by and fully accessible to all methods, but non-static fields, also called "instance" fields, are only shared by other non-static methods. In the following example, the first field is a static fields and the second is an instance field.

Identify the "member access operator" and explain it's purpose
> The member access operator (also called the "dot" operator) is the period. It is used to access a field or method of an object or a class.

Create (instantiate) objects
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Distinguish between classes and objects in OOP
> A class is merely a "template" for creating objects and describes a) what the object will "look like" (that is, what fields or data it will contain) and b) how the object works (that is, what methods can be called and what those methods will do).

Explain what is meant by the phrase "type extensibility" and how classes represent "complex" data types in OOP
> "Type extensibility" is where a programming language allows developers to create or design their own "data types".
> All programming languages support the "simplistic" data types (for numeric information, such as whole and real numbers, as well as simple text or character representation). These simple data types are intrinsic ("build into") the programming language. A language that supports "type extensions" simply allows the programmer to create or design new data types; these new types are typically "complex" types made up of zero or more other (either simple or complex) data types.

### General Programming Concepts and Terms

List the three categories of simple information
> Textual, numeric, and conceptual

Define the term "intrinsic data type"
> An "intrinsic data type" is one that is built into the programming language.

Explain what an assignment statement is and how it works
> An assignment statement is an instruction to the computer to store a value into a specific variable (or object). The variable (or object) is placed on the left-hand side of the equals sign, and the value to be stored in the object is placed on the right-hand side of the equals sign.
> The left-hand side of an assignment statement must be a single variable, whereas the right-hand side can be any expression as long as the resulting value of the expression is the same (or compatible) data type as the variable on the left-hand side.

Compare and contrast the three categories of simple information with the complex types of information which classes represent
> Simple information is either textual (such as a name), numeric (such as a total or count), or "conceptual" (that is, representing a more "abstract" value that is neither textual or numeric). An example of a textual type in C# is the char type. An example of a numeric type in C# is the double type. An example of a "conceptual" type is the boolean type. A variable whose type is one of the simple types can only hold a single, simple value at any given time.
> Complex types of information can be constructed from many simple types or from simple and complex types. A "class" is used to describe or define what the complex type looks like and how it works.  Complex types are the basis for creating objects, and while any given "object variable" can only reference a single object, that object may consist of many distinct "values", each one being stored in a field that is "hidden" (or "encapsulated") inside the object.

Explain the advantages of using classes and objects instead of only using intrinsic data types
> By using objects, the programmer is no longer limited to having to only deal with simple values. By designing and using complex types (classes), the programmer is able to create complex programs using less code in a way that is simpler and more reliable than if the programmer were only allowed to use the simple types built into the programming language.

## Topic C - Starting Classes

### OOP Basics

Define the term "encapsulation" as used in OOP
> Encapsulation is a design principle of "hiding" fields in a class by always making them private and only allowing a "controlled access" to the values in fields by providing getters and setters.
> Encapsulation also includes the idea that all of the items (methods and fields) in a class always have access to each other (inside the class) while also providing the ability to control the external access to those items (methods and fields) by other classes.

Explain why encapsulation is a good design principle
> Encapsulation is a good design principle because every object must be responsible for its own data; if an object "exposes" its fields for direct access (that is, makes those fields public), then that object cannot exert any control over the values that may be stored in those fields.
> Encapsulation, as a part of Object Oriented design, also facilitates the aspect of "grouping together" related fields and methods.

Define the term "access specifier" and identify where it occurs in the code for a class
> An access specifier is a keyword in a programming language that identifies whether an item, such as a field or a method, is or is not accessible from outside of an object.

List the two access specifiers that are used in this course
> The two main access specifiers of this course are public and private.

Describe the difference between "private" and "public" members of a class
> Private methods and fields are not accessible from outside the class (they are only internally accessible). Public methods and fields are accessible both from outside and from inside the class.

Describe the concepts of "Properties" as used in OOP 
> "Properties" allow for controlled access to read (get) or change (set) fields in a class. When fields are used with properties, the field is sometimes called a "backing store" because it stores the actual value that is accessed through the property.
> Properties do not have to have fields as "backing stores"; a property can calculate its value (during a get) instead of simply retrieving it from a field. These types of properties are sometimes called "derived" properties.
> A "getter" is a method whose sole responsibility is to provide a means for retrieving (getting) a value. Getters are typically (that is, almost always) public, thereby allowing information (typically stored in a field) to be "extracted" from outside the class.
> A "setter" is a method whose sole responsibility is to control the storing of a value into a field of a class. Setters are typically (that is, almost always) public, thereby allowing code that is outside the class a way to store information inside the class (that is, inside of the fields of a class).

Define the term "backing store" as it applies to properties and fields
> A "backing store" is a field that stores information which is accessible only through a property; the field variable is used in the "background" by the property's get and/or set.

Describe and explain the purpose and function of a constructor for a class
> A constructor has one purpose: To ensure that all the fields of the class are filled with meaningful values at the moment that an object is created (instantiated).

Describe the syntax of a class constructor
> TBA…

Identify when a class constructor is "called"
> A class' constructor is never explicitly "called" in the traditional sense of "invoking" (calling) a method on a class. Rather, the class constructor is "called" when an object is instantiated using the new keyword.

Define the term "class scope" as used in OOP 
> Class scope is the idea that all of the methods and fields of a class are accessible to all the methods in a class.

Define the term "local scope" as used in OOP 
> Local scope is the idea that all of the variables declared in a parameter list and inside of the body of a method are only accessible from within that method. In other words, parameters and "local variables" are only accessible from within the method (or block of code) in which they were declared.

Define the term "state" as applied to objects used in OOP 
> "State" is the idea that objects have an "internal value" at any given point in time (as viewed from outside the class' methods). In other words, an object has "state" simply because it has fields which hold (or "store") information.
> Objects are responsible for ensuring that their internal state is always valid (or "stable") at the end of each method's execution.

Define the term "override" as used in OOP
> Override is a term used to indicate that a class is re-defining the behaviour of a method that it is inheriting from a base class.
> All classes inherit from a class called Object. The Object class defines common methods that every class must have, such as equals() and ToString(). Any class has the option to "override" or re-define how the equals() and ToString() methods work for that class.

Explain the purpose and function of the ToString() method and why we sometimes want to change its default behaviour when we create classes  
> The ToString() method is meant to provide a way to represent any given object as a String. This method is inherited from the Object class; the Object class, by default, returns the data type of the object, expressed as a String.
> A programmer may choose to override the default behaviour of the ToString() method in order to represent the internal state of the object (that is, the values stored in some select fields) as a String.

Create simple class diagrams to represent classes 
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

### General Programming Concepts and Terms

List three levels of scope 
> Class scope - All the fields and methods of a class share a common class scope, and are accessible to any and all methods of a class.
> Local scope - All the variables and parameters of a method are accessible only to the body of the method; local variables and parameters are not accessible to other methods.
> Block scope - All the variables declared inside a block are only accessible to the code inside that block. A block of code is denoted by being enclosed by a set of curly braces - { }.
 
## Topic D - Debugging and Testing

### General Programming Concepts and Terms

Explain the role of testing as it applies to software development 
> Testing is a form of "quality assurance" in which steps are taken to verify that a program is behaving or working as intended.
> Testing has traditionally been treated as a "follow-up" activity that takes place after a program is written. Currently, other approaches, such as TDD (Test-Driven Development) place the "testing" activity at the start of the programming efforts, thereby integrating tests as a driving element in software development.

Define and compare the terms "compile-time error" and "run-time error" 
> A "compile-time error" is an error where a program does not "compile". In other words, compile-time errors are due to code that does not follow the rules of the programming language.
> A "run-time error" is an error where a running program does not produce the desired result. In other words, run-time errors are due to logical errors in a computer program. Sometimes these errors are "fatal" (meaning that they result in "abnormal program termination" - the program "crashes"). Other times the errors are subtle; the subtle errors can be the most difficult to detect, particularly when relying on "manual" verification, such as found with ad-hoc test drivers.

Define the term "test driver" 
> A "test driver" is a driver (which is a program with a main method) whose sole purpose is to "test" the components of a program. Test drivers provide a simple "ad-hoc" form of testing. Test drivers are basically considered "throw-away" programs, as their usefulness does not extend beyond the tests.

Create simple ad-hoc test drivers to test for run-time errors 
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Define the term "TDD" 
> TDD refers to "Test Driven Development". Test Driven Development is an approach to programming that starts with creating "unit tests" that reflect the business and design requirements of a program, and then writing the classes and methods that will pass the unit tests. The idea here is to help drive the programmer toward code that "stays on focus" of the needs of and solutions for a given problem.

Compare and contrast Test Drivers and Unit Tests
> Test Drivers are small programs with a main() that tests classes by creating objects, calling methods, and output results to the console.
> Unit Tests are small "units" (which are simply methods)  that calls methods on objects and classes and "tests" if they work as intended by running "asserts". Unit Tests display the results of the test in Red/Green/Yellow results, where Red ( ) represents run-time errors, Yellow ( ) represents ignored tests, and Green ( ) represents success.

Define the terms "false positive" and "false negative" 
> A "false positive" is a test result that shows success for a test which in reality should be a failure.
> A "false negative" is a test result that shows failure for a test which in reality should be a success.
> Both false positives and false negatives are a result of an error in the unit test (or test driver).

List three downfalls of using Test Drivers 
> Can grow in size and become bulky & difficult to use (poor scalability) 
> Requires considerable effort to generate and distinguish tests 
> Difficult to verify tests due to heavy manual intervention & verification 

Identify four benefits of using Unit Tests 
> Provides simple tests to verify specific parts of a system 
> Easy to verify tests (minimal manual effort); errors are clearly identified and described 
  A clear graphical response it provided, leading to the popular development mantra "Keep it Green"
> Increases productivity (by focusing development efforts) 
> Captures design requirements in code 
> Increases programmer confidence when modifying and expanding code
> Easily isolate smaller parts ("units") of the program for verification; these tests can run independently of each other (even if the other tests have compiler issues with the classes being tested).

Add unit testing libraries and unit testing packages to existing programs 
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Use unit tests to validate the requirements of a class' design and behaviour
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Diagnose and correct software problems by using unit tests 
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.


## Topic E - Expressions and Math

### OOP Basics

Explain how method overloading is applied to constructors
> Using overloaded constructors means that it is possible to create objects in "different ways". What this means is that when a class has an overloaded constructor, anytime we wish to instantiate (create) an object using the new keyword, we must be explicit about which constructor we are invoking (calling).

### General Programming Concepts and Terms

Name at least three kinds of program statements commonly seen in all high-level programming languages
> Declaration/initialization statements
> Assignment statements
> Flow-control statements

Distinguish between Variables, Values and Data Types
> Variables act as "containers" for values, allowing programmers to access and manipulate the value via the variable.
> A Value is simply a piece of data. It may be simple (such as a number or some text), or it may be complex (that is, based on a class).
> Data Types are "blueprints" or "templates" that describe what values "look like" and how they "work".
> When a variable is declared to be of a certain data type, this means that the variable is only allowed to hold values that match that data type.

List the five basic rules governing variables, values and data types
> Any value stored in a variable must be of the same data type as the variable.
> Variables must be declared before they can be used.
> A variable's data type can only be declared once.
> Each primitive variable can only hold one value at a given time.
> Each variable must have a distinct name.

List the intrinsic (built-in) data types in C#
> Textual data types: char
> Numeric data types: int, long, short, byte, double, float
> Conceptual data types: bool

Explain what is meant by the phrase "type extensibility"
> Modern languages are able to define brand new data types (classes), thereby increasing the ability to manage complex information and perform complex operations.

Define the terms Reference Type and Value Type as they apply to data types in C#
> A "value type" is a data type whose information is stored "directly" in a variable. In memory, this means that there is only one direct location in memory where the data is stored. The only data types that are "value types" are those that are built into the language: char, int, byte, short, long, double, float, and bool.
  For example, in the following statements,
    `double count;`
    `count = 0;`
  the value of zero is stored directly at the memory location labelled count.
> A "reference type" is a data type whose information is stored and accessible only "indirectly" through the variable. Whenever you declare a "reference type" variable, that variable actually stores a memory address of where the "actual" object is stored. The "actual" object is only created using the new keyword; that new keyword will set aside a separate, "new", area of memory which is then accessed "indirectly" through the "reference type" variable.
  For example, in the following statements,
    `Car hotrod;`
    `hotrod = new Car();`
  the first line creates a single memory location, labelled hotrod, which will store the address to a Car object. The second line creates the actual Car object somewhere in memory and then the address to that object is stored in the hotrod variable.
  All classes, whether those supplied in the C# library (such as the String and Date classes) or those created by you, are "reference types". 

Define the term Identifier
> An identifier is the term used to refer to some "named" item in your code. Typically, we apply the term identifier to variable names, field names, property names and method names.

Create and initialize variables in C#
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Explain what is meant by the terms "scope" and "lifetime" as they apply to variables
> Scope refers to the "context" in which a variable is accessible. Fields are variables with "Class Scope", meaning that they are accessible to all the methods from within the class; properties, methods and constructors also have class scope. Parameters and variables declared within a method have "local scope", meaning that they can only be accessed by code from within the method that they are declared in.
> Lifetime refers to the period of time from when a variable is first declared to the time that they are "destroyed". For fields, their lifetime exists as long as the object in which they are declared. For parameters and local variables, they exist only as long as there is still code to be executed in the method to which they belong; as soon as the method "returns" or exits, these local variables and parameters are destroyed.

Describe what is meant by the term "expression"
> An expression is any combination of literal values (literal strings or numbers), variables, operators, or method calls which return a value. An expression can be as simple as a single variable or literal value, or it can be as complex as a long mathematical expression that involves calls to various methods.
> An important characteristic of expressions is to note that they are always reduced to a single value by the computer.

Explain the difference between program statements and expressions as well as how the two relate to each other
> A program statement represents a complete instruction that the compiler can translate into machine language. An analogy can be made that a program statement is like a sentence: Just as a sentence communicates a complete thought or idea, so a program statement represents a complete instruction.
> An expression is not a complete instruction; rather it is a combination of values, variables, method calls, and operators that will eventually be reduced to a single "value" by the computer. Expressions are often a part of program statements, and their role in program statements is akin to the role of phrases in English sentences: A phrase is not, by itself, a complete thought or idea; it must exist in a context in order to have its complete meaning. In a similar way, expressions play a part in the grammar of various kinds of program statements, providing a way of generating values that will be used by the program statement.

List the four general sets of operators in C#
> Assignment, Arithmetic, Relational, and Logical

Describe the two basic rules of using arithmetic operators that every compiler must follow.
> For an arithmetic operator to work, both sides of the operator must be the same data type.
> The resulting value of an arithmetic operation is of the same data type as the operands involved in the operation.

Use the arithmetic operators to create arithmetic expressions
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Explain what is meant by "integer division" and how that can be useful in solving particular problems regarding numbers.
> "Integer division" is the term for what occurs when both operands of a division operation are whole numbers (which can apply to byte, int, short, and long data types). Because the basic rule of arithmetic operations is that the data type of the final value of an operation is the same as that of the operands, any time we divide one whole number by another whole number, the result is a whole number: Any "fractional portion" is automatically discarded.
  For example,
  `1 / 3 -> 0`
  `7 / 2 -> 3`

Explain the purpose of the modulus (%) operator.
> The modulus operator (%) is used to find the remainder of a division operation. This operator is typically used with integers.

List and describe how to use the various assignment operators in C#
> All assignment operators require a variable on the left side and an expression on the right side. Assignment operators take the final value of the expression on the right and stores that value in the variable on the left.
> =
  This is the standard assignment operator. It performs a simple assignment of the value on the right to the variable on the left.
> +=
  This assignment operator takes the value on the right and adds it to the value already existing in the variable on the left. For example
  `x += y;`
  is the same as writing
  `x = x + y;`
> -=
  This assignment operator takes the value on the right and subtracts it from the value already existing in the variable on the left. For example
  `x -= y;`
  is the same as writing
  `x = x - y;`
> *=
  This assignment operator takes the value on the right and multiplies it to the value already existing in the variable on the left. For example
  `x *= y;`
  is the same as writing
  `x = x * y;`
> /=
  This assignment operator takes the value on the right and divides it into the value already existing in the variable on the left. For example
  `x /= y;`
  is the same as writing
  `x = x / y;`
> %/
  This assignment operator takes the value on the right and divides it into the value already existing in the variable on the left to generate the remainder. For example
  `x %= y;`
  is the same as writing
  `x = x % y;`

Explain the difference between binary and unary operators
> Binary operators require a variable or value on both sides of the operator.
> Unary operators only require a variable or value on one side of the operator for it to perform its operation.

Demonstrate understanding of operator precedence and how to override the default precedence of the arithmetic operators
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Summarize and distinguish the rules for automatic type conversion involving arithmetic operators and the assignment operator
> Automatic type conversion takes place for the data types that are built in to the programming language.
> The basic rule of automatic type conversion involving arithmetic operators is that if two operands of a binary operator are of different data types, then the value of the one that is "smaller" is "upsized" to the data type of the "larger" operand.
> For the assignment operators, automatic type conversion is limited to only allowing the right-hand value to be converted to the data type of the variable on the left-hand side. Type conversion cannot convert a value from the right hand side if that value's data type is larger than the data type of the left hand side; if the right hand side is a larger data type than the left hand side, then a compiler error is generated that states the value cannot "fit" into the variable on the left.

Determine the final data type for expressions involving mixed data types and type conversion
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Describe "type casting" and explain how to use it appropriately.
> Type casting is where we explicitly tell the compiler to "re-interpret" a particular value as a different data type than what the compiler is currently treating it as.
> Type casting is appropriate when we want to avoid integer division in order to retain the fractional portion in the final result. For example, if the variables numerator and denominator are both integers, it is appropriate to use type casting in the following line of code:
  `double value = (double) (numerator) / denominator;`
> It is also appropriate when we need to "downcast" a value from a larger data type to a smaller data type (and can do so safely).
> Note that type casting does not (and can not) change the data type of a variable; type casting is only a re-interpretation of a value.
> Note that type casting is not the same as converting. For example, any attempt to type cast the char value of the character ‘4' to an int will not produce a numeric value of 4; rather, it will produce the numeric value of 52 (which is the underlying decimal value for the character ‘4').

Compare and contrast the prefix and postfix behaviour of the unary arithmetic operators
> …

Identify and explain how to use the common Math library routines (for Power, Square Root, Absolute, random numbers, pi, trigonometry, and the various types of rounding)
> …

Use Math rounding methods with arithmetic expressions to round real numbers to a specific precision
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Create random whole number values within a specific range
> …

Use type casting appropriately in C#
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Create constants in C#
> Constants in C# are created using the keyword final and assigning the value to the constant at the time that it is declared. For example, to create a constant value for GST, you could code the following:
  `const double GST = 0.05; // 5% GST`

Explain how arithmetic operations affect character values in C#
> Because the char data type is regarded as one of the "integral" data types, along with int, short and long, any arithmetic operations on char values will manipulate the underlying value as if it were simply a whole number.
  (Note: "Integral" data types are data types without a fractional component.)

List the most common math functions of the Math class
> …

Demonstrate how to use the various Math functions in simple programs
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

List and describe some of the commonly used fields and methods of the String class
> .ToUpper() - returns a String that has all the characters converted to their upper-case equivalents.
> .ToLower() - returns a String that has all the characters converted to their lower-case equivalents.
> .Trim() - returns a String that has all leading and trailing whitespace removed from the original String.
> .Chars(int index) - returns the character at the index position for the string. (All strings have the first character as index position zero.)
> .Substring(int beginIndex) and .Substring(int beginIndex, int endIndex) - returns a string that is the text inside of the first string beginning at a specified index. (All strings have the first character as index position zero.)
> .Length - returns the total number of characters in the string.

Demonstrate how to use "String Arithmetic" (concatenation)
> To concatenate two or more strings, use the plus (+) operator.
> To append one string onto another, simply add the string to be appended to the end of the original string. For example, to append "ing" to the word "end" in order to produce "ending", you could do the following:
  `String myWord = "end";`
  `myWord = myWord + "ing"`
> To pre-pend one string on another, add the string to be prepended to the start of the original string. For example, to prepend "un" to the word "imaginative" so as to produce "unimaginative", you would do the following:
  `String myWord = "imaginative";`
  `myWord = "un" + myWord;`

List the equivalent "wrapper" classes for each of the primitive types.
> `Integer` for `int`
> `Character` for `char`
> `Double` for `double`
> `Byte` for `byte`
> `Long` for `long`
> `Short` for `short`
> `Float` for `float`


## Topic F - If-Else Structures

### General Programming Concepts and Terms

Describe and draw a diagram of the If-Then-Else logical structure
> ...

Identify the programming statement that corresponds to the If-Then-Else logical structure.
> The if-else statement is used for If-Then-Else logical structures in C#.

Translate If-Then-Else structures into code.
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Describe what is meant by a "conditional expression"
> A conditional expression is any expression which results in a Boolean (true/false) value.

List the operator precedence for mixing logical, arithmetic, and relational operations
> Logical Not (!), Arithmetic, Relational, Logical And/Or

List the relational operators
> >, >=, ==, <=, <
> Greater Than (>)
> Greater Than or Equal To (>=)
> Is Equal To (==)
> Less Than or Equal To (<=)
> Less Than (<)

List the logical operators
> &&, ||, !
> And (&&)
> Or (||)
> Not (!)

Use relational, logical, and arithmetic operators to construct conditional expressions
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Demonstrate an understanding of operator precedence in conditional expressions
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Use statement blocks to allow nesting program statements into control structures
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Define the term "boundary condition" as it relates to if-else statements and testing
> A "boundary condition" is also known as a "fence-post condition".
> The "boundary" is the border of a range of values that are regarded as "acceptable" for some variable. For example, if a particular variable named percent is to represent a range of values from zero through 100 inclusive, then the "boundary" values are zero and 100.
  A boundary condition, then, is a test or comparison that is made against some boundary values. For example,

```csharp
if(percent >= 0 && percent <= 100)
{
    // code to perform if true
}
else
{
    // code to perform if false
}
```

Identify the correct way to compare or check the contents of strings in conditional expressions
> The proper way to compare String values is to use the .Equals(), .CompareTo() and .IsNullOrEmpty() methods.
> Generally, the relational operators (==, <, etc) should not be used directly on string values.

List and describe the commonly used fields and methods of the String class that would be used in if-else statements
> .Equals(String) - returns a Boolean, true or false, as to whether the two strings are or are not equal.
> .Equals(String, StringComparison) - returns a Boolean, true or false, as to whether the two strings are or are not equal, according to the value of the StringComparison argument (which includes values to ignore any differences in upper and lower case).
> .CompareTo(String anotherString) - compares two strings "lexographically" (that is, alphabetically) and returns either
  a. a zero if they are the same, or 
  b. a negative number if anotherString is greater than the first string, or
  c. a positive number if anotherString is less than the first string
> .IsNullOrEmpty(string) - returns true if the string is an empty string (""), false if it is not an empty string.
> .IsNullOrWhiteSpace(string) - (only in .NET 4.0 and higher) returns true if the string is null, an empty string (""), or all "whitespace" (tab, newline) characters; false if it is not.
> .Length - returns the total number of characters in the string.

## Topic G - Raising Exceptions

### General Programming Concepts and Terms

Describe how object-oriented programs run.
> A computer program is a set of instructions for manipulating information.
> Every computer program has a single starting (or entry) point called the Main method. The main method is responsible to "run" (or "execute) the program, and when the main method exits, the program closes and stops "running". The length of time that a program is running is called its "lifetime". As a program runs, it executes instructions in the program's code, one at a time; this is called the "flow of execution".
> During the lifetime of a program, the main method creates objects and calls methods on those objects. Each method is basically a set of instructions to be executed. Those methods can, in turn, create other objects and call other methods.
> Whenever a method is called, the operating system keeps track of which method is calling another method through something known as a "call stack".

Describe what is meant by a "call stack".
> A call stack is a mechanism to track which method is calling another method while the program is running. Call stacks allow the computer to know where to "return to" when a method exits.
> At any given point during the program's execution, the method that is currently executing is referred to as the "called method". When the called method exits, it returns control back to the "calling method", thereby allowing the calling method to continue its own execution.
> Whenever a method calls another method, the "calling method" pauses and waits for the "called method" to finish; once the called method returns, the calling method will resume executing its own code.

Define the term "Exception"
> An exception is a message of some run-time error that has occurred in a program. Exceptions interrupt the normal flow of execution in methods, forcing the method to immediately exit. Methods generate exceptions by using the "throw" statement. Any method may generate an exception (including constructors).
> The throw statement exits the method by sending back an object (called an "Exception Object", or simply an "Exception") that can be used to identify the kind of error that has occurred. The calling method then has the opportunity to deal with (or "handle") the error; if the calling method does not handle the error, then the exception continues to go back through the call stack until it finds a method that will handle the exception.
> If none of the methods on the call stack handle the exception that was thrown, control is eventually returned to the main method. If the main method does not handle the exception, then the exception is sent to the operating system. At that point, the operating system shuts down the program in what is called an "abnormal program termination".

Describe what is meant by the phrase "raising (or throwing) an exception"
> To "raise an exception" (or "throw an exception") is to force a method to exit prematurely by sending back an "Exception object".

Describe the role that exceptions play in a computer program
> An exception is an interruption in the normal flow of execution in a method; exceptions force the method to immediately exit. 
> Exceptions provide a way for methods (including constructors) to report errors to whatever code that is calling the method. These errors are usually (but not always) due to invalid information passed into the methods via the parameters. Through the use of exceptions, methods can perform validation on their parameters and report any errors that might prevent the method from being able to perform its task.

Identify the three most commonly used Exception types used in this course.
> .NET Framework
  **ArgumentException** - Typically thrown whenever an argument passed to a parameter does not have an "acceptable" value.
For example, if a method has a parameter called "percent", it might perform validation to ensure that the value is not less than zero or greater than 100. If the value is not valid, it may be appropriate to throw an ArgumentException.
  **ArgumentNullException** - Typically thrown whenever an object is checked for and found to be "null". 
(ArgumentNullException will be discussed in the topic on Enumerations and Composition.)
  *Exception** - This represents a general exception, and can be used whenever there is no other suitable exception type.

### OOP Basics

Explain why methods (including constructors) should perform validation of their parameter values
> One of the principles of object-oriented design is that objects must be responsible for ensuring that their fields have correct values. This is known as ensuring a "valid state" for an object.
> Typically, the values that are stored in fields come in through the parameters of a constructor or a method. Because objects are responsible for ensuring a valid state, the class' methods must check all parameters that might allow "invalid" data to be passed in.

Explain the significance of raising an exception in the constructor
> If an exception is thrown from a constructor (or passes through it on its way up the call stack), the object's construction is interrupted. Because the construction of that object is interrupted, the object does not get instantiated.

Use exceptions as part of the validation of parameter values in methods and constructors.
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Explain why property setters are a good place for throwing exceptions.
> Generally speaking, the only method that should directly modify a field is the property setter associated with the field. Because of this principle, the property setter is the ideal place to perform validation and to throw exceptions. When validation takes place here, it eliminates the need for duplicating the validation elsewhere in the class.
> Validating input and throwing exceptions from within setters is a good way to follow the ***DRY*** principle: "**D**on't **R**epeat **Y**ourself".

Identify when constructors should throw exceptions directly.
> Whenever a field has a property setter that performs validation, the constructor should use that setter to store information in the field. If no property setter is available to process the parameter values sent through the constructor, then the constructor should perform its own validation on those parameters.

## Topic H - Case Structures

#### General Programming Concepts and Terms

Describe the syntax of the switch statement
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

Discuss the limitations of the switch statement in C# and the available alternatives for the times that we can't use a switch statement
> Switch statements only work with integral data types (such as char and int).
> The individual case values must be constants; variable expressions are not allowed for the matching cases.
> Switch statements only check for exact matches (meaning that there is an implied "is-equal-to" comparison); other relational comparisons, such as greater than or less than, are not allowed.
> When it is not possible to use switch statements, case structures can be written up as nested and/or stacked if-else structures to make use of the if-else statement.

## Topic I Enumerations and Composition

### General Programming Concepts and Terms

Define the term Enumeration
> An enumeration is a simple program-defined data type with a limited set of possible values. Enumerations represent information that is "conceptual" in nature (as opposed to information that is textual, numeric, or complex).
  For example, a coin has two sides that are commonly referred to as HEADS and TAILS. Rather than creating two constant strings with the values "Heads" and "Tails" and a String variable called FaceShowing, you can use an enumeration.
> There are two parts to enumerations:
  a. The name of the enumeration, which is the name of the new data type; this is sometimes referred to as the "enumerated data type".
  b. A set of enumerated values, which represent all of the possible values for a variable of that enumerated type. These values act like "constants" that can be used to distinguish different "states" for the conceptual data.

List the benefits of using enumerations
> **Type Safety** - Enumerations allow a program to be "type safe", meaning that there is less likelihood of creating logical errors or other mistakes through the use of constants or literal values.
> **Code Readability** - Enumerations make code more readable than constants or literal values (like integers).
> **Compatibility with Switch Statements** - Enumerations are compatible with switch statements, making them a great option for describing distinct values for matching against different cases. Because enumerations are like constants, and are treated as integral data types by the compiler, they are often the best choice when working with case structures.
> **Useful as Flags** - Because the programmer can associate specific integer values to the enumerated values, it is possible to use an enumerated data type to create complex "flags" for representing distinct "states" that can be combined together.
  For example, if you had an enumerated type such as the following, you could combine two states together in a variable's value to represent distinct but compatible states, such as `ACTIVE` and `MEDIUM_PRIORITY`.

```csharp
enum Status
{
    INACTIVE = 0
    ACTIVE = 1
    LOW_PRIORITY = 2
    MEDIUM_PRIORITY = 4
    HIGH_PRIORITY = 8
}
```

Describe where and when enumerations are used
> Enumerations are used wherever a clearly defined set of values can be "classified" and used to represent conceptual information.
> Enumerations should be used whenever you might be inclined to use a set of two or more constants to represent distinct "states" or values for comparing against a variable.

  For example, if you want to represent the two sides of a coin, it is better to use an enumeration for the coin's HEADS and TAILS sides, rather than declaring some String or integer constants. The problem with using strings or simple integers to represent possible coin faces is that any variable that is defined as a string or integer can have values that won't match either of the declared constants, as in this example:

  ```csharp
  const string Heads = "Heads";
  const string Tails = "Tails";
  // There is nothing preventing "invalid" values for the following coin face...
  string theFaceShowingOnTheCoin = "Sailboat";
  ```

  An enumerated type called `CoinFace` with the values `HEADS` and `TAILS` is better, because any variable declared of type `CoinFace` can only have the values defined in the enumeration.

  ```csharp
  // The only other possible value that could be assigned is
  // CoinFace.TAILS
  CoinFace theFaceShowingOnTheCoin = CoinFace.HEADS;
  ``

Compare and contrast enumerations and classes
> Enumerations and classes both define new data types that can be used by our program to represent custom data. However, while classes are useful in describing complex data types (that is, data types with assorted fields and that can perform various tasks), enumerations are only used to create new data types that are simple in nature. Enumerations only define a set of possible values, and each variable defined by an enumeration can only hold one of those possible values at any given time; there is no inner complexity to enumerations, as there is with classes.

Use enumerations to define simple data types that are conceptual in nature and that have a limited set of possible "values"
> Demonstrate your ability to meet this learning outcome guide by completing the related assignments.

### OOP Basics

Describe the idea of Composition
> Composition refers to the situation where one or more of the fields in a class are objects. All classes are capable of having objects as fields, rather than just using the simple primitive types that come with the language.
  For example, if a class called Address represents some mailing address, another class, such as Student, Company, School, or Business, could have a field whose data type is Address.

List the benefits of Composition
> Composition is an aspect of modern programming languages that makes it possible to create new data types (classes) of ever increasing complexity.
> Composition also makes it possible to get better code re-use, because classes can be more distinct, rather than overlapping. For example, both Students and Employees can have Addresses, so it is not necessary to code individual fields in the Student and Employee class for each part of an address; rather, a common type (called Address) can be shared by both classes.

  ```csharp
  public class Employee {
      // ... other fields, followed by these Address fields:
      public string street { get; set; }
      public string city { get; set; }
      public string province { get; set; }
      // ... etc.
  }

  public class Student {
      // ... other fields, followed by these Address fields:
      public string street { get; set; }
      public string city { get; set; }
      public string province { get; set; }
      // ... etc.
  }
  ```

  These could be coded like this:

  ```csharp
  public class Employee {
      // ... other fields, followed by these Address fields:
      public Address mailingAddress { get; set; }
  }

  class Student {
      // ... other fields, followed by these Address fields:
      public Address homeAddress { get; set; }
  }
  ```

  : *advanced benefit* - Composition promotes the "Has-A" approach to designing objects rather than the "Is-A" design approach that makes use of inheritance. This "Has-A" approach gives programmers more flexibility in their coding and promotes the use of Design Patterns.

## Topic J - Looping Structures

### General Programming Concepts and Terms

Identify the C# statements that correspond to Do-While and Do-Until logical structures
> TBA

Translate Do-While structures into code
> TBA

Translate Do-Until structures into code
> TBA

Identify and distinguish the parts of the for statement in code
> TBA

Describe the common situations in which the for statement is used
> TBA

Demonstrate how the various looping statements can be interchanged with slight alterations of the logical structures to maintain the overall logic of a given routine.
> TBA

## Topic K - Looping and Collections

### OOP Basics

Define the term Generics as used in C# and give an example
> TBA

### General Programming Concepts and Terms

Describe what is meant by a "collection" class and give an example
> TBA

List and describe the common methods of collection classes such as the List<T>
> TBA

Identify the parts of the foreach statement
> TBA

Describe the common situations in which the foreach statement is typically used
> TBA

Identify the major benefit of using Generics
> Type Safety –

List the major benefits of using collections instead of arrays
> Collections such as List<T> can grow in capacity whenever items are added
> Collections such as List<T> do not need special management of the boundaries (such as the index of the upper limit of an array)
> Collections provide simple methods for quick adding and removing of "elements"

## Topic L - Arrays - Not Sorted

### General Programming Concepts and Terms

Describe what makes an array different from other collections in C#
> The programmer is responsible to manage the boundaries of the array when manipulating the array’s contents.
> Arrays do not automatically “re-size” when “adding” or “removing” elements; the size of the array is fixed at the time the array is created.

Describe the situations in which arrays are preferable over the use of collections
> Arrays are preferred whenever multi-dimensional data is required (such as 2D, 3D, or n-dimensional data is needed)
> Arrays are sometimes preferred whenever the size (number of elements) is unlikely to change and/or whenever the array is based on a primitive data type or an enumeration.

