namespace Interface
{
    public class Square : ICalculate
    {
        private int _number;
        public int Number{get{return Number;}set{_number=value;}} 

        public int Calculate()
        {
            _number*=_number;
            return _number;
        }
    }
}