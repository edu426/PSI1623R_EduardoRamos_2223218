using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    internal class HttpVerify
    {
        public string Verify(string link)
        {
            if (link.StartsWith("https://", StringComparison.OrdinalIgnoreCase ))
            {
                return link;
            }
            else if (link.StartsWith(""))
            {
                return "https://demofree.sirv.com/nope-not-here.jpg";
            }
            else
            {
                return "ERr0r404";
            }
        }

        public bool VerifyProfile(string link)
        {
            if (link.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else { return false; }
        }
    }
}
