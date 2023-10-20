using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using MathLib;

namespace MathForGames2025
{
    internal class Player : Actor
    {

        char playerInput = '\0';

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

            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                Position += new Vector2(0, -100) * deltaTime;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                Position += new Vector2(0, 100) * deltaTime;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                Position += new Vector2(100, 0) * deltaTime;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                Position += new Vector2(-100, 0) * deltaTime;
            }
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
