using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using System.Diagnostics;

namespace MathForGames2025
{
    internal class Engine
    {
        private const int _screenWidth = 800;
        private const int _screenHeight = 450;

        private static bool _applicationShouldClose;
        private static Icon[,] _buffer;
        private TestScene _testScene;
        private Stopwatch _stopwatch = new Stopwatch();

        private void Start()
        {
            Raylib.InitWindow(_screenWidth, _screenHeight, "Math For Games");
            Raylib.SetTargetFPS(60);
            _stopwatch.Start();

            _testScene = new TestScene();
            _buffer = new Icon[10, 10];
            _testScene.Start();
        }

        public static void Render(Icon icon, Vector2 position)
        {
            Raylib.DrawText(icon.Symbol, (int)position.X, (int)position.Y, 50, icon.IconColor);
        }

        private void Draw()
        {
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.BLACK);

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
            Vector2 test = new Vector2(8, 5);
            Vector2 test2 = test.GetNormalized();

            float magnitude = test2.GetMagnitude();

            Start();

            float currentTime = 0;
            float lastTime = 0;
            float deltaTime = 0;

            while (!_applicationShouldClose && !Raylib.WindowShouldClose())
            {
                currentTime = _stopwatch.ElapsedMilliseconds / 1000.0f;

                Console.WriteLine(currentTime);

                deltaTime = currentTime - lastTime;

                Draw();
                Update(deltaTime);

                lastTime = currentTime;
            }

            End();
        }
    }
}
