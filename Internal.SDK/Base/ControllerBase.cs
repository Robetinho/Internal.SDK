using Internal.SDK.SlackMessenger;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;

namespace Internal.SDK.Base
{

    public abstract class ControllerBase
        : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        internal async Task<IActionResult> ExecuteSafeAsync<TResult, TException>(Func<Task<TResult>> operation)  where TException : ServiceException
        {
            try
            {  
                var result = await operation();
                return Ok(result); // JsonResult is part of Microsoft.AspNetCore.Mvc
            }  
            catch (ServiceException exception)
            {
                Console.WriteLine("went to ServiceException");

                var payload = new
                {
                    type = exception.Error.GetType().FullName,
                    details = (object)exception.Error,
                };
                return StatusCode(500, payload);
            } 
            catch (Exception exception)
            {
                Console.WriteLine("went to exception");
                var error = new ServiceError().FromException(exception);

                var payload = new
                {
                    type = error.GetType().FullName,
                    details = error
                }; 
                return StatusCode(500, payload);
            }
        }
    }
}
