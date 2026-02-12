using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Artifact
    {
        private int id;

        public Artifact(int id)
        {
            this.id = id;
        }

        public virtual void Identify()
        {
            Console.WriteLine($"[Artifact ID: {id}] Це невідомий стародавній предмет.");
        }
    }
}
