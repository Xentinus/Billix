using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billix.Core.Enums.House
{
    public enum HouseStatus
    {
        /// <summary>
        /// The status of the house is not known or cannot be determined.
        /// </summary>
        Unknown,

        /// <summary>
        /// The house is currently being built.
        /// </summary>
        UnderConstruction,

        /// <summary>
        /// The house is newly built and has never been lived in.
        /// </summary>
        New,

        /// <summary>
        /// The house is currently occupied by a resident.
        /// </summary>
        Occupied,

        /// <summary>
        /// The house is currently unoccupied.
        /// </summary>
        Vacant,

        /// <summary>
        /// The house is currently on the market for sale.
        /// </summary>
        ForSale,

        PendingSale,

        /// <summary>
        /// The house has been sold and is no longer on the market.
        /// </summary>
        Sold,

        /// <summary>
        /// An offer has been made on the house and it is under consideration.
        /// </summary>
        UnderOffer,

        /// <summary>
        /// The house is not currently for sale or rent.
        /// </summary>
        OffMarket,

        /// <summary>
        /// The house is available for rent.
        /// </summary>
        ForRent,

        /// <summary>
        /// The house has been rented out to a tenant.
        /// </summary>
        Rented,

        /// <summary>
        /// The house has been seized by a bank due to non-payment of the mortgage.
        /// </summary>
        Foreclosed,

        /// <summary>
        /// The house is currently undergoing renovations.
        /// </summary>
        Renovating,
    }
}
