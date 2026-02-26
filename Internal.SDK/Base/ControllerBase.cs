using Internal.SDK.SlackMessenger;
using Microsoft.AspNetCore.Mvc;
using System;

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
            catch (ServiceException error)
            { 
                var payload = new
                {
                    type = error.GetType().FullName,
                    details = error.Error,
                };
                return StatusCode(500, payload);
            } 
            catch (Exception error)
            { 
                //var exception = (TError)error;
                var exception = error;
              
                var payload = new
                {
                    type = exception.GetType().FullName,
                    details = exception
                }; 
                return StatusCode(500, payload);
            }
        }
    }
}
