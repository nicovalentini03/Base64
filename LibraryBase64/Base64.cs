using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBase64
{
    public class Base64
    {
            public static string EsBase64()
            {
                string toEncode = "nicolo";
                byte[] toEncodeAsBytes = ASCIIEncoding.ASCII.GetBytes(toEncode);

                string returnValue = Convert.ToBase64String(toEncodeAsBytes);

                return returnValue;
            }
    }


}
