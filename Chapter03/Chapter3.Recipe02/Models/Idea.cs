using System;


namespace Chapter3.Recipe02
{
    /// <summary>
    /// Summary description for Idea
    /// </summary>
    public class Idea
    {

        public string IHaveOptionalArguments([NotNull] string foo, string foo2, string foo3)
        {
            return null;
        }

        public void testIHaveOptionalArgument()
        {
            var foo = IHaveOptionalArguments("foo", "foo", "foo");
        }
    }
}