namespace WebAPIOdev.Model
{
    public class Methods
    {
        
        public List<Student> AddStudent()
        { 
            List<Student> students=new List<Student>();
            students.Add(new Student { StudentId = 1, Name = "Sevda Dikmen", Grade = 4, Department = "Computer Science" });
            students.Add(new Student { StudentId = 6, Name = "Çağla Neşe", Grade = 4, Department = "Physiotherapy" });
            students.Add(new Student { StudentId = 3, Name = "Helin Ülgen", Grade = 3, Department = "Energy Systems Engineering" });
            students.Add(new Student { StudentId = 7, Name = "Yasin Coşkun", Grade = 2, Department = "Computer Engineering" });
            students.Add(new Student { StudentId = 9, Name = "Metehan Sivri", Grade = 1, Department = "Computer Science" });
            students.Add(new Student { StudentId = 5, Name = "Oğuz Uyanık", Grade = 2, Department = "Statistics" });
            students.Add(new Student { StudentId = 4, Name = "Yiğit Kocatürk", Grade = 3, Department = "Business" });
            students.Add(new Student { StudentId = 2, Name = "Zeynep Erdem", Grade = 1, Department = "Computer Science" });
            return students;
                
        }
    }
}
