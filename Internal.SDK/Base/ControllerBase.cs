using Internal.SDK.SlackMessenger;
using Internal.SDK.SystemLogger;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;

namespace Internal.SDK.Base
{

    public abstract class ControllerBase
        : Microsoft.AspNetCore.Mvc.ControllerBase
    {


        private readonly ISystemLoggerClient? _systemLoggerClient;

        internal ControllerBase(ISystemLoggerClient? systemLoggerClient)
        {
            _systemLoggerClient = systemLoggerClient;
        }

        internal async Task<IActionResult> ExecuteSafeAsync<TResult>(Func<Task<TResult>> operation) 
        {
            try
            {  
                var result = await operation();
                return Ok(result); 
            }  
            catch (ServiceException exception)
            { 
                
                var payload = new
                {
                    type = exception.Error.GetType().FullName,
                    details = (object)exception.Error,
                };

                //if log error set to true and check logger is not null then log
                //if (exception.Data.l

                if (  exception.Error.LogError && _systemLoggerClient != null)
                {  
                    _systemLoggerClient.LogError(exception); 
                }

                //_systemLoggerClient.LogError()

                return StatusCode(500, payload);
            } 
            catch (Exception exception)
            { 
                var error = new ServiceError().FromException(exception);

                var payload = new
                {
                    type = error.GetType().FullName,
                    details = error
                };


                if (_systemLoggerClient != null)
                {
                    _systemLoggerClient.LogError(exception);
                }

                return StatusCode(500, payload);
            }
        }
    }
}
