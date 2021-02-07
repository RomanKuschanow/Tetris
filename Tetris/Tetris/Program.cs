using System;
using System.Threading;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Stick s = new Stick(4, 5, '*');
            s.Draw();
            Thread.Sleep(500);
            s.Hide();
            s.Rotate();
            s.Draw();
            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.LEFT);
            s.Draw();

            Console.ReadLine();
        }
    }
}
