using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voin_Patrusheva.Classes
{
    public class Legkie : Voin
    {
        public Legkie(int lives) : base(lives) { }

        public override void GetYron(int yron)
        {
            // урон просто как есть
            base.GetYron(yron);
        }
    }
}
