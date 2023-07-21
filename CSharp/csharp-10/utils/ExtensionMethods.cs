using System.Runtime.CompilerServices;

namespace csharp_10;

internal static class ExtensionMethods
{
    internal static void ShouldBe<T>(this T @this, T expected, [CallerArgumentExpression("this")] string thisExpression = null) { }
}