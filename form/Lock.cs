using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form
{
    class Lock
    {

        public int lockOut = 3;
        public string file;
        public Lock(string fileLock, int lokOut )
        {
            file = fileLock;
            lockOut = lokOut;
        }

    }
}
