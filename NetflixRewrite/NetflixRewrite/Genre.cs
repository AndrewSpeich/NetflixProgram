using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixRewrite
{
    public class Genre : IEnumerable
    {
        string name;
        public string Name { get; set; }
        List<Title> titlelist = new List<Title>();

        public IEnumerator GetEnumerator()
        {
           foreach(Title title in titlelist)
            {
               yield return title;
            }
        }

        public static Genre operator +(Genre genre1, Genre genre2)
        {
            Genre returned = new Genre();

            return returned;
        }
        public static Genre operator +(Genre genre, Title title)
        {
            Genre returned = new Genre();

            return returned;
            
        }

        public void Add(ref Title title)
        {
            titlelist.Add(title);
            title.genre += this.Name;
        }

    }
}
