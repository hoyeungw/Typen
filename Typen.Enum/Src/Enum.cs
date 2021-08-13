using System;

namespace Typen {
  public static class Enum<TEnum> {
    public static string[] Names => System.Enum.GetNames(typeof(TEnum));
    public static Array Values => System.Enum.GetValues(typeof(TEnum));
    public static int[] IntValues => (int[]) System.Enum.GetValues(typeof(TEnum));
    public static string Label(TEnum item) => System.Enum.GetName(typeof(TEnum), item);
  }

  public static class Enum {
    public static string Label<TEnum>(TEnum item) => System.Enum.GetName(typeof(TEnum), item);
    public static TEnum ToEnum<TEnum>(this string text) => (TEnum) System.Enum.Parse(
      typeof(TEnum),
      text.Replace(" ", ""),
      true
    );
  }
}