using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixRewrite
{
   public class Movie : Title
    {
        TimeSpan Duration;

        public override string ToString()
        {
            string returnstring;
            returnstring = this.Name + " " + Duration.Minutes;

            return returnstring;
        }
    }
}
