using System.Runtime.CompilerServices;

namespace csharp_9
{
    // C# 9.0 adds the ability to skip the localsinit flag for structs.
    // This can improve performance in some cases.
    // The localsinit flag is used to determine whether the runtime should zero-initialize local variables.
    // Note that this will only compile if the unsafe flag is set.
    // [SkipLocalsInit]
    internal struct StructWithFieldInitSkip
    {
        internal int field;
    }
}