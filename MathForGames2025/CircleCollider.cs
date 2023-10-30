using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if(collider.ColliderID == 1)
            {
                
            }



            return base.CheckCollisionCircle(collider);
        }






















    }
}
