using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4_Enums
{
    enum Genders
    {
        Boy, Girl, Other
    }

    enum Sports
    {
        Tennis, Rugby, Soccer, Hurling, Squash, Basketball, Badminton
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public Genders Gender { get; set; }
        public Sports FavoriteSport { get; set; }
        



    }
}
