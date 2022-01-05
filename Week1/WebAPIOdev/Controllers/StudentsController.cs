using Microsoft.AspNetCore.Mvc;
using WebAPIOdev.Model;

namespace WebAPIOdev.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        Methods addStudent =new Methods();
        Result result = new Result();
        static List<Student> studentList = new List<Student>();

        [HttpGet]
        public List<Student> GetStudents()
        {
            studentList=addStudent.AddStudent();
            return studentList;
        }


        [HttpGet("{id}")]
        public Student GetStudentById(int id)
        {
            studentList = addStudent.AddStudent();
            Student student = new Student();
            student= studentList.FirstOrDefault(x => x.StudentId == id);
            return student;
        }


        [HttpPost]
        public Result Post(Student newStudent)
        {
            studentList = addStudent.AddStudent();
            bool studentCheck = studentList.Select(x => x.StudentId == newStudent.StudentId).Any();
            if (studentCheck == false)
            {
                studentList.Add(newStudent);
                result.Status = 1;
                result.Message = "Yeni öðrenci listeye eklendi.";
                result.StudentList = studentList;

            }
            else
            {
                result.Status = 0;
                result.Message = "Eklemeye çalýþtýðýnýz öðrenci listede var.";
                result.StudentList = studentList;
            }
            return result;



        }


        [HttpDelete("{id}")]
        public Result DeleteStudent(int id)
        {
            studentList = addStudent.AddStudent();
            Student? _student = studentList.Find(x => x.StudentId == id);
            if (_student != null)
            {
                studentList.Remove(_student);
                result.Status = 1;
                result.Message = "Öðrenci silindi";
                result.StudentList = studentList;
            }
            else
            {
                result.Status = 0;
                result.Message = "Öðrenci bulunamadý";
                result.StudentList= studentList;
            }
            return result;
           
            



        }


    }
}