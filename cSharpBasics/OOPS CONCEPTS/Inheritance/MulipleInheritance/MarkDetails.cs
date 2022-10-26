namespace MulipleInheritance
{
    public interface IMarkDetails //Inheritance
    {
        //NO FIELD
         int Physics { get; set; } //property
         
         int Chemistry { get; set; }
         int Maths { get; set; }
         int Total { get; set; }
         double Average { get; set; }

        //No COnstructor
         void GetMark(int physics,int chemistry,int maths);

         void Calculate();//Method Declaration Only allowed

         void ShowMark();

        


    }
}