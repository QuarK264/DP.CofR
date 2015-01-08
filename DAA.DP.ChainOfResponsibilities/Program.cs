namespace DAA.DP.ChainOfResponsibilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            Handler h1 = new AddHandler();
            Handler h2 = new PrintHandler();
            Handler h3 = new FinalPrintHandler();

            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            string request = "dfg";

            h1.HandleRequest(request);

            Console.ReadKey();
        }
    }
}
