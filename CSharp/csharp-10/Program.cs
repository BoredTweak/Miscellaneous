// Demonstration of C# 10 features

global using static System.Math;

using csharp_10;

Console.WriteLine("C# 10 Demonstration");

// Demonstrate Record Structs

RecordStructDemo.Run();

// Demonstrate Parameterless struct constructors

ParameterlessStructConstructorDemo.Run();

// Demonstrate Global Usings

GlobalUsingsDemo.Run();

// Demonstrate File Scoped Namespaces

csharp_10.FileScopedNamespacesDemo.Run();

// Demonstrate Extended Property Patterns

ExtendedPropertyPatternsDemo.Run();

// Demonstrate Interpolated String Improvements

InterpolatedStringImprovementsDemo.Run();

// Demonstrate Lambda Improvements

LambdaImprovementsDemo.Run();

// Demonstrate Caller Argument Expressions

CallerArgumentExpressionDemo.Run();
