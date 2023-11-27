using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;

namespace MathForGames2025
{
    internal class Blackhole : Rotating_Actor
    {

        public Blackhole(float Rotate, string spritePath, Vector2 position) : base(Rotate,spritePath, position)
        {
            
        }

        public override void OnCollision(Actor other)
        {
            base.OnCollision(other);
            Vector2 blackholetoactor;

            other.Translate(-1, -1);

            Character character = (Character)other;
            blackholetoactor = GlobalPosition - other.GlobalPosition;
            blackholetoactor.Normalize();
            blackholetoactor *= 5f;
            character.Velocity += blackholetoactor;
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
           
           
           
        }
    }
}
