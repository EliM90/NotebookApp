using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp {
    class Program {
        public enum Actions {
            Add,
            Update,
            Remove,
            Fetch,
            Exit
        }

        static void Main(string[] args) {
            Actions input;

            do {
                Enum.TryParse(Console.ReadLine() ,out input);

            } while (input != Actions.Exit);

        }
    }
}
