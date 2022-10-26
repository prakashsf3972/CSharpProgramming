namespace ArrayListLibrary
{
    public partial class ArrayList
    {
        private int _count;
        public int Count{get {return _count;}}
        private int _capacity;
        public int Capacity{get {return _capacity;}}
        private dynamic[] _array;
        public dynamic this[int i] {get {return _array[i];} set{_array[i]=value;}}

        public ArrayList()
        {
            _count=0;
            _capacity=4;
             _array=new dynamic[_capacity];
        }
        public ArrayList(int size)
        {
          _count=0;
          _capacity=size;
          _array=new dynamic[_capacity];  
        }
        public void Add(dynamic data)
        {
            if(_capacity==_count)
            {
                GrowSize();
            }
            _array[_count]=data;
            _count++;
        }
        void GrowSize()
        {
           _capacity*=2;
           dynamic[] temp=new dynamic[_capacity]; 
           for(int i=0;i<_count;i++)
           {
            temp[i]=_array[i];
           }
           _array=temp;
        }
        public void AddRange(ArrayList list)
        {
            _capacity=list.Count+_count;
            dynamic[] temp=new dynamic[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            for(int i=0;i<list.Count;i++)
            {
                temp[i+_count]=list._array[i];
            }
            _array=temp;
            _count+=list.Count;
        }
        public void Insert(int position,dynamic data)
        {
           ++_capacity;
           dynamic[] temp=new dynamic[_capacity];
           for(int i=0;i<_count;i++)
           {
                if(i<position)
                {
                    temp[i]=_array[i];
                }
                else if(i==position)
                {
                    temp[i]=data;
                }
                else
                {
                    temp[i]=_array[i-1];
                }   
           } 
           _array=temp; 
        }
        public void RemoveAt(int position)
        {
          for(int i=position;i<_count;i++)
          {
            _array[i]=_array[i+1];
          }  
        }
        public int Indexof(dynamic data)
        {
            int temp=0;
            int i;
            for(i=0;i<_count;i++)
            {
                if(data==_array[i])
                {
                    temp=1;
                }
                else
                {
                    temp=0;
                }
            }
            if(temp==1)
            {
                return i;
            }
            else
            {
                return 0;
            }
        }
        public void Remove(dynamic data)
        {
          int position=Indexof(data);
          RemoveAt(position);
        }
        public bool Contains(dynamic data)
        {
            int i;
            int temp=0;
            for(i=0;i<_count;i++)
            {
                if(_array[i]==data)
                {
                    temp=1;
                }
                else
                {
                    temp=0;
                }
            }
            if(temp==1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
        
    }
}