namespace da
{
    interface ISetAdapter<T>
    {
        ISet<T> ToSet(T[] array); 
        T[] ToArray(ISet<T> set); 
    }
    public class SetAdapter<T> : ISetAdapter<T>
    {
        public ISet<T> ToSet(T[] array)
        {
            ISet<T> set = new HashSet<T>(array); 
            return set;
        }

        public T[] ToArray(ISet<T> set)
        {
            T[] array = new T[set.Count]; 
            set.CopyTo(array, 0); 
            return array;
        }
    }
}