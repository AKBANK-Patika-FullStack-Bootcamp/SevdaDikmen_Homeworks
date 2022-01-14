using Microsoft.AspNetCore.Mvc;
using DAL.Model;

namespace WebAPIOdev.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        DBMethods dbMethods = new DBMethods();
        Result result = new Result();


        [HttpGet]
        public List<Student> GetStudents()
        {
            return dbMethods.Students();
        }
    
        [HttpPost]
        public Result Post(Student student)
        {
            Student std = dbMethods.StudentControl(student.Name, student.Department);
            bool check = (std == null) ? true : false;
            if(check==true)
            {
                if (dbMethods.AddStudent(student) == true)
                {
                    result.Status = 1;
                    result.Message = "Yeni öðrenci eklendi.";
                }
                else
                {
                    result.Status = 0;
                    result.Message = "Öðrenci eklenemedi.";
                }
            }
            else
            {
                result.Status = 0;
                result.Message = "Öðrenci zaten var.";
            }    
            return result;
        }
     
        [HttpDelete]
        public Result Delete(int StudentId)
        {
            if (dbMethods.DeleteStudent(StudentId))
            {
                result.Status = 1;
                result.Message = "Öðrenci silindi.";
            }
                
            else
                result.Status = 0;
                result.Message = "Öðrenci bulunamadý.";
            return result;
        }


    }
}