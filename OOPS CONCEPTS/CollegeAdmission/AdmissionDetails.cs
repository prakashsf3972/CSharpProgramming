using System;
namespace CollegeAdmission
{
    public enum AdmissionStatus {Default,Admitted,Cancelled}
    public class AdmissionDetails
    {
        private static int s_admissionId=1000;
        public string  AdmissionId { get;  }
        public string StudentId { get; set; }
        public string DepartmentId { get; set; }
        public DateTime AdmissionDate { get; set; }
        public AdmissionStatus AdmissionStatus { get; set; }


        public AdmissionDetails(string studentId,String departMent,DateTime admissionDate,AdmissionStatus admissionstatus)
        {
            s_admissionId++;
            AdmissionId="AID"+s_admissionId;
            StudentId=studentId;
            DepartmentId=departMent;
            AdmissionDate=admissionDate;
            AdmissionStatus=admissionstatus;      
        }
        public AdmissionDetails(string data)
        {
            string[] values=data.Split(',');
            s_admissionId=int.Parse(values[0].Remove(0,3));
            AdmissionId=values[0];
            StudentId=values[1];
            DepartmentId=values[2];
            AdmissionDate=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            AdmissionStatus=Enum.Parse<AdmissionStatus>(values[4]);
        }
    }
}