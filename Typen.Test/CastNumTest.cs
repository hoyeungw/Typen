using System;
using NUnit.Framework;
using Veho;

namespace Typen.Test {
  [TestFixture]
  public class CastNumTest {
    [Test]
    public void CastNumTestAlpha() {
      var candidates = Vec.From<object>(null, "0", "Infinity", ".5", "some", "", "-");
      foreach (var candidate in candidates) {
        // Conv.Cast<string, double>(candidate).Logger();
        // Typen.Numeral.CastDouble(candidate);
        Console.WriteLine($">> [{candidate}] {candidate.CastDouble()}");
      }
    }
  }
}