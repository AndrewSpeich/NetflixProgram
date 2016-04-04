using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixRewrite
{
    class Episode
    {
        int rating;
        public int rate
        {
            get { return rating; }
            set { }
        }
        public Episode(int rating)
        {
            this.rating = rating;
        }
    }
}
