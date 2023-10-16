using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MathForGames2025
{
    internal class Engine
    {
        private static bool _applicationShouldClose;

        private static char[,] _buffer;

        private Test_scene  _testScene;

       

        private void Start()
        {
            _testScene = new Test_scene();
            _buffer = new char [10, 10];
            _testScene.Start();


        }

        public static void Render(Icon icon , Vector2 position)
        {
            _buffer[(int)position.Y, (int)position.X] = icon;
        }


        private void Draw()
        {
            Console.Clear();
            _buffer = new Icon[10, 10];
            _testScene.Draw();

            for(int y = 0; y < _buffer.GetLength(0); y++)
            {
                for(int x = 0; x < _buffer.GetLength(1); x++)
                {
                    if (_buffer[y,x].Symbol == '\0')
                    {
                        _buffer[y, x].Symbol = '+';
                    }

                    Console.Write(_buffer[y, x]);
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
