using System;
using NUnit.Framework;
using Spare.Logger;

namespace Typen.Test {
  public static class ConvExt {
 
      public static TO Cast<T, TO>(this T some) {
        if (some is TO value) return value;
        return (TO) Convert.ChangeType(some, typeof(TO));
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
        1,
        2,
        3,
      };
      foreach (var x in candidates) {
        // (double) Convert.ChangeType(x, typeof(T))
        x.Cast<object, double>().ToString().Logger();
      }
    }
  }
}