using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;

namespace ApiGuideTV.Utilities.Format
{
    public class ReflectionHelper
    {
        private static ReflectionHelper helper;

        static ReflectionHelper()
        {
            helper = new ReflectionHelper();
        }

        /// <summary>
        /// Get type and value from each property of a class
        /// </summary>
        /// <param name="o">Class to get properties</param>
        /// <returns>Json containing properties from class</returns>
        public static string GetPropertiesToBeLogged(Object o)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("{ ");

            if (o != null)
            {
                Type classType = o.GetType();
                PropertyInfo[] properties = classType.GetProperties();

                sb.Append(classType.AssemblyQualifiedName);
                sb.Append(" : ");

                foreach (PropertyInfo pi in properties)
                {
                    Type valueType = pi.PropertyType;
                    Object value = pi.GetValue(o);
                    sb.Append(pi.Name).Append(" = ").Append(value).Append(",");
                }

            }

            return sb.ToString();
        }
    }
}