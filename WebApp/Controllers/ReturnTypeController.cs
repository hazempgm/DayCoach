using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ReturnTypeController : Controller
    {
        # region :: Status Code Resulsts ::

        /*  <summary>
        *  When executed, it will produce an empty Status 200 Ok results.
        * </summary>
        */  
        public IActionResult OkResult()
        {
            return Ok();
        }

        
        /*  <summary>
        *  When executed, it will produce a Status 201 Ok results with a Location header.
        * </summary>
        */  
        public IActionResult CreatedResult()
        {
            return Created("http//example.com/item", new {name = "newitem"});
        } 
        
        /*  <summary>
        *  Result returns 204 Status code.
        * </summary>
        */  
        public IActionResult NoContentResult()
        {
            return NoContent();
        }

        /*  <summary>
        *  Result returns 400 Status code. It indicates a bad request by the user.
        * </summary>
        */  
        public IActionResult BadRequestResult()
        {
            return BadRequest();
        }
        
        
        /*  <summary>
        *  result returns 401 status code. it indicates a unauthorized request by the user.
        * </summary>
        */
        public IActionResult UnauthorizedResult()
        {
            return Unauthorized();
        }

        /*  <summary>
        *  result returns 404 status code. It occurs when there is no matching response to the request.
        * </summary>
        */
        public IActionResult NotFoundResult()
        {
            return NotFound();
        }
        
        
        
        /*  <summary>
        *  result returns 405 status code. It occurs the server cannot continue the request with the
        * given payload.
        * </summary>
        */
        public IActionResult UnsupportedMediaTypeResult()
        {
            return new UnsupportedMediaTypeResult();
        }
        
        
        #endregion

        #region :: Status Code with Objects Results ::

        public IActionResult OkObjectResult()
        {
            return new OkObjectResult(new
            {
                message = "200 OK",
                currentDate = DateTime.Now
            });
        }

        public IActionResult CreatedObjectResult()
        {
            return new CreatedAtActionResult("action", "controller", "", new
            {
                message = "201 Created",
                currentDate = DateTime.Now
            });
        }
        
        
        public IActionResult NotFoundObjectResult()
        {
            return new NotFoundObjectResult(new
            {
                message = "404 Not Found",
                currentDate = DateTime.Now
            });
        }
        
        
        public IActionResult BadRequestObjectResult()
        {
            return new BadRequestObjectResult(new
            {
                message = "400 Bad Request",
                currentDate = DateTime.Now
            });
        }
        
        #endregion

        #region :: Redirect Result ::

        public IActionResult RedirectResult()
        {
            return Redirect("https://www.valtech.com");
        } 

        #endregion

        #region :: Content Result ::

        public IActionResult Index()
        {
            return View();
        }
        
        
        public IActionResult PartialViewResult()
        {
            return PartialView();
        }


        public IActionResult JsonResult()
        {
            return Json(new
            {
                message = "JSONNN !!",
                date = DateTime.Now
            });
        }
        public IActionResult ContentResult()
        {
            return Content("");
        }

        #endregion 
        
    }
}