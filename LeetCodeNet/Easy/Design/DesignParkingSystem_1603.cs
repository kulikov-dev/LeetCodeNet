using System.Collections.Concurrent;

namespace LeetCodeNet.Easy.Design
{
    /// <summary>
    /// https://leetcode.com/problems/design-parking-system/
    /// </summary>
    /// <remarks>
    /// Design a parking system for a parking lot. The parking lot has three kinds of parking spaces: big, medium, and small, with a fixed number of slots for each size.
    /// </remarks>
    public sealed class ParkingSystem
    {
        /// <summary>
        /// Storage of places
        /// </summary>
        private readonly ConcurrentDictionary<PlaceType, ParkingPlace> _places;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="big"> Total amount of big places </param>
        /// <param name="medium"> Total amount of medium places </param>
        /// <param name="small"> Total amount of small places </param>
        public ParkingSystem(int big, int medium, int small)
        {
            _places = new ConcurrentDictionary<PlaceType, ParkingPlace>();

            _places.TryAdd(PlaceType.Big, new ParkingPlace(PlaceType.Big, big));
            _places.TryAdd(PlaceType.Medium, new ParkingPlace(PlaceType.Medium, medium));
            _places.TryAdd(PlaceType.Small, new ParkingPlace(PlaceType.Small, small));
        }

        /// <summary>
        /// Park a new car
        /// </summary>
        /// <param name="carType"> New car system</param>
        /// <returns></returns>
        public bool AddCar(int carType)
        {
            var info = _places[(PlaceType)carType];

            return info.ParkCar();
        }

        /// <summary>
        /// Parking place type
        /// </summary>
        private enum PlaceType
        {
            Big = 1,
            Medium = 2,
            Small = 3,
        }

        /// <summary>
        /// There is no hard problem here. The idea of this task is to show to the interviewer how you can organize your classes and make them pretty SOLID, etc..
        /// So remember all you know about SOLID, YAGNI, Patterns and build the great solution, which can be used in a real system.
        /// </summary>
        private sealed class ParkingPlace
        {
            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="type"> Parking place type </param>
            /// <param name="totalPlaces"> Total places </param>
            internal ParkingPlace(PlaceType type, int totalPlaces)
            {
                this.type = type;
                TotalPlaces = totalPlaces;
            }

            /// <summary>
            /// Place type
            /// </summary>
            private PlaceType type { get; }

            /// <summary>
            /// Total places
            /// </summary>
            internal int TotalPlaces { get; }

            /// <summary>
            /// Occupied places
            /// </summary>
            internal int OccupiedPlaces { get; private set; }

            /// <summary>
            /// Locker object
            /// </summary>
            private readonly object _locker = new();

            /// <summary>
            /// Park car
            /// </summary>
            /// <returns> True, if parked </returns>
            public bool ParkCar()
            {
                lock (_locker)
                {
                    if (OccupiedPlaces == TotalPlaces)
                    {
                        return false;
                    }

                    ++OccupiedPlaces;
                    return true;
                }
            }

            /// <summary>
            /// Make place free
            /// </summary>
            public void FreePlace()
            {
                lock (_locker)
                {
                    if (OccupiedPlaces > 0)
                    {
                        --OccupiedPlaces;
                    }
                }
            }
        }
    }

}
