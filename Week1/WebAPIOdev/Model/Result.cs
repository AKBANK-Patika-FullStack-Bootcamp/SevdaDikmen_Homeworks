namespace WebAPIOdev.Model
{
    public class Result
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public List<Student>? StudentList { get; set; }

    }
}
