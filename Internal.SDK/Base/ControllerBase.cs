using Microsoft.AspNetCore.Mvc;
using System;

namespace Internal.SDK.Base
{

    public abstract class ControllerBase
        : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        internal async Task<IActionResult> ExecuteSafeAsync<T>(Func<Task<T>> operation)
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
                    details = error
                }; 
                return StatusCode(500, payload);
            }
            catch (Exception error)
            {

                var exception = new ServiceException(error.Message);
               
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
