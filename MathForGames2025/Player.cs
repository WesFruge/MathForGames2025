using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace MathForGames2025
{
    internal class Player : Actor
    {
        public Player(Icon icon, Vector2 position) : base (icon, position) { }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            //char direction = Engine.GetInput();

            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                Position += new Vector2(0, -100) * deltaTime;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                Position += new Vector2(0, 100) * deltaTime;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                Position += new Vector2(-100, 0) * deltaTime;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                Position += new Vector2(100, 0) * deltaTime;
            }


            if (Position.X >= 800)
            {
                Position = new Vector2(0, Position.Y);
            }
            if (Position.Y >= 450)
            {
                Position = new Vector2(Position.X, 0);
            }
        }
    }
}
