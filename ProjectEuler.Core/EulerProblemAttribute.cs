using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Core
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public sealed class EulerProblemAttribute : Attribute
    {
        public EulerProblemAttribute(int number, string title)
        {
            Number = number;
            Title = title;
        }
        public int Number { get; }
        public string Title { get; }
    }
}
