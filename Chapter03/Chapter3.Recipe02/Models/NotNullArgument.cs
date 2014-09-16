using System;

namespace Chapter3.Recipe02
{
    /// <summary>
    /// Summary description for NotNullArgument
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    internal sealed class NotNullAttribute : Attribute
    {
    }
}

