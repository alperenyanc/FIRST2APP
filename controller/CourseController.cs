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
          course.Description="alp ile sen öyle san! ilgili herşey";
          course.isPublisged=false;
          return View(course);
        
         }
         public IActionResult Apply(){
             return View();
         }
         [HttpPost]
         public IActionResult Apply(Student student){
             Respository.AddStudent(student);
             return View(student);

         }

    
    }
   
}