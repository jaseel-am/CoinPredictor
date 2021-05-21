using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;

namespace CoinPredictor
{
    public static class ExtensionMethods
    {
        public static int AsInt(this string value)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(value))
            {
                i = Convert.ToInt32(value);
            }
            return i;
        }
        public static long AsLong(this string value)
        {
            long i = 0;
            if (!string.IsNullOrEmpty(value))
            {
                i = Convert.ToInt64(value);
            }
            return i;
        }
        public static int AsInt(this bool value)
        {
            int i = 0;
            if (value)
            {
                i = 1;
            }
            return i;
        }
        public static bool AsBool(this string value)
        {
            bool i = false;
            if (value == "1")
            {
                i = true;
            }
            return i;
        }
        public static DateTime AsDateTime(this string value)
        {
            DateTime dt = new DateTime();
            if (!string.IsNullOrEmpty(value))
            {
                dt = Convert.ToDateTime(value);
            }
            return dt;
        }
        public static double AsDouble(this string value)
        {
            double dou = 0;
            if (!string.IsNullOrEmpty(value))
            {
                dou = Convert.ToDouble(value);
            }
            return dou;
        }
        public static decimal AsDecimal(this string value)
        {
            decimal dou = 0;
            if (!string.IsNullOrEmpty(value))
            {
                dou = Convert.ToDecimal(value);
            }
            return dou;
        }
        /// <summary>
        /// Convert string to int.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>-1 if it is not a int.</returns>
        public static int StringToInt(string value)
        {
            int result = -1;
            if (!int.TryParse(value, out result))
            {
                result = -1;
            }
            return result;
        }
        /// <summary>
        /// Strings to double.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>-1 if it is not a decimal.</returns>
        public static double StringToDouble(string value)
        {
            double result = -1;
            if (!double.TryParse(value, out result))
            {
                result = -1;
            }
            return result;
        }
        public static string IntMonthToString(int Month)
        {
            switch (Month)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return "";
            }
        }
        public static DataTable ToDataTable<T>(this List<T> iList)
        {
            DataTable dataTable = new DataTable();
            PropertyDescriptorCollection propertyDescriptorCollection =
                TypeDescriptor.GetProperties(typeof(T));
            for (int i = 0; i < propertyDescriptorCollection.Count; i++)
            {
                PropertyDescriptor propertyDescriptor = propertyDescriptorCollection[i];
                Type type = propertyDescriptor.PropertyType;
                if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                    type = Nullable.GetUnderlyingType(type);
                dataTable.Columns.Add(propertyDescriptor.Name, type);
            }
            object[] values = new object[propertyDescriptorCollection.Count];
            foreach (T iListItem in iList)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = propertyDescriptorCollection[i].GetValue(iListItem);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
        /// <summary>
        /// Get string value between [first] a and [last] b.
        /// </summary>
        public static string Between(this string value, string a, string b)
        {
            int posA = value.IndexOf(a);
            int posB = value.LastIndexOf(b);
            if (posA == -1)
            {
                return "";
            }
            if (posB == -1)
            {
                return "";
            }
            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= posB)
            {
                return "";
            }
            return value.Substring(adjustedPosA, posB - adjustedPosA);
        }
        /// <summary>
        /// Get string value after [first] a.
        /// </summary>
        public static string Before(this string value, string a)
        {
            int posA = value.IndexOf(a);
            if (posA == -1)
            {
                return "";
            }
            return value.Substring(0, posA);
        }
        /// <summary>
        /// Get string value after [last] a.
        /// </summary>
        public static string After(this string value, string a)
        {
            int posA = value.LastIndexOf(a);
            if (posA == -1)
            {
                return "";
            }
            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= value.Length)
            {
                return "";
            }
            return value.Substring(adjustedPosA);
        }
        public static bool IsUrl(this string str)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(str, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            return result;
        }
    }
}
