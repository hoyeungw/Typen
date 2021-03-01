using System;

namespace Typen {
  public static class Conv {
    public static TO Cast<T, TO>(this T some) {
      if (some is TO value) return value;
      try { return (TO) Convert.ChangeType(some, typeof(TO)); }
      catch (InvalidCastException) { return default(TO); }
    }

    public static TO Cast<T, TO>(T some, TO def) {
      if (some is TO value) return value;
      try { return (TO) Convert.ChangeType(some, typeof(TO)); }
      catch (InvalidCastException) { return def; }
    }

    public static string ToStr<T>(T some) => some is string str ? str : some.ToString();
  }
}