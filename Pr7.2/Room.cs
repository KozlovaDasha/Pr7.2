using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr7
{
    
    public class ClassRoom : Square, IRoom
    {
        public ClassRoom(int amountOfWindows, int length, int width): base(length, width)
        {
            AmountOfWindows = amountOfWindows;
        }

        public int AmountOfWindows { get; set; }

        public int RoomSquare() => (int)Area();

        public int CompareTo(IRoom someRoom)
        {
            return this.RoomSquare().CompareTo(someRoom.RoomSquare());
        }

    }

    public class MyRoom : Square, IRoom
    {
        public MyRoom(int amountOfWindows, int length, int width) : base(length, width)
        {
            AmountOfWindows = amountOfWindows;
        }

        public int AmountOfWindows { get; set; }

        public int RoomSquare() => (int)Area();

        public int CompareTo(IRoom someRoom)
        {
            return this.RoomSquare().CompareTo(someRoom.RoomSquare());
        }
    }
}
