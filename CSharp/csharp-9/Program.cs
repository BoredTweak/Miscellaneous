using csharp_9;

// Demonstration of the various C# 9 features
// See more at https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9

Console.WriteLine("-------");

// Records

RecordDemo.Run();

Console.WriteLine("-------");

// Init-only properties

InitOnlyDemo.Run();

Console.WriteLine("-------");

// Top-level statements

Console.WriteLine("Top-level statements");
Console.WriteLine("Hello, World!");
Console.WriteLine("This is a top-level statement written in Program.cs.");

Console.WriteLine("-------");

// Pattern matching enhancements

PatternMatchingDemo.Run();

Console.WriteLine("-------");

// Target-typed new expressions

TargetTypedNewDemo.Run();

Console.WriteLine("-------");

// Lambda discard parameters

LambdaDiscardParametersDemo.Run();

Console.WriteLine("-------");

// Native sized integers

NativeSizedIntegersDemo.Run();

Console.WriteLine("-------");

// Function pointers

FunctionPointersDemo.Run();

Console.WriteLine("-------");

// Attributes on local functions

AttributesOnLocalFunctionsDemo.Run();

Console.WriteLine("-------");

// Module initializers

ModuleInitializersDemo.Run();

Console.WriteLine("-------");

// Skip localsinit flag for structs

SkipLocalsinitFlagForStructsDemo.Run();

Console.WriteLine("-------");

// Covariant return types

CovariantReturnTypesDemo.Run();

Console.WriteLine("-------");

// Extension GetEnumerator support for foreach loops

ExtensionGetEnumeratorSupportForForeachLoopsDemo.Run();

Console.WriteLine("-------");
