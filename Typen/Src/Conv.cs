using System;

namespace Typen {
  public static class Conv {
    public static TO Cast<T, TO>(this T some) {
      if (some is TO value) return value;
      try { return (TO) Convert.ChangeType(some, typeof(T)); }
      catch (InvalidCastException) { return default(TO); }
    }

    public static string ToStr<T>(T some) {
      if (some is string str) return str;
      return some.ToString();
    }
  }
  
  
}