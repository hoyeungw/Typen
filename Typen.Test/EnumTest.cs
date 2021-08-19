using System;
using NUnit.Framework;
using Spare;

namespace Typen.Test {
  public enum Wings2 {
    None = 0,
    Left = 1,
    Right = 2,
    Dual = 3,
  }

  public class EnumTests {
    [SetUp]
    public void Setup() { }

    [Test]
    public void EnumConvTest() {
      Console.WriteLine(Enum<Wings2>.IntValues.Deco());
      Console.WriteLine(Enum<Wings2>.Label(Wings2.Right));
      Console.WriteLine(Enum<Wings2>.Label(Wings2.Right));
      Console.WriteLine("Right".ToEnum<Wings2>());
      Assert.Pass();
    }
  }
}