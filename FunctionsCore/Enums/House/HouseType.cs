using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsCore.Enums.House
{
    public enum HouseType
    {
        /// <summary>
        /// When the house type is not known or does not match any types
        /// </summary>
        Unknown,

        /// <summary>
        /// A low house, with a broad front porch, having either no upper floor, or upper rooms set in the roof, typically with dormer windows
        /// </summary>
        Bungalow,

        /// <summary>
        /// A large and luxurious country residence
        /// </summary>
        Villa,

        /// <summary>
        /// A small simple house, typically one near a lake or beach
        /// </summary>
        Cottage,

        /// <summary>
        /// A large, impressive house
        /// </summary>
        Mansion,

        /// <summary>
        /// A suite of rooms forming one residence, typically in a building containing a number of these
        /// </summary>
        Apartment,

        /// <summary>
        /// A house divided into two apartments, with a separate entrance for each
        /// </summary>
        Duplex,

        /// <summary>
        /// A tall, narrow, traditional row house, generally having three or more floors
        /// </summary>
        Townhouse,

        /// <summary>
        /// A building or complex of buildings containing a number of individually owned apartments or houses
        /// </summary>
        Condominium,

        /// <summary>
        /// A space directly under the roof of a house or other building, which may be used for accommodations or storage
        /// </summary>
        Loft,

        /// <summary>
        /// An apartment consisting of a single large room, a small kitchen, and a bathroom
        /// </summary>
        Studio,

        /// <summary>
        /// An apartment on the highest floor of an apartment building
        /// </summary>
        Penthouse,

        /// <summary>
        /// A wooden house or cottage with overhanging eaves, typically found in the Swiss Alps
        /// </summary>
        Chalet,

        /// <summary>
        /// The main house on a farm, typically a large, plain, practical home
        /// </summary>
        Farmhouse,

        /// <summary>
        /// A one-story house typically with a low-pitched roof, sometimes with an attached garage
        /// </summary>
        Ranch,

        /// <summary>
        /// A small shelter or house, made of wood and situated in a wild or remote area
        /// </summary>
        Cabin,

        /// <summary>
        /// A large building or group of buildings fortified against attack with thick walls, battlements, towers, and in many cases a moat
        /// </summary>
        Castle,

        /// <summary>
        /// The official residence of a sovereign, archbishop, bishop, or other high-ranking person
        /// </summary>
        Palace,

        /// <summary>
        /// A circular tent of felt or skins on a collapsible framework, used by nomads in Mongolia, Siberia, and Turkey
        /// </summary>
        Yurt,
    }
}
