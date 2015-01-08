using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.ChainOfResponsibilities
{
    class PrintHandler : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request.Length > 9)
            {
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            }
            else
            {
                successor.HandleRequest(request);
            }
        }
    }
}
