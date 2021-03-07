using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using Analys;
using NUnit.Framework;
using Veho.Matrix;

namespace Typen.Test {
  public static class ElPrimero {
    public static Crostab<double> Strategies<T>(
      int iteration,
      Dictionary<string, object[]> parameters,
      Dictionary<string, MethodInfo> methods
    ) {
      var crostab = Crostab<double>.Build(
        methods.Keys.ToArray(),
        parameters.Keys.ToArray(),
        (methods.Count, parameters.Count).Init<double>((i, j) => 0)
      );
      var eta = new Stopwatch();
      foreach (var m in methods)
        foreach (var p in parameters)
          try {
            crostab[m.Key, p.Key] =
              eta.Profile(m.Key + " " + p.Key, iteration, () => m.Value.Invoke(null, p.Value));
          }
          catch (Exception e) {
            crostab[m.Key, p.Key] = double.NaN;
          }
      return crostab;
    }
    public static double Profile(this Stopwatch eta, string description, int iterations, Action func) {
      //Run at highest priority to minimize fluctuations caused by other processes/threads
      Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
      Thread.CurrentThread.Priority = ThreadPriority.Highest;
      // warm up 
      func();
      // clean up
      GC.Collect();
      GC.WaitForPendingFinalizers();
      GC.Collect();
      eta.Restart();
      for (var i = 0; i < iterations; i++) func();
      eta.Stop();
      Console.WriteLine($"Elapsed {eta.Elapsed.TotalMilliseconds} ms: {description}");
      return eta.Elapsed.TotalMilliseconds;
    }
  }

  [TestFixture]
  public class ElPrimeroTest {
    [Test]
    public void TestFunc() {
      var x = (object) "5";
      // ElPrimero.Profile("some", (int) 1E+6, () => x.CastDouble());
    }
  }
}