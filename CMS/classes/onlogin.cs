using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.classes
{
    public class onlogin
    {
        //Implementing polymorphism
      public virtual string loginauth(string name)
         {
            return name;
         }
        public virtual string totalrec(string count)
        {
            return count;
        }
    }
    

}
