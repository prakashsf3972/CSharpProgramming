namespace ListDs
{
    public partial class  List<Type>
    {
       public void RemoveAt(int position)
       {
            for(int i=0;i<_count;i++)
            {
                if(i==position)
                {
                    _array[i]=_array[i+1];
                }
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