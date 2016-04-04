using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixRewrite
{
   public class Show : Title
    {
        List<Episode> episodes = new List<Episode>();

        public int? Rating
        {
            get { return rating; }
            set
            {
                foreach (Episode episode in episodes)
                {
                    rating += episode.rate;
                }
                rating = rating / episodes.Count;
            }
        }

        public void Add(Episode newepisode)
        {
            episodes.Add(newepisode);
            rating = Rating;
        }

        public override string ToString()
        {
            string returnstring;
            returnstring = this.Name + " " + rating;

            return returnstring;
        }



    }
}
