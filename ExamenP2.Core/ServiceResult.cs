﻿using System;
using ExamenP2.Core.Enums;

namespace ExamenP2.Core
{
    public class ServiceResult<T>
    {
        public ServiceResult(ResponseCode response, string error, T result)
        {
            ResponseCode = response;
            Error = error;
            Result = result;
        }
        public ResponseCode ResponseCode { get; set; }
        public string Error { get; set; }
        public T Result { get; set; }

        public static ServiceResult<T> ErrorResult(string error)
        {
            return new ServiceResult<T>(ResponseCode.Error, error, default(T));
        }
        public static ServiceResult<T> SuccessResult(T entity)
        {
            return new ServiceResult<T>(ResponseCode.Success, string.Empty, entity);
        }

        public static ServiceResult<T> NotFoundResult(string error)
        {
            return new ServiceResult<T>(ResponseCode.NotFound, error, default(T));
        }
    }
}
