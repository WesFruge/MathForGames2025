using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathForGames2025
{
    internal class Engine
    {
        private static bool _applicationShouldClose;
        private static Icon[,] _buffer;
        private TestScene _testScene;

        private void Start()
        {
            _testScene = new TestScene();
            _buffer = new Icon[10, 10];
            _testScene.Start();
        }

        public static void Render(Icon icon, Vector2 position)
        {  
            if (position.Y >= _buffer.GetLength(0) || position.Y < 0)
            {
                return;
            }
            else if (position.X >= _buffer.GetLength(1) || position.X < 0)
            {
                return;
            }

            _buffer[(int)position.Y, (int)position.X] = icon;
        }

        private void Draw()
        {
            Console.Clear();
            _buffer = new Icon[10, 10];

            _testScene.Draw();

            for (int y = 0; y < _buffer.GetLength(0); y++)
            {
                for (int x = 0; x < _buffer.GetLength(1); x++)
                {
                    if (_buffer[y, x].Symbol == '\0')
                    {
                        _buffer[y, x].Symbol = '+';
                    }

                    Console.ForegroundColor = _buffer[y, x].Color;
                    Console.Write(_buffer[y, x].Symbol);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
        }

        private void Update()
        {
            _testScene.Update();
        }

        private void End()
        {
            _testScene.End();
        }

        public static char GetInput()
        {
            return Console.ReadKey(true).KeyChar;
        }

        public static void EndApplication()
        {
            _applicationShouldClose = true;
        }

        public void Run()
        {
            Start();

            while (!_applicationShouldClose)
            {
                Draw();
                Update();
            }

            End();
        }
    }
}
