using Billix.Core.Enums.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billix.Core.Commons.Functions
{
    /// <summary>
    /// Currency Exchanger (using FreeCurrencyAPI)
    /// </summary>
    public static class CurrencyExchanger
    {
        private static readonly Dictionary<CurrencyUnit, string> Units = new Dictionary<CurrencyUnit, string>
        {
            { CurrencyUnit.EUR, "€" },
            { CurrencyUnit.USD, "$" },
            { CurrencyUnit.JPY, "¥" },
            { CurrencyUnit.BGN, "лв" },
            { CurrencyUnit.CZK, "Kč" },
            { CurrencyUnit.DKK, "kr" },
            { CurrencyUnit.GBP, "£" },
            { CurrencyUnit.HUF, "Ft" },
            { CurrencyUnit.PLN, "zł" },
            { CurrencyUnit.RON, "lei" },
            { CurrencyUnit.SEK, "kr" },
            { CurrencyUnit.CHF, "CHF" },
            { CurrencyUnit.ISK, "kr" },
            { CurrencyUnit.NOK, "kr" },
            { CurrencyUnit.HRK, "kn" },
            { CurrencyUnit.RUB, "₽" },
            { CurrencyUnit.TRY, "₺" },
            { CurrencyUnit.AUD, "$" },
            { CurrencyUnit.BRL, "R$" },
            { CurrencyUnit.CAD, "$" },
            { CurrencyUnit.CNY, "¥" },
            { CurrencyUnit.HKD, "$" },
            { CurrencyUnit.IDR, "Rp" },
            { CurrencyUnit.ILS, "₪" },
            { CurrencyUnit.INR, "₹" },
            { CurrencyUnit.KRW, "₩" },
            { CurrencyUnit.MXN, "$" },
            { CurrencyUnit.MYR, "RM" },
            { CurrencyUnit.NZD, "$" },
            { CurrencyUnit.PHP, "₱" },
            { CurrencyUnit.SGD, "$" },
            { CurrencyUnit.THB, "฿" },
            { CurrencyUnit.ZAR, "R" }
        };

        public static string GetUnit(CurrencyUnit unit)
        {
            return Units[unit];
        }

        // TODO Currency exchange from memory
    }
}
