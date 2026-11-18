using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voin_Patrusheva.Classes
{
    public class Hard : Voin
    {
        public Hard(int lives) : base(lives) { }

        public override void GetYron(int yron)
        {
            // в тяжелых доспехах урон попалам
            base.GetYron(yron / 2);
        }
    }
}
