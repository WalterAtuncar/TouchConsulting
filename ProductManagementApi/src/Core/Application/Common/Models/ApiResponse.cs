using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class ApiResponse<T>
    {
        public int StatusCode { get; set; }
        public T? Data { get; set; }
        public string? Message { get; set; }
        public bool IsSuccess { get; set; }

        public static ApiResponse<T> Success(T data, string message = "Operación exitosa", int statusCode = 200)
        {
            return new ApiResponse<T>
            {
                StatusCode = statusCode,
                Data = data,
                Message = message,
                IsSuccess = true
            };
        }

        public static ApiResponse<T> Fail(string message, int statusCode)
        {
            return new ApiResponse<T>
            {
                StatusCode = statusCode,
                Data = default,
                Message = message,
                IsSuccess = false
            };
        }
    }
}
