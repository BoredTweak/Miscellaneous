namespace csharp_9
{
    internal class BaseClass
    {
        internal virtual BaseClass SomeMethod()
        {
            return this;
        }

        public override string ToString()
        {
            return "BaseClass";
        }
    }

    internal class DerivedClass : BaseClass
    {
        internal override DerivedClass SomeMethod()
        {
            return this;
        }

        public override string ToString()
        {
            return "DerivedClass";
        }
    }
}