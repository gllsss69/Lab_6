using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class AncientSword : Artifact
    {
        public AncientSword(int id) : base(id)
        {
        }

        public override void Identify()
        {
            Console.WriteLine("[Ancient Sword] Це заіржавілий меч короля.");
        }
    }
}
