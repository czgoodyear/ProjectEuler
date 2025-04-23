using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Core
{
    public interface IEulerProblem
    {
        int Number { get; }
        string Title { get; }
        string FullProblemText { get; }
        string Solve();
    }
}
