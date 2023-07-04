using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IComparer<T>
    {
        int Compare(T x, T y);
    }
}
