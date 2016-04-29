using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Caretaker...");
            OriginalObject obj = new OriginalObject("Initial state");
            obj.String = "New state";
            Console.WriteLine("Current state: {0}", obj.String);
            Console.WriteLine("Reverting state...");
            obj.Revert();
            Console.WriteLine("Current state: {0}", obj.String);
            Console.Read();
        }
    }

    public class OriginalObject
    {
        private Memento MyMemento;

        public string String { get; set; }

        public OriginalObject(string str)
        {
            this.String = str;
            this.MyMemento = new Memento(str);
        }

        public void Revert()
        {
            this.String = this.MyMemento.str;
        }
    }

    public class Memento
    {
        public readonly string str;

        public Memento(string str)
        {
            this.str = str;
        }
    }
}
