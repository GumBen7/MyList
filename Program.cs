﻿namespace Lists {
    class Program {
        static void Main(string[] args) {
            int data = int.Parse(Console.ReadLine());
            SimpleList<int> list = new SimpleList<int>(data);
            while (data != 0) {
                data = int.Parse(Console.ReadLine());
                if (data == 0) break;
                list.Push(data);
            }
            while (!list.IsEmpty()) {
                Console.WriteLine(list.Pop());
            }
        }
    }
}