using System;
using static System.Enum;

namespace Typen {
  public static class Enum<TEnum> {
    public static string[] Names => GetNames(typeof(TEnum));
    public static Array Values => GetValues(typeof(TEnum));
    public static int[] IntValues => (int[]) GetValues(typeof(TEnum));
    public static string Label(TEnum item) => GetName(typeof(TEnum), item);
  }

  public static class Enum {
    public static string Label<TEnum>(this TEnum item) => GetName(typeof(TEnum), item);
    public static TEnum ToEnum<TEnum>(this string text) => (TEnum) Parse(
      typeof(TEnum),
      text.Replace(" ", ""),
      true
    );
  }
}