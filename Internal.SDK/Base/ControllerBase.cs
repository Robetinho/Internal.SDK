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
