using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.ChainOfResponsibilities
{
    class AddHandler : Handler
    {
        public override void HandleRequest(string request)
        {
            request += "12345";
            successor.HandleRequest(request);
        }
    }
}
