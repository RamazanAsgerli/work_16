namespace task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CustomGenericList<int> list = new CustomGenericList<int>(5);
            list.Add(15);
            list.Add(10);
            list.Add(20);
            
            int find = list.Find(x=> x == 15);
            Console.WriteLine(find);
        }
    }
    public class CustomGenericList<T>
    {
        public List<T> arr;
        public int Capacity { get; set; }
        public int Count { get; set; }
        public T this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

        public CustomGenericList(int capacity)
        {
            Capacity = capacity;
            Count = 0;
            arr = new List<T>(Capacity);
        }



        public void Add(T nums)
        {
            if (Count < Capacity)
            {
                arr.Add(nums);
                Count++;
            }
            else
            {
                Console.WriteLine("Tutum doludu");
            }

        }

        public T Find(Predicate<T> method)
        {
            foreach (var item in arr)
            {
                if (method(item))
                {
                    return item;
                }
            }
            return default(T);
        }

        public List<T> FindAll(Predicate<T> predicate)
        {
            return arr.FindAll(predicate);
        }

        public T Remove(Predicate<T> predicate)
        {
            foreach (var item in arr)
            {
                if (predicate(item))
                {
                    arr.Remove(item);
                }
            }
            return default(T);
        }

        public int RemoveAll(Predicate<T> predicate)
        {
            foreach (var item in arr)
            {
                arr.RemoveAll(predicate);
            }
            return Count;
        }

        public void Foreach(Action<T> action)
        {
            foreach (T item in arr)
            {
                action(item);
            }
        }


    }
}
