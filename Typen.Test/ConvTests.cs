using System;
using NUnit.Framework;
using Spare;

namespace Typen.Test {
  public static class ConvExt {
    public static TO Cast<T, TO>(this T some) {
      if (some is TO value) return value;
      return (TO)Convert.ChangeType(some, typeof(TO));
      // try {  }
      // catch (InvalidCastException) { return default(TO); }
    }

    public static string ToStr<T>(T some) => some is string str ? str : some.ToString();
  }


  [TestFixture]
  public class ConvTests {
    [Test]
    public void Test() {
      var candidates = new object[] {
                                      Math.PI,
                                      Math.E,
                                      true,
                                      false,
                                      "SOE",
                                      "",
                                      string.Empty,
                                      0xFF,
                                      double.NaN,
                                      DateTime.Now,
                                      null
                                    };
      var i = 0;
      foreach (var x in candidates) {
        var result = Conv.To<string>(x);
        Console.WriteLine($"[{i}] {result}");
        // try { Console.WriteLine($"[{i}] {Conv.To<string>(x)}"); }
        // catch (Exception e) { Console.WriteLine($"Error [{i}] [{e.HResult}] {e.Message}"); }
        i++;
      }
      (Conv.ToStr((object)null) ?? "null").Logger();
      // default(string).Logger();
    }
  }
}