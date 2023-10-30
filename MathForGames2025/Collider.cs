using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathForGames2025
{
    internal class Collider
    {
        private int _colliderID;
        private Actor _owner;

        public Actor Owner
        {
            get { return _owner; }
        }

        public int ColliderID
        {
            get { return _colliderID; }
        }








        public Collider(int colliderID, Actor owner)
        {
            _colliderID = colliderID;
            _owner = owner;
        }

        public bool CheckCollision(Collider collider)
        {
            if(collider.ColliderID == 0)
            {
                CircleCollider circleCollider = (CircleCollider)collider;


                return CheckCollisionCircle(circleCollider);
            }
            return false;
        }


        public virtual bool CheckCollisionCircle(CircleCollider collider)
        {
            return false;
        }





    }
}
