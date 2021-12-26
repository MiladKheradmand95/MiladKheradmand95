using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Accounting.Utility.Convertor
{
    public static class DateConverter
    {
        public static string Toshamsi(this DateTime values)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(values).ToString("0000") + "/" + pc.GetMonth(values).ToString("00") + "/" + pc.GetDayOfMonth(values).ToString("00");
        }
        public static DateTime ToMiladi(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, new System.Globalization.PersianCalendar());
        }
    }
}
