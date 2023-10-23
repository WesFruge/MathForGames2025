using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace MathForGames2025
{
    internal class Player : Character
    {
        private float _speed = 100.0f;
        public Player(Icon icon, Vector2 position) : base (icon, position) { }

        public override void Update(float deltaTime)
        {
            //char direction = Engine.GetInput();

            Vector2 direction = new Vector2();

            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                direction += new Vector2(0, -1);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                direction += new Vector2(0, 1);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                direction += new Vector2(-1, 0);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                direction += new Vector2(1, 0);
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT_SHIFT))
            {
                _speed = 200f;
            }
            else
            {
                _speed = 100f;
            }

            Velocity = direction.GetNormalized() * _speed;

            Position += Velocity * deltaTime;

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
