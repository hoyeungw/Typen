using System;
using NUnit.Framework;
using Spare.Deco;

namespace Typen.Test {
  public enum Wings {
    None = 0,
    Left = 1,
    Right = 2,
    Dual = 3,
  }

  public class FactorTests {
    [SetUp]
    public void Setup() { }

    [Test]
    public void EnumConvTest() {
      Console.WriteLine(Enum<Wings>.IntValues.Deco());
      Console.WriteLine(Enum<Wings>.Label(Wings.Right));
      Console.WriteLine(Enum<Wings>.Label(Wings.Right));
      Console.WriteLine("Right".ToEnum<Wings>());
      Assert.Pass();
    }
  }
}