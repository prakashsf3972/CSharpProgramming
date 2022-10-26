namespace Question2
{
    public class RackInfo:DepartmentDetails
    {
        public int RackNumber { get; set; }
        public int ColumnNumber { get; set; }

        public RackInfo(string departMentName,string degree,int rackNumber,int columnNumber):base(departMentName,degree)
        {
            RackNumber=rackNumber;
            ColumnNumber=columnNumber;
        }

    }
}