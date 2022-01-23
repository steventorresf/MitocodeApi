using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace EvaluacionFinal.Dto
{
    public class ResponseDto<T>
    {
        public bool Success { get; set; }
        public HttpStatusCode Code { get; set; }
        public T Result { get; set; }
        public string Message { get; set; }

        public ResponseDto()
        {
            this.Success = true;
            this.Code = HttpStatusCode.OK;
        }

        public void Error(HttpStatusCode _code, string _message, T _result)
        {
            this.Success = false;
            this.Code = _code;
            this.Message = _message;
            this.Result = _result;
        }
    }
}
