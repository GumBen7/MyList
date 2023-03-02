namespace Lists {
    class Program {
        static void Main(string[] args) {
            int data;
            SimpleList<int> list = new SimpleList<int>();
            do {
                data = int.Parse(Console.ReadLine());
                if (data == 0) break;
                list.Push(data);
            } while (data != 0);            
            while (!list.IsEmpty()) {
                Console.WriteLine(list.Pop());
            }
        }
    }
}