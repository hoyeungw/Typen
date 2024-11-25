using System;

namespace Typen {
  public static class Conv {
    public static T To<T>(object value) => value is T d ? d : default;

    public static T To<T>(object value, T def) => value is T d ? d : def;

    public static TV To<T, TV>(T value) => value is TV d ? d : default;

    public static TV To<T, TV>(T value, TV def) => value is TV d ? d : def;

    public static TO Cast<T, TO>(this T some) {
      if (some is TO value) return value;
      try { return (TO)Convert.ChangeType(some, typeof(TO)); }
      catch (InvalidCastException) { return default; }
    }
    public static TO Cast<T, TO>(T some, TO def) {
      if (some is TO value) return value;
      try { return (TO)Convert.ChangeType(some, typeof(TO)); }
      catch (InvalidCastException) { return def; }
    }
    public static string ToStr<T>(T some) => some is string str ? str : some?.ToString();
  }
}