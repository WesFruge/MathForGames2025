using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using MathLib;

namespace MathForGames2025
{
    internal class CircleCollider : Collider
    {
        private float _radius;

        public float Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }


        public CircleCollider(float radius, Actor owner) :  base(0, owner)
        {
            _radius = radius;
            
        }

        

        public override bool CheckCollisionCircle(CircleCollider collider)
        {
            float radius = Radius + collider.Radius;
            float distance = Vector2.GetDistance(Owner.GlobalPosition, collider.Owner.GlobalPosition);
            if(radius >= distance)
            {
                return true;
            }

            return base.CheckCollisionCircle(collider);
        }

        public override void Draw()
        {
            Raylib.DrawCircleLines((int)Owner.LocalPosition.X, (int)Owner.LocalPosition.Y, Radius, Color.GREEN);
        }
    }
}
