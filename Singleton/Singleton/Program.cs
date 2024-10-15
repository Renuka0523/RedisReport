namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();

            s1.GetDatabaseObject().StringSet("person", "cleverPerson");

            Singleton s2 = Singleton.GetInstance();

            s2.GetDatabaseObject().StringGet("person");

            //if (s1 == s2)
            //{
            // Console.WriteLine("Singleton works, both vaariables contain the sonme instance");

            //  s1.SomeLogic().stringSet("key","valey");

            Console.ReadLine();


            //  }
            // else
            // {
            //    Console.WriteLine("Singleton failed, variables contain diffrent instance");
            // }
            // Console.ReadLine();

        }
    }
    
}
