using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.ChainOfResponsibilities
{
    class FinalPrintHandler : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request.Length > 5)
            {
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            }
            else
            {
                Console.WriteLine("Request is not handled");
            }
        }
    }
}
