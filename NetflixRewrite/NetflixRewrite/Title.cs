using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixRewrite
{
   public abstract class Title
    {
        protected string name;
        protected int? rating;
        string genres;
        public string genre
        {
            get { return genres; }
            set { genres +=value; }

        }
        public string Name
        {
            get { return name; }
        }

        public Title()
        {
            name = null;
            rating = null;
        }

        public Title(string name, int rating)
        {
            this.name = name;
            this.rating = rating;
        }

        public static Genre operator +(Title title1, Title title2)
        {
            Genre returned = new Genre();

            return returned;
        }

    }
}
