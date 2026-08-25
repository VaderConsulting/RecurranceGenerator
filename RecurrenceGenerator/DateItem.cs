using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecurrenceGenerator
{
    public class DateItem
    {
        DateTime value;
        public DateItem(DateTime dateValue)
        {
            value = dateValue;
        }

        public DateTime Value
        {
            get
            {
                return value;
            }
        }
        public override string ToString()
        {
            return value.ToString("d MMM, yyyy   ddd");
        }
    }
}
