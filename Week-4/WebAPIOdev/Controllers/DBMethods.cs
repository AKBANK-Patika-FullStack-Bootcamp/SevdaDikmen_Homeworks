using DAL.Model;
using EFLibCore;

namespace WebAPIOdev.Controllers
{
    public class DBMethods
    {
        private StudentContext context = new StudentContext(); 

        //İsim ve bölümüne göre öğrenci var mı kontrol ediliyor.
        public Student StudentControl(string Name, string Department, int StudentId=0)
        {
            Student student = new Student();
            if(!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Department))
            {
                student = context.Students.FirstOrDefault(x => x.Name == Name && x.Department == Department);
            }
            else if (StudentId > 0)
            {
                student = context.Students.FirstOrDefault(x => x.StudentId == StudentId);
            }
            return student;
        }

        //Yeni öğrenci ekleniyor.
        public bool AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return true;
        }

        //StudentControl metoduyla databasede olup olmadığı kontrol edilen öğrenci siliniyor.
        public bool DeleteStudent(int StudentId)
        {
            context.Students.Remove(StudentControl("", "", StudentId));
            context.SaveChanges();
            return true;

        }

        //Databasedeki bütün öğrenciler listeleniyor.
        public List<Student> Students()
        {
            List<Student> studentList = new List<Student>();
            studentList = context.Students.ToList();
            return studentList;
        }
    }
}
