using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello World!");
            Console.ReadKey();

           
        }
    }

    // interface
    // a completetely abstract class containing only abstract members

    public interface  IShape
    {
        void Draw(); 
    }
    // once definded a class as an interface there is no need to put abstract in front of each method
    // also all methods are public by default and cannot be changed
    // also interfaces can have methods and properties but cannot contain fields (variables)
    // thats because an interface is a definition and not an implementation
    // I assume (but i might be wrong that it can have
    // String name;
    // but not 
    // String Name = "Tony Strack";
    // meh.. now me test it

    public interface IMayHaveVariables
    {
        void Fart();
        string name;
    }

    // nah.. does not work
    // String Name is considered a field;
    // now I guess properties are like:

    public interface IMayHaveProperties
    {
        void Fart();
        string name { get;set; }
    }

    //Yay! that Vorks!
    //properties are those weird things with get and set that combine fields and methods

}
