namespace Question2
{
    public class DepartmentDetails
    {
        public string DepartMentName { get; set; }
        public string  Degree { get; set; }

        public DepartmentDetails(string departMentName,string degree)
        {
            DepartMentName=departMentName;
            Degree=degree;
        }

    }
}