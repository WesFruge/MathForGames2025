using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using MathLib;

namespace MathForGames2025
{
    internal class Player : Character
    {
        private float _speed = 100.0f;

        public Player(Icon icon, Vector2 position) :base(icon, position)
        {
            
        }
        public override void Start()
        {
            base.Start();
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);

            Vector2 direction = new Vector2();

            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                direction += new Vector2(0, 1);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                direction += new Vector2(0, -1);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                direction += new Vector2(1, 0);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                direction += new Vector2(-1, 0);
            }

            if(Raylib.IsKeyDown(KeyboardKey.KEY_LEFT_SHIFT))
            {
                _speed = 200f;
            }
            else
            {
                _speed = 100f;
            }



            Velocity = direction.GetNormalized() * _speed;

            
        }
        public override void Draw()
        {
            base.Draw();
        }

        public override void End()
        {
            base.End();
        }
    }
}
