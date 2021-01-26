using System;
using System.Globalization;

// Variable to collect the Return value of the TryParse method.
// Define variable to collect out parameter of the TryParse method. If the conversion fails, the out parameter is zero.
// The TryParse method converts a string in a specified style and culture-specific format to its double-precision floating point number equivalent.
// The TryParse method does not generate an exception if the conversion fails. If the conversion passes, True is returned. If it does not, False is returned.

namespace Typen.Numeral {
  public static class Num {
    public static NumberFormatInfo Info = NumberFormatInfo.InvariantInfo;
    public static bool IsNumeric(this string t) => double.TryParse(t, NumberStyles.Any, Info, out _);
    public static bool IsNumeric(this object o) => Convert.ToString(o).IsNumeric();
  }
}