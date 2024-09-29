using ApiResponse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiResponse
{
    public class ResponseModel
    {
        public ResponseTypes ResponseType { get; set; }
        public object? Data { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
