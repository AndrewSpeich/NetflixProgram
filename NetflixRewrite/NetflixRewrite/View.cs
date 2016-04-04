using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixRewrite
{
    class View
    {
        public void printList(Genre genre)
        {
            Console.WriteLine(genre.ToString());
            foreach (Title title in genre)
            {
              Console.Write(title.ToString());
            }
            Console.WriteLine();
        }

       
    }
}
