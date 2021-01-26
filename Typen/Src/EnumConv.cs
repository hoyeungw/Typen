// using System;
//
// namespace Typen {
//   public static class EnumConv<TEnum> {
//     /// <summary>
//     /// 字符串转换为Enum
//     /// </summary>
//     /// <returns></returns>
//     public static string[] Names => Enum.GetNames(typeof(TEnum));
//     public static int[] Values {
//       get {
//         var oAr = Enum.GetValues(typeof(TEnum));
//         var tAr = new int[oAr.GetLength(0)];
//         oAr.CopyTo(tAr, 0);
//         return tAr;
//       }
//     }
//     public static string ToText(TEnum enumItem) {
//       var τ = Enum.GetName(typeof(TEnum), enumItem);
//       τ = τ.Leakage();
//       return τ;
//     }
//   }
//
//   public abstract class EnumExt {
//     public static string ToText<TEnum>(TEnum enumItem) {
//       var τ = Enum.GetName(typeof(TEnum), enumItem);
//       τ = τ.Leakage();
//       return τ;
//     }
//   }
// }