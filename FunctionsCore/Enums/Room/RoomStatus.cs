using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsCore.Enums.Room
{
    public enum RoomStatus
    {
        /// <summary>
        /// The status of the room is not known or does not match any statuses
        /// </summary>
        Unknown,

        /// <summary>
        /// The room is currently being used
        /// </summary>
        Occupied,

        /// <summary>
        /// The room is not currently being used
        /// </summary>
        Vacant,

        /// <summary>
        /// The room is not available due to maintenance work
        /// </summary>
        UnderMaintenance,

        /// <summary>
        /// The room has been reserved for future use
        /// </summary>
        Reserved,

        /// <summary>
        /// The room is not available for use for any reason not covered by other statuses
        /// </summary>
        Unavailable,
    }
}