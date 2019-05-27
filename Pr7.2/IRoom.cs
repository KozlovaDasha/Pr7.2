using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr7
{
    
    public interface IRoom : IComparable<IRoom>
    {
        int AmountOfWindows { get; set; }
        int RoomSquare();
    }
}
