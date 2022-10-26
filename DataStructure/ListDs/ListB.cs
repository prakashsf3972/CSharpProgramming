using System.Collections;
namespace ListDs
{
    public partial class List<Type>:IEnumerable,IEnumerator
    {
        int i;
        public IEnumerator GetEnumerator()
        {
            i=-1;
            return(IEnumerator)this;
        }  
        public bool MoveNext()
        {
            if(i<_count-1)
            {
                ++i;
                return true;
            }
            Reset();//Reset Position value is no element in list
            return false;
        }  
        public void Reset()//Reset i for next turn
        {
            i=-1;
        }
        public object Current //Returns the Current array Position Value
        {
            get {return _array[i]; }
        }

    }
}