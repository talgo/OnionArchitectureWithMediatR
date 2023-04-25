using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Wrappers
{
    internal class BaseResponse
    {
        public int Id { get; set; }
        public bool IsSucces { get; set; }
        public string Message { get; set; }
    }
}
