using System;
using System.Globalization;
namespace Business
{
    /// <summary>
    /// This is the place where data formatting is handled
    /// </summary>
    public class Tool
    {
        /// <summary>
        /// Id Converter from string to int?
        /// </summary>
        /// <param name="s">string input</param>
        /// <returns>Returns either null or an int</returns>
        public static int? toId(string s)
        {
            return int.Parse(s);
        }

        /// <summary>
        /// Convert a date into an array of: Year, Month and Day
        /// </summary>
        /// <param name="date">use format yyyymmdd</param>
        /// <returns>Returns an array with format yyyy|mm|dd</returns>
        public static string[] DateSeq(string date)
        {
            int lenght = date.Length;
            string[] array = new string[3];
            if (lenght >= 4) array[0] = date.Substring(0, 4);
            if (lenght >= 6) array[1] = date.Substring(4, 2);
            if (lenght >= 8) array[2] = date.Substring(6, 2);

            return array;

        }

        /// <summary>
        /// Converter for decimals using invariant culture to always get it right. No more errors thank you.
        /// </summary>
        /// <param name="d">send the string number you want to convert</param>
        /// <returns>returns the useful decimal</returns>
        public static double decimalMaker(string d)
        {
            if (d != null && d != "")
            {
                if (d.Contains(",")) return Convert.ToDouble(d.Replace(",", "."), CultureInfo.InvariantCulture);
                else if (d.Contains(".")) return Convert.ToDouble(d, CultureInfo.InvariantCulture);

                else return Convert.ToDouble(d);
            }
            else return 0;
        }

    }
}
