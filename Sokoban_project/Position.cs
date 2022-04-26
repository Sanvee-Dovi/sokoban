using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_project
{
     public class Position
    {
          public int x;
          public int y;

     //constructeur Position qui initialise les attributs x et y

     public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }  
    }
}
