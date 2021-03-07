namespace Typen.Literal {
  public static class Conv {
    public static string ToStr<T>(T some) => some is string str ? str : some?.ToString();
  }
}