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
        private static char[,] _buffer;
        private TestScene _testScene;

        private void Start()
        {
            _testScene = new TestScene();
            _buffer = new char[10, 10];
            _testScene.Start();
        }

        public static void Render(char icon, Vector2 position)
        {
            _buffer[(int)position.Y, (int)position.X] = icon;
        }

        private void Draw()
        {
            _testScene.Draw();

            for (int y = 0; y < _buffer.GetLength(0); y++)
            {
                for (int x = 0; x < _buffer.GetLength(1); x++)
                {
                    if (_buffer[y, x] == '\0')
                    {
                        _buffer[y, x] = ' ';
                    }

                    Console.Write(_buffer[y, x]);
                }
                Console.WriteLine();
            }

            Console.ReadKey(true);
        }

        private void Update()
        {

        }

        private void End()
        {

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
