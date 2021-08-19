using System;
using System.Globalization;

// Variable to collect the Return value of the TryParse method.
// Define variable to collect out parameter of the TryParse method. If the conversion fails, the out parameter is zero.
// The TryParse method converts a string in a specified style and culture-specific format to its double-precision floating point number equivalent.
// The TryParse method does not generate an exception if the conversion fails. If the conversion passes, True is returned. If it does not, False is returned.

namespace Typen {
  public static class Numeral {
    public static NumberFormatInfo Info = NumberFormatInfo.InvariantInfo;
    public static bool IsNumeric(this string t) => double.TryParse(t, NumberStyles.Any, Info, out _);
    public static bool IsNumeric<T>(this T o) {
      if (o == null || o is DateTime) return false;
      if (o is sbyte || o is short || o is int || o is long ||
          o is decimal || o is float || o is double || o is bool ||
          o is byte || o is ushort || o is uint || o is ulong) return true;
      if (o is string s) return s.IsNumeric();
      return o.ToString().IsNumeric(); // Convert.ToString(o).IsNumeric()
    }

    public static double CastDouble<T>(this T o) {
      if (o == null) return double.NaN;
      switch (o) {
        case double n: return n;
        case string s: return s.CastDouble();
        case bool n: return n ? 1 : 0;
        case int n: return n;
        case long n: return n;
        case decimal n: return (double)n;
        case float n: return n;
        case byte n: return n;
        // case sbyte n: return n;
        // case short n: return n;
        // case ushort n: return n;
        // case uint n: return n;
        // case ulong n: return n;
        // case char n: return n;
        default: return o.ToString().CastDouble();
      }
    }

    public static double CastDouble(this string t) => double.TryParse(t, out var n) ? n : double.NaN;
    public static float CastFloat(this string t) => float.TryParse(t, out var n) ? n : float.NaN;
  }
}