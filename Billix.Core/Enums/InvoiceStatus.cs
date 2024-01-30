using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billix.Core.Enums
{
    public enum InvoiceStatus
    {
        Draft,
        Unknown,
        Viewed,
        Partial,
        Paid,
        NotPaid,
        Refunded,
        Overdue,
        Void,
    }
}
