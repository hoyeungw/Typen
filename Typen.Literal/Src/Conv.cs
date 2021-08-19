namespace Typen {
  public static class Literal {
    public static string ToStr<T>(T some) => some is string str ? str : some?.ToString();
  }
}