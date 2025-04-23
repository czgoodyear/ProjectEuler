using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Core
{
    public abstract class EulerProblemBase : IEulerProblem
    {
        public abstract int Number { get; }
        public abstract string Title { get; }
        public abstract string Solve();

        private string? _fullProblemText;
        public string FullProblemText =>
            _fullProblemText ??= LoadStatementFromMd();

        private string LoadStatementFromMd()
        {
            // At runtime, the .md file will be next to the assembly
            var folder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
            var file = Path.Combine(folder, "Problems", $"Problem{Number:D3}.md");
            if (!File.Exists(file))
                throw new FileNotFoundException($"Problem text not found: {file}");
            return File.ReadAllText(file);
        }
    }
}
