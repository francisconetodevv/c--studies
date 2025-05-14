using System; // Pacotes - Mesma ideia de bibliotecas (Python; Golang utiliza os packages também)
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld{
    
    class Program {
        
        static void Main(string[] args)
        {
            /*
                1- Um programa de uma determinada empresa tem o objetivo de salvar o nome completo de
               todos os funcionários que estiveram presentes no trabalho em todos os dias do mês, para que
               sejam entregues as devidas bonificações. Segundo o enunciado acima, assinale o tipo de dado
               que corresponda ao armazenamento dessa variável:
             */
            
            string completName = "Joao Fonsceca";
            Console.WriteLine(completName);
            
            /*
             * 2- Um operador de caixa em um mercado utiliza um programa que o informa todos os preços
               dos produtos disponíveis para a venda, com base nisso, informe quais seriam os tipos de
               dados que essas variáveis armazenam:
             */

            float priceRice = 12.4f;
            float priceBeans = 10.5f;
            float priceBeaf = 44.4f;
            
            Console.WriteLine(priceRice);
            Console.WriteLine(priceBeaf);
            Console.WriteLine(priceBeans);

            /*
             * 3- Um bibliotecário utiliza um programa que organiza em ordem alfabética os livros por sua letra
               inicial, que tipo de variável esse programa utiliza?
             */

            char libLetter = 'b';
            Console.WriteLine(libLetter);
            
            /*
             * 4- Em um software de detecção de mentiras, qual tipo de variável pode ser utilizado para
               armazenar os dados de afirmações verdadeiras e falsas ?
             */

            bool trueAnswer = true;

            if (trueAnswer == true)
            {
                Console.WriteLine("The answer is true");
            }
            
            /*
             * 5- Pedro está desenvolvendo um aplicativo que gerencia um grupo de membros nas redes
               sociais, porém ele não sabe quais tipos de variáveis ele deve usar para armazenar cada dado
               da aba de cadastro ao qual o app solicita para a entrada de novos membros. Conforme o
               enunciado acima e os conhecimentos adquiridos na aula, Assinale a alternativa correta
               referente aos tipos de dados em cada opção:
             */

            string name = "Pedro";
            int age = 20;
            int visu = 100;
            char letterName = 'P';
            bool accord = true;

            if (accord == true)
            {
                Console.WriteLine(name);
                Console.WriteLine(age);
                Console.WriteLine(visu);
                Console.WriteLine(letterName);
                Console.WriteLine("Pedro has accept the rules.");
            }
        }
    }
}