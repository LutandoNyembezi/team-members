using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_6_1
{
    public class Player
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
        public Posicion pos{ set; get; }

        public virtual Team Team { set; get; }    
        public int? TeamId { set; get; }        

        public override string ToString()      
        {
            return Name;
        }

    }
}
