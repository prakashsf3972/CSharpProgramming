namespace OperationOverLoading
{
    public class Box
    {
        private double _length{ get; set; }
        private double _breath { get; set; }
         private double _height { get; set; }

        public Box()
        {

        }

        public Box(double length,double breath,double height)
        {
            _length=length;
            _breath=breath;
            _height=height;
        }

        public double CalculateVolume()
        {
            return _breath* _length* _height;
        }

        public static Box operator +(Box obj1,Box obj2)//Overload +operator to add two box objects
        {
            Box box=new Box();
            box._length=obj1._length+obj2._length;
            box._breath=obj1. _breath+obj2. _breath;
            box._height=obj1._height+obj2._height;
            return box;

        }
        public Box Add(Box obj1,Box obj2)
        {
            Box box=new Box();
            box._length=obj1._length+obj2._length;
            box._breath=obj1. _breath+obj2. _breath;
            box._height=obj1._height+obj2._height;
            return box;


        }
    }
}