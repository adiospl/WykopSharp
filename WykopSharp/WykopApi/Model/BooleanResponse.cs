using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WykopSharp.Model
{

    public class BooleanResponse : BaseResponse
    {
        public BooleanResponse(string response)
        {
            Success = response.Contains("true") ? true : false;
        }

        public bool Success { get; set; }
        
    }

}
