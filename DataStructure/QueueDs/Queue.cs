namespace QueueDs
{
    public class Queue<Type>
    {
        private int _count;
        public int Count { get {return _count;} }
        private int _capacity;
        private int _head;
        private int _tail;
        private Type[] _array;

        public Queue()
        {
            _count=0;
            _head=0;
            _tail=0;
            _capacity=4;
          _array=new Type[_capacity];
        }
        public Queue(int size)
        {
            _count=0;
            _capacity=size;
            _tail=0;
            _head=0;
        }
       public void Enqueue(Type data)
       {
        if(_tail==_capacity)
        {
            Growsize();
        }
        _array[_tail]=data;
        _tail++;
        _count++;
       }
       void Growsize()
       {
            _capacity*=2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
       }
       public Type Peek()
       {
        Type temp=default(Type);
         if(_tail>_head)
            {
                temp=_array[_head];
                return temp;
            }
            else{
                System.Console.WriteLine("Queue is Empty");
                return temp;
            }

       }
        public Type Dequeue()
        {
            Type temp=default(Type);
                if(_tail>_head)
                {
                    temp=_array[_head];
                    _head++;
                    _count--;
                    return temp;
                }
                else
                {
                    System.Console.WriteLine("Stack is Empty");
                    return temp;
                }
       }
       public bool Contains(Type data)
       {
            bool temp=true;
            for(int i=_head;i<_tail;i++)
            {
                if(_array[i].Equals(data))
                {
                    temp=false;
                }
            }
            if(temp==true)
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