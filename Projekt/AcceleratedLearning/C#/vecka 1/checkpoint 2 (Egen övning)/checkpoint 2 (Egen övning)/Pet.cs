using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkpoint_2__Egen_övning_
{
    enum Gender
    {
        Male, Female
    }
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public  Gender Gender { get; set; }
    }
}
