namespace StaticElements
{
    public static class StudentInfo
    {
       public static int s_registerId;
       public static string name { get; set; }
       static StudentInfo()
       {
        s_registerId=1;
        name="Ravi";
       }
       public static void Display()
       {
        System.Console.WriteLine("Register Number ="+s_registerId);
        System.Console.WriteLine("Name is "+name);
       }
  
    }
}