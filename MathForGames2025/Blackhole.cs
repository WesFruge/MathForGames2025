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



            Character character = other as Character;
            if(character == null)
            {
                return;
            }

            blackholetoactor = GlobalPosition - other.GlobalPosition;
            blackholetoactor.Normalize();
            blackholetoactor *= 100f;
            character.Velocity += blackholetoactor;

            float distance = Vector2.GetDistance(GlobalPosition, other.GlobalPosition);

            if(distance < 100)
            {
                Engine.RemoveActorFromScene(other);
            }

        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
           

           
           
        }
    }
}
