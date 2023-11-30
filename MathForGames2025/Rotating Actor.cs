using MathLib;
using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathForGames2025
{
    internal class Rotating_Actor : Actor
    {
        private float _rotate;
        

        public Rotating_Actor(float Rotate, string spritePath, Vector2 position) : base (spritePath, position)
        {
            _rotate = Rotate;
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            Rotate(deltaTime);


            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
                Scale(1.001f, 1.001f);
            }
            else if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                Scale(.991f, .991f);
            }
        }

    }
}
