using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AktifVehiclePlanningSystem.Controllers
{
    public class RolesController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Policy = "RequireManager")]
        public IActionResult Manager() 
        { 
            return View(); 
        }
        [Authorize(Policy = "RequireAdmin")]
        public IActionResult Admin() 
        { 
            return View(); 
        } 
    }
}
