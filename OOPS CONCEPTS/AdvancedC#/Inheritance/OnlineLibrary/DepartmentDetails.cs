namespace OnlineLibrary
{
    public class DepartmentDetails
    {
        public string DepartMentName { get; set; }
        public string Degree { get; set; }
        
        public DepartmentDetails(string departMentName,string degree)
        {
            DepartMentName=departMentName;
            Degree=degree;
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("DepartMentName: "+DepartMentName);
            System.Console.WriteLine("Degree: "+Degree);
        }
    }
}