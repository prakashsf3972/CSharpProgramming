namespace StackDs
{
    public class Stack <type>
    {
       
        private int _count;
        public int Count { get { return _count; }}
        public int _capacity;
        private type[] _array;
        public Stack()
        {
            _count=0;
            _capacity=4;
            _array=new type[_capacity];
        }
        public Stack(int size)
        {
            _count=0;
            _capacity=size;
            _array=new type[_capacity];
        }
        public void Push(type data)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            _array[_count]=data;
            _count++;
        }
        void GrowSize()
        {
            _capacity*=2;
            type[] temp=new type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;

        }
        public type Peek()
        {
            int top=_count;
           type temp=default(type);
           if(Count>=0)
           {
                temp=_array[top-1];
                return temp;
           } 
           else
           {
            System.Console.WriteLine("Stack Empty");
            return temp;
           }
        }

        public type Pop()
        {
            type temp=default(type);
            if(Count>0)
            {
                temp=_array[_count-1];
                --_count;
                return temp;

            }
            else
            {
                System.Console.WriteLine("Stack Empty");
                return temp;
            }
        }
        public bool Contains(type data)
        {
            bool flag=true;
            for(int i=0;i<_count;i++)
            {
                if(_array[i].Equals(data))
                {
                    return true;
                }
                
            }
            if(flag==true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }
}