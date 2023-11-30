using MathLib;
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
        private static Actor[] _actorsToRemove = new Actor[0];
        private static bool _applicationShouldClose;
        private const int _screenHeight = 1000;
        private const int _screenWidth = 1000;
        private static TestScene _anyword;

        private static Icon[,] _buffer;

        private static Scene _currentScene;

        private Stopwatch _stopwatch = new Stopwatch();



        private void Start()
        {
            Raylib.InitWindow(_screenWidth, _screenHeight, "Math For Games");
            Raylib.SetTargetFPS(0);
            _currentScene = new TestScene();
          
            _currentScene.Start();
            _stopwatch.Start();


          
           
 
        }

        public static Scene GetCurrentScene()
        {
            return _currentScene;
        }

        public static void Render(Icon icon, Vector2 position)
        {
            Raylib.DrawText(icon.Symbol, (int)position.X, (int)position.Y, 50, icon.IconColor);
        }



        public static Actor AddActorToScene(Actor actorToSpawn)
        {
            _currentScene.AddActor(actorToSpawn);

            return actorToSpawn;
            
        }

        /// <summary>
        /// Adds actor to a list of actors to remove, that is cleared after update is called.
        /// </summary>
        /// <param name="actor">A refrence to the actor to remove from the current scene.</param>
        public static void RemoveActorFromScene(Actor actor)
        {
            if (_actorsToRemove == null)
            {
                _actorsToRemove = new Actor[0];
            }

            //4 actor slots
            Actor[] temp = new Actor[_actorsToRemove.Length + 1];

            for (int i = 0; i < _actorsToRemove.Length; i++)
            {
                temp[i] = _actorsToRemove[i];
            }

            //4
            temp[_actorsToRemove.Length] = actor;

            _actorsToRemove = temp;
        }

        private void RemoveActors()
        {
            for(int i = 0; i < _actorsToRemove.Length; i++)
            {
                _currentScene.Remove(_actorsToRemove[i]);
            }

            _actorsToRemove = new Actor[0];
        }

        private void Draw()
        {
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.DARKPURPLE);

            _currentScene.Draw();

            Raylib.EndDrawing();
        }
        private void Update(float deltaTime)
        {
            _currentScene.Update(deltaTime);
            RemoveActors();
        }

        private void End()
        {
            _currentScene.End();
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
            Vector2 test = new Vector2(14, 2);
            Vector2 test2 = test.GetNormalized();

            Matrix3 b = new Matrix3(10, 0, 0, 0, 4, 0, 0, 0,6);
            Matrix3 a = new Matrix3(6, 0, 0, 0, 5, 0, 0, 0, 4);

            Matrix3 c = b * a;

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
