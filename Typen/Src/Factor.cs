using System;

namespace Typen {
  public static class Factor<TEnum> {
    /// <summary>
    /// 字符串转换为Enum
    /// </summary>
    /// <returns></returns>
    public static string[] Names => Enum.GetNames(typeof(TEnum));

    // return Array.ConvertAll(Enum.GetValues(typeof(TEnum)), x => (int) x);

    // var array = Enum.GetValues(typeof(TEnum));
    // var vector = new int[array.Length];
    // array.CopyTo(vector, 0);
    // return vector;

    // typeof(TEnum).GetEnumValues();
    public static Array Values => Enum.GetValues(typeof(TEnum));
    public static int[] IntValues => (int[]) Enum.GetValues(typeof(TEnum));
    public static string Label(TEnum item) => Enum.GetName(typeof(TEnum), item);
    
  }

  public static class Factor {
    public static string Label<TEnum>(TEnum item) => Enum.GetName(typeof(TEnum), item);

    public static TEnum ParseEnum<TEnum>(this string text) {
      text = text.Replace(" ", "");
      // return Operator.Convert<dynamic, TEnum>(Enum.Parse(typeof(TEnum), text, true));
      return (TEnum) Enum.Parse(typeof(TEnum), text, true);
    }
  }
}