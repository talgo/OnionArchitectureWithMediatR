using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Wrappers
{
    public class BaseResponse
    {
        public int Id { get; set; }
        public bool IsSucces => Message == null || Message == "";
        public string Message { get; set; }
    }
}
