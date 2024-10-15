using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Singleton
    { //Declear private static field 

        private static Singleton instance;

        private static ConnectionMultiplexer conn;

        private static IDatabase db;

        //private constructor 

        private Singleton()
        {

            conn = ConnectionMultiplexer.Connect("localhost");

        }

        //GetInstance method which will be accessed from the outside scope
        //will return instance always when invoked
        //if first time call create instance
        //else return already created

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        //  internal static Singleton GetInstance()
        //   {
        //     throw new NotImplemente
        // }

        public IDatabase GetDatabaseObject()
        {
            return conn.Getdatabase();
        }
    }
    //an business logic methos that needed
}
