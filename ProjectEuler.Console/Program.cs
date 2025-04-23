using ProjectEuler.Core;

// ——————————————————————————————
//  Entry-point
// ——————————————————————————————

// Discover all IEulerProblem implementations once
var problems = DiscoverProblems();

// Print header and available problems
Console.WriteLine("Project Euler Runner");
Console.WriteLine("=====================\n");
foreach (var p in problems)
    Console.WriteLine($"{p.Number:000}: {p.Title}");

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Enter problem number to solve,");
    Console.WriteLine("or 'i<number>' to view statement,");
    Console.WriteLine("or leave blank to solve all,");
    Console.WriteLine("or '0' to exit:");
    Console.Write("> ");

    var input = Console.ReadLine()?.Trim();

    if (string.Equals(input, "0", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Goodbye!");
        break;
    }
    else if (string.IsNullOrEmpty(input))
    {
        SolveAll(problems);
    }
    else if (input.StartsWith("i", StringComparison.OrdinalIgnoreCase)
             && int.TryParse(input.Substring(1), out int infoNum))
    {
        ShowInfo(problems, infoNum);
    }
    else if (int.TryParse(input, out int runNum))
    {
        SolveSingle(problems, runNum);
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again.");
    }
}

//
// Local helper functions
//

List<IEulerProblem> DiscoverProblems()
    => AppDomain.CurrentDomain
          .GetAssemblies()
          .SelectMany(a =>
          {
              try { return a.GetTypes(); }
              catch { return Array.Empty<Type>(); }
          })
          .Where(t => typeof(IEulerProblem).IsAssignableFrom(t)
                      && !t.IsInterface && !t.IsAbstract)
          .Select(t => Activator.CreateInstance(t) as IEulerProblem)
          .Where(p => p is not null)
          .OrderBy(p => p!.Number)
          .Cast<IEulerProblem>()
          .ToList();

void SolveAll(IEnumerable<IEulerProblem> probs)
{
    foreach (var p in probs)
    {
        Console.WriteLine($"\n--- Problem {p.Number:000}: {p.Title} ---");
        Console.WriteLine($"Answer: {p.Solve()}");
    }
}

void SolveSingle(IEnumerable<IEulerProblem> probs, int number)
{
    var p = probs.FirstOrDefault(x => x.Number == number);
    if (p != null)
    {
        Console.WriteLine($"\n--- Problem {p.Number:000}: {p.Title} ---");
        Console.WriteLine($"Answer: {p.Solve()}");
    }
    else
    {
        Console.WriteLine($"Problem {number} not found.");
    }
}

void ShowInfo(IEnumerable<IEulerProblem> probs, int number)
{
    var p = probs.FirstOrDefault(x => x.Number == number);
    if (p != null)
    {
        Console.WriteLine($"\n--- Problem {p.Number:000}: {p.Title} ---\n");
        Console.WriteLine(p.FullProblemText);
    }
    else
    {
        Console.WriteLine($"Problem {number} not found.");
    }
}
