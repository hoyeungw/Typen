using System;

namespace Typen {
  public static class EnumConv<TEnum> {
    /// <summary>
    /// 字符串转换为Enum
    /// </summary>
    /// <returns></returns>
    public static string[] Names => Enum.GetNames(typeof(TEnum));
    public static int[] Values {
      get {
        // return Array.ConvertAll(Enum.GetValues(typeof(TEnum)), x => (int) x);

        // var array = Enum.GetValues(typeof(TEnum));
        // var vector = new int[array.Length];
        // array.CopyTo(vector, 0);
        // return vector;

        return (int[]) Enum.GetValues(typeof(TEnum));
        typeof(TEnum).GetEnumValues();
      }
    }
    public static string ToText(TEnum item) => Enum.GetName(typeof(TEnum), item);
  }

  public abstract class EnumExt {
    public static string ToText<TEnum>(TEnum item) => Enum.GetName(typeof(TEnum), item);
  }
}