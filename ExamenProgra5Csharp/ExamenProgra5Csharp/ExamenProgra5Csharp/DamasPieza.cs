using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra5Csharp
{
    public class DamasPieza
    {
        public bool IsQueen { get; set; }
        public string Color { get; set; }

        public DamasPieza(bool isQueen, string color)
        {
            IsQueen = isQueen;
            Color = color;
        }
    }

}
