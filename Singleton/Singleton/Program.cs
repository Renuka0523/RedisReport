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

        
            
            Console.ReadLine();

        }
    }
    
}
