using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConverterLibrary
{
    public static class CustomConverter
    {
        public static string ConvertToBinaryString(uint valueToConvert)
        {
            return Convert.ToString(valueToConvert, 2);
        }

        public static string ConvertToBinaryStringCustom(uint valueToConvert)
        {
            if (valueToConvert == 0)
            {
                return "0";
            }

            StringBuilder tmp = new StringBuilder();

            while (valueToConvert != 1)
            {
                tmp.Append(valueToConvert % 2);
                valueToConvert /= 2;
            }

            StringBuilder result = new StringBuilder();

            result.Append('1');

            for (int i = tmp.Length - 1; i >= 0; i--)
            {
                result.Append(tmp[i]);
            }

            return result.ToString();     
        }
    }
}
