using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.Enums
{
    public enum OrderStates
    {
        Draft=1,
        Confirmed=2,
        Paid=3,
        Shipped=4,
        Delivered=5,
        Returned=6,
        Canceled=7
    }
}
