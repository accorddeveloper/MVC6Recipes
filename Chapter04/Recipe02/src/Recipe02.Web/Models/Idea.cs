using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe02.Web.Models
{
    public class Idea
    {
        public string IHaveOptionalArguments(string foo, string foo2, string foo3)
        {
            return null;
        }

        public void testIHaveOptionalArgument()
        {
            var foo = IHaveOptionalArguments("foo", "foo", "foo");
        }
    }
}
