using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class MagicScroll : Artifact
    {
        public MagicScroll(int id) : base(id)
        {
        }

        public override void Identify()
        {
            Console.WriteLine("[Magic Scroll] Це сувій з закляттям вогню.");
        }
    }
}
