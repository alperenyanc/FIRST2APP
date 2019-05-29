using Microsoft.AspNetCore.Mvc;


namespace First2App.controller
{
    public class CourseController:Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}