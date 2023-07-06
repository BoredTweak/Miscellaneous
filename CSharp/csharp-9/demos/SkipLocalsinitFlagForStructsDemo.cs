namespace csharp_9
{
    internal class SkipLocalsinitFlagForStructsDemo
    {
        internal static void Run()
        {
            Console.WriteLine("Skip localsinit flag for structs");

            // C# 9.0 adds the ability to skip the localsinit flag for structs.
            // This can improve performance in some cases.
            // The localsinit flag is used to determine whether the runtime should zero-initialize local variables.

            // The following example shows a struct that contains a field that is not initialized.
            // The compiler emits code to zero-initialize the field before the constructor runs.
            // This is because the localsinit flag is set for structs.
            var structWithField = new StructWithField();
            Console.WriteLine($"StructWithField: {structWithField}");

            // The following example shows a struct that contains a field that is initialized.
            // The compiler emits code to initialize the field to the specified value before the constructor runs.
            // This is because the localsinit flag is set for structs.
            var structWithInitializedField = new StructWithInitializedField();
            Console.WriteLine($"StructWithInitializedField: {structWithInitializedField}");
        }
    }
}