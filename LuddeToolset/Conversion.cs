/*
 *         LuddeToolset.Conversion
 * 
 *         LuddeToolset by ferityigitbalaban @ 2020
 *         https://www.github.com/fybalaban
 *         https://www.instagram.com/ferityigitbalaban/
 *         https://www.twitter.com/fybalaban/
 *         https://fybalaban.github.io/website/
 */

using System;

namespace LuddeToolset
{
    /// <summary>
    /// Convert objects in a safe, fast and reliable way. Currently supports object to integer, boolean, double, float operations.
    /// </summary>
    public static class Conversion
    {
        /// <summary>
        /// Converts object to integer safely. Suppressed errors can be collected by using a ErrorHandler object. 
        /// </summary>
        /// <param name="value">object to convert</param>
        /// <param name="errCheck">default false to suppress errors, true to handle</param>
        /// <param name="handler">handler object for errors</param>
        /// <returns></returns>
        public static int ToInteger(this object value, bool errCheck = false, LuddeToolset.ErrorHandler handler = null)
        {
            int result = -1;
            int.TryParse(value.ToString(), out result);
            return result;
        }

        /// <summary>
        /// Converts object to boolean safely. Suppressed errors can be collected by using a ErrorHandler object. 
        /// </summary>
        /// <param name="value">object to convert</param>
        /// <param name="errCheck">default false to suppress errors, true to handle</param>
        /// <param name="handler">handler object for errors</param>
        /// <returns></returns>
        public static bool ToBoolean(this object value, bool errCheck = false, LuddeToolset.ErrorHandler handler = null)
        {
            try
            {
                return Convert.ToBoolean(value);
            }
            catch (Exception exception)
            {
                if (errCheck && handler != null)
                {
                    handler.Handle(exception);
                }
                return false;
            }
        }

        /// <summary>
        /// Converts object to double safely. Suppressed errors can be collected by using a ErrorHandler object. 
        /// </summary>
        /// <param name="value">object to convert</param>
        /// <param name="errCheck">default false to suppress errors, true to handle</param>
        /// <param name="handler">handler object for errors</param>
        /// <returns></returns>
        public static double ToDouble(this object value, bool errCheck = false, LuddeToolset.ErrorHandler handler = null)
        {
            try
            {
                return Convert.ToDouble(value);
            }
            catch (Exception exception)
            {
                if (errCheck && handler != null)
                {
                    handler.Handle(exception);
                }
                return -1;
            }
        }

        /// <summary>
        /// Converts object to float safely. Suppressed errors can be collected by using a ErrorHandler object. 
        /// </summary>
        /// <param name="value">object to convert</param>
        /// <param name="errCheck">default false to suppress errors, true to handle</param>
        /// <param name="handler">handler object for errors</param>
        /// <returns></returns>
        public static float ToFloat(this object value, bool errCheck = false, LuddeToolset.ErrorHandler handler = null)
        {
            try
            {
                return Convert.ToSingle(value);
            }
            catch (Exception exception)
            {
                if (errCheck && handler != null)
                {
                    handler.Handle(exception);
                }
                return -1;
            }
        }

        /// <summary>
        /// Converts every item in T type array to integer type array. If supplied array was empty or null, returns null.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] ToIntegerArray<T>(this T[] array)
        {
            if (array != null && array.Length != 0)
            {
                int[] result = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    result[i] = ToInteger(array[i]);
                }
                return result;
            }
            return null;
        }

        /// <summary>
        /// Converts every item in T type array to string type array. If supplied array was empty or null, returns null.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static string[] ToStringArray<T>(this T[] array)
        {
            if (array != null && array.Length != 0)
            {
                string[] result = new string[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    result[i] = array[i].ToString();
                }
                return result;
            }
            return null;
        }

        /// <summary>
        /// Converts every item in T type array to double type array. If supplied array was empty or null, returns null.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static double[] ToDoubleArray<T>(this T[] array)
        {
            if (array != null && array.Length != 0)
            {
                double[] result = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    result[i] = ToDouble(array[i]);
                }
                return result;
            }
            return null;
        }
    }
}
