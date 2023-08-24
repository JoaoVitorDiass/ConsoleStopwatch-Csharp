using System;

namespace Stopwatch {
    class Program {
        static void Main(string[] args) {
            Menu();
        }

        static void Menu() {
            Console.Clear();
            Console.WriteLine("Informe o tempo do Stopwach: ");
            Console.WriteLine("Ex: 1s ou 1m");
            
            var data = Console.ReadLine().ToUpper();
            var type = char.Parse(data.Substring(data.Length - 1 ,1));
            var time = int.Parse(data.Substring(0, data.Length - 1));

            if (type == 'M') {
                time *= 60;
            }
            
            Start(time);
        }

        static void Start(int time) {
            while(time > 0) {
                Console.Clear();
                time--;
                Console.WriteLine("" + time);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado ...");
        }
    }
}