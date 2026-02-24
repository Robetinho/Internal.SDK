using Microsoft.AspNetCore.Mvc;

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
            catch (Exception error)
            { 

                var exception = new ServiceException(error.Message);
              
                var payload = new
                {
                    type = exception.GetType().FullName,
                    details = exception
                };
                Console.WriteLine("error type :" + payload.type);
                return StatusCode(500, payload);
            }
        }
    }
}
