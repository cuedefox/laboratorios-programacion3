using System;

namespace DataConversionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("conversiones de datos");

            int intValue = 12345;
            short shortValue = ConvertIntToShort(intValue);
            Console.WriteLine($"int a short: {intValue} -> {shortValue}");

            long longValue = ConvertIntToLong(intValue);
            Console.WriteLine($"int a long: {intValue} -> {longValue}");

            float floatValue = 123.45f;
            int intFromFloat = ConvertFloatToInt(floatValue);
            Console.WriteLine($"float a int: {floatValue} -> {intFromFloat}");

            float floatFromInt = ConvertIntToFloat(intValue);
            Console.WriteLine($"int a float: {intValue} -> {floatFromInt}");

            double doubleFromInt = ConvertIntToDouble(intValue);
            Console.WriteLine($"int a double: {intValue} -> {doubleFromInt}");

            bool boolValue = true;
            string stringFromBool = ConvertBoolToString(boolValue);
            Console.WriteLine($"bool a string: {boolValue} -> \"{stringFromBool}\"");

            string stringFromInt = ConvertIntToString(intValue);
            Console.WriteLine($"int a string: {intValue} -> \"{stringFromInt}\"");

            object boxedInt = BoxValue(intValue);
            Console.WriteLine($"Boxing (int a object): {intValue} -> {boxedInt}");

            int unboxedInt = UnboxValue<int>(boxedInt);
            Console.WriteLine($"Unboxing (object a int): {boxedInt} -> {unboxedInt}");
        }

        static short ConvertIntToShort(int value)
        {
            return (short)value;
        }

        static long ConvertIntToLong(int value)
        {
            return (long)value;
        }

        static int ConvertFloatToInt(float value)
        {
            return (int)value;
        }

        static float ConvertIntToFloat(int value)
        {
            return (float)value;
        }

        static double ConvertIntToDouble(int value)
        {
            return (double)value;
        }

        static string ConvertBoolToString(bool value)
        {
            return value.ToString();
        }

        static string ConvertIntToString(int value)
        {
            return value.ToString();
        }

        static object BoxValue<T>(T value)
        {
            return (object)value;
        }

        static T UnboxValue<T>(object value)
        {
            return (T)value;
        }
    }
}