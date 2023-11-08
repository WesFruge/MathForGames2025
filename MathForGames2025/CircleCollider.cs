using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

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

        public CircleCollider(float radius, Actor owner) : base(0, owner)
        {
            _radius = radius;
        }

        public override bool CheckCollisionCircle(CircleCollider collider)
        {
            return false;
        }

        public override void Draw()
        {
            Raylib.DrawCircleLines((int)Owner.LocalPosition.X, (int)Owner.LocalPosition.Y, Radius, Color.GREEN);
        }
    }
}
