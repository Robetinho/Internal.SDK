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
            catch
            {
                return StatusCode(500, new { error = "An error occurred processing the request." });
            }
        }
    }
}
