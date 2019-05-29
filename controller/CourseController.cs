using First2App.Models;
using Microsoft.AspNetCore.Mvc;


namespace First2App.controller
{
    public class CourseController:Controller
    {
        public IActionResult Index(){
            return View();
        }
        public IActionResult Details(){
         var course=new Course();
         course.Name="Alp";
          course.Description="alp ileilgili herşey";
          course.isPublisged=true;
          return View(course);
        
         }

    
    }
   
}