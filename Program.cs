using DesafioPOO.Models;

namespace program {
    public class  Program
    {
        public static void Main(string[] args) 
        {
            Iphone iphone = new Iphone("31 99922-6468", "2", "2", 64);
            Nokia nokia = new Nokia("31 99922-9999", "3", "3", 32);

            Console.WriteLine("--------------");
            Console.WriteLine(nokia.ToString());
            Console.WriteLine("--------------");
            Console.WriteLine(iphone.ToString());
            Console.WriteLine("--------------");
        }
    }
}