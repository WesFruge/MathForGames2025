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

        public Player(Icon icon, Vector2 position) : base(icon, position) { }

        public Player(string spritePath, Vector2 position) : base(spritePath, position) { }

        public override void OnCollision(Actor other)
        {
            base.OnCollision(other);

            _speed = 20;
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
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

            LocalPosition += Velocity * deltaTime;

            if (LocalPosition.X >= 800)
            {
                LocalPosition = new Vector2(0, LocalPosition.Y);
            }
            if (LocalPosition.Y >= 450)
            {
                LocalPosition = new Vector2(LocalPosition.X, 0);
            }

            if (LocalPosition.X < 0)
            {
                LocalPosition = new Vector2(800, LocalPosition.Y);
            }
            if (LocalPosition.Y < 0)
            {
                LocalPosition = new Vector2(LocalPosition.X, 450);
            }
        }
    }
}
