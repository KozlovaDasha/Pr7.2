using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr7
{
    partial class Program
    {
         static void Main()
            {
                IRoom[] rooms = new IRoom[3]
                {
                new ClassRoom(10, 20, 14),
                new MyRoom(4, 10, 7),
                new ClassRoom(11, 15, 14)
                };

                Console.WriteLine("Unsorted collection of rooms:\n");
                foreach (var room in rooms)
                {
                    Console.WriteLine($"Amount of windows: {room.AmountOfWindows}");
                    Console.WriteLine($"Here is room square: {room.RoomSquare()}");
                }
                
                
                Array.Sort<IRoom>(rooms, new AmountOfWindowsComparer());

                Console.WriteLine("Sorted collection of rooms:\n");
                foreach (var room in rooms)
                {
                    Console.WriteLine($"Amount of windows: {room.AmountOfWindows}");
                    Console.WriteLine($"Here is room square: {room.RoomSquare()}");
                }

                Console.ReadLine();
            }
        }
    
}
