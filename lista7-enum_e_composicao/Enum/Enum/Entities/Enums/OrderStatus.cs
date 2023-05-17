using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipper = 2,
        Delivered = 3
    }
}
