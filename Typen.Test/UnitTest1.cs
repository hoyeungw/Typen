using NUnit.Framework;

namespace Typen.Test {
  public enum Wings {
    None = 0,
    Left = 1,
    Right = 2,
    Dual = 3,
  }

  public class Tests {
    [SetUp]
    public void Setup() { }

    [Test]
    public void Test1() {
      Assert.Pass();
    }
  }
}