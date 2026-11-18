using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voin_Patrusheva.Classes
{
    public class Voin
    {
        public int lives { get; set; }

        public Voin(int lives)
        {
            this.lives = lives;
        }
        public virtual void GetYron(int yron)
        {
            lives -= yron;
        }
    }
}
