using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace DateModifier
{
    public class DateModifier
    {
        public static double GetDays(string dataString1, string dataString2)
        {            
            var date1 = DateTime.ParseExact(dataString1, "yyyy MM dd", CultureInfo.InvariantCulture);
            var date2 = DateTime.ParseExact(dataString2, "yyyy MM dd", CultureInfo.InvariantCulture);

            if (date1 > date2)
            {
                return (date1 - date2).Days;
            }
            else
            {
                return (date2 - date1).Days;
            }
        }
    }
}
