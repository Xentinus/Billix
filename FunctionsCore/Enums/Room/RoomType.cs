using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsCore.Enums.Room
{
    public enum RoomType
    {
        /// <summary>
        /// When the room type is not known or does not match any types
        /// </summary>
        Unknown,

        /// <summary>
        /// A room where food is cooked
        /// </summary>
        Kitchen,

        /// <summary>
        /// A room containing a bathtub or shower and usually a washbasin and toilet
        /// </summary>
        Bathroom,

        /// <summary>
        /// A room for sleeping in
        /// </summary>
        Bedroom,

        /// <summary>
        /// A room in a house for general and informal everyday use
        /// </summary>
        LivingRoom,

        /// <summary>
        /// A room where meals are eaten
        /// </summary>
        DiningRoom,

        /// <summary>
        /// A room where work, especially clerical work, is carried out
        /// </summary>
        Office,

        /// <summary>
        /// A building or indoor area for parking or storing motor vehicles
        /// </summary>
        Garage,

        /// <summary>
        /// The floor of a building partly or entirely below ground level
        /// </summary>
        Basement,

        /// <summary>
        /// A space or room just below the roof of a building
        /// </summary>
        Attic,

        /// <summary>
        /// A room where clothes are washed and ironed
        /// </summary>
        LaundryRoom,

        /// <summary>
        /// A room for relaxing or socializing in a house or building, typically furnished with comfortable seating and a variety of games
        /// </summary>
        GameRoom,

        /// <summary>
        /// A room designed to reproduce the intensity of a cinema presentation in a home setting
        /// </summary>
        HomeTheater,

        /// <summary>
        /// A room where books are kept
        /// </summary>
        Library,

        /// <summary>
        /// A room or building equipped for gymnastics, games, and other physical exercise
        /// </summary>
        Gym,

        /// <summary>
        /// A bedroom in a house or hotel set aside for guests or visitors
        /// </summary>
        GuestRoom,

        /// <summary>
        /// A room in a house designated for the care of babies and young children
        /// </summary>
        Nursery,

        /// <summary>
        /// A room where items are stored
        /// </summary>
        StorageRoom,

        /// <summary>
        /// A room containing only a toilet
        /// </summary>
        Toilet,
    }
}
