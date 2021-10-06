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

        private static object syncRoot = new Object();

        protected ApplicationState(int LoginId, int MaxSize)
        {
            this.LoginId = LoginId;
            this.MaxSize = MaxSize;
        }

        public static ApplicationState getInstance(int LoginId, int MaxSize)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new ApplicationState(LoginId, MaxSize);
                }
            }
            return instance;
        }
    }
}
