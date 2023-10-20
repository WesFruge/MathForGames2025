using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using System.Diagnostics;
using MathLib;

namespace MathForGames2025
{
    internal class Engine
    {
        private static bool _applicationShouldClose;
        private const int _screenHeight = 1000;
        private const int _screenWidth = 1000;

        private static Icon[,] _buffer;

        private Test_scene  _testScene;

        private Stopwatch _stopwatch = new Stopwatch();

        
        

        private void Start()
        {
            Raylib.InitWindow(_screenWidth, _screenHeight, "Math For Games");
            Raylib.SetTargetFPS(0);
            _testScene = new Test_scene();
            _buffer = new Icon [10, 10];
            _testScene.Start();
            _stopwatch.Start();
            

        }

        public static void Render(Icon icon , Vector2 position)
        {
            Raylib.DrawText(icon.Symbol, (int)position.X, (int)position.Y, 250, icon.IconColor);
        }


        private void Draw()
        {
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.DARKPURPLE);

            _testScene.Draw();

            Raylib.EndDrawing();
        }
        private void Update(float deltaTime)
        {
            _testScene.Update(deltaTime);
        }

        private void End()
        {
            _testScene.End();
            Raylib.CloseWindow();
        }

        public static void EndApplication()
        {
            _applicationShouldClose = true;
        }

        public void Run()
        {
            Start();

            Vector2 testVector = new Vector2();

            testVector X = 2;
            testVector Y = 3;

            float currentTime = 0;
            float lastTime = 0;
            float deltaTime = 0;
            

            while (!_applicationShouldClose && !Raylib.WindowShouldClose())
            {
                currentTime = _stopwatch.ElapsedMilliseconds / 1000;

                deltaTime = currentTime - lastTime;

                Draw();
                Update(deltaTime);

                lastTime = currentTime;
                
            }

            End();
        }
    }
}
