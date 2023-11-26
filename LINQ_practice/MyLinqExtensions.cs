using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_practice
{
    public static class MyLinqExtensions
    {
        public static int Penultimate(this IEnumerable<int> source)
        {
            return source.Reverse().Skip(1).FirstOrDefault();
        }
    }
}
