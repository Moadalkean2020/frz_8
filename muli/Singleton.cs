using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace mlava
{
    public sealed class Singleton
    {

        private static Singleton instance = null;

       public Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        private static string username;
        public void setuser(string user)
        {
            username = user;
        }
        public string getuser()
        {

            return username;

        }
    }
}

