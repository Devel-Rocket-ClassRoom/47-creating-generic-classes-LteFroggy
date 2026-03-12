using System;
using System.Security.Cryptography;

Func<string, int> stoiConvert = (str) => str.Length;
Func<int, string> itosConvert = (val) => $"{val}번";
Func<double, int> dtoiConvert = (dVal) => (int)dVal;

// string -> int 변환
Converter<string, int> stoiConverter = new Converter<string, int>(stoiConvert);
string[] strArr = new string[] { "Hello", "World", "hi" };
int[] stoiConvertedArr = stoiConverter.ConvertAll(strArr);

// int -> string 변환
Converter<int, string> itosConverter = new Converter<int, string>(itosConvert);
int[] intArr = new int[] { 1, 2, 3 };
string[] itosConvertedArr = itosConverter.ConvertAll(intArr);

// double -> int 변환
Converter<double, int> dtoiConverter = new Converter<double, int>(dtoiConvert);
double[] doubleArr = new double[] { 3.2, 1.0, 9.7 };
int[] dtoiConvertedArr = dtoiConverter.ConvertAll(doubleArr);

// string -> int 출력
Console.WriteLine($"=== 문자열 -> 길이 변환 ===");
Console.WriteLine($"Hello -> {stoiConverter.Convert("Hello")}");
Console.Write($"전체 변환 :");
for (int i = 0; i < stoiConvertedArr.Length; i++) {
Console.Write($"{(i != 0 ? ", " : " ")}" +
              $"{stoiConvertedArr[i]}");}
Console.WriteLine();
Console.WriteLine();

// int -> string 출력
Console.WriteLine($"=== 정수 -> 문자열 변환 ===");
Console.WriteLine($"1 -> {itosConverter.Convert(1)}");
Console.Write($"전체 변환 :");
for (int i = 0; i < itosConvertedArr.Length; i++) {
Console.Write($"{(i != 0 ? ", " : " ")}" +
              $"{itosConvertedArr[i]}");}
Console.WriteLine();
Console.WriteLine();

// dobble -> int 출력
Console.WriteLine($"=== 실수 -> 정수 변환 ===");
Console.WriteLine($"1 -> {dtoiConverter.Convert(1)}");
Console.Write($"전체 변환 :");
for (int i = 0; i < dtoiConvertedArr.Length; i++) {
Console.Write($"{(i != 0 ? ", " : " ")}" +
              $"{dtoiConvertedArr[i]}");}
Console.WriteLine();
Console.WriteLine();