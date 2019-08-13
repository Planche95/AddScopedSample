using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApp1
{
    public class Bar
    {
        private readonly Foo _please;

        public Bar(Foo please)
        {
            _please = please;
        }
    }
}
