﻿using System;
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
        public Player (string spritePath, Vector2 position) :base(spritePath, position)
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

            if(Raylib.IsKeyDown(KeyboardKey.KEY_E))
            {
                Rotate(5 * deltaTime);
            }
            else if (Raylib.IsKeyDown(KeyboardKey.KEY_Q))
            {
                Rotate(-5 * deltaTime);
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
                Scale(2,2);
            }
            else if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                Scale(-0.5f,-0.5f);
            }

            Icon newIcon = ActorIcon;

            newIcon.IconColor = Color.GREEN;

            ActorIcon = newIcon;


            Velocity = direction.GetNormalized() * _speed;

            Translate(Velocity.X, Velocity.Y);
        }

        public override void OnCollison(Actor other)
        {

            Icon newIcon = ActorIcon;

            newIcon.IconColor = Color.PINK;

            ActorIcon = newIcon;

            base.OnCollison(other);
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
