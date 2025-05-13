using System; // Pacotes - Mesma ideia de bibliotecas (Python; Golang utiliza os packages também)
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Project name
namespace HelloWorld{

    // Class 
    class Program {
        
        // Main function 
        static void Main(string[] args)
        {
            // This is a comment 
            /*
             This is also a comment
             */

            dynamic valorDinamico = "Blue";
            
            Console.WriteLine(valorDinamico);

        }
    }
}