using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class ApplicationState
    {
        public int LoginId { get; set; }
        public int MaxSize { get; set; }

        // Singleton part:

        private static ApplicationState instance;

        private ApplicationState()
        { }

        public static ApplicationState getInstance()
        {
            if (instance == null)
                instance = new ApplicationState();
            return instance;
        }
    }
}
