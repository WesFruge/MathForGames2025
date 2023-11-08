using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace MathForGames2025
{
    internal class Enemy : Character
    {
        private Character _target;

        public Enemy(Character target, Icon icon, Vector2 position) : base(icon, position)
        {
            _target = target;
        }

        public override void Update(float deltaTime)
        {
            //Find a vector that goes from our enemy to our target.
            Vector2 enemyToTarget = _target.LocalPosition - LocalPosition;
            //Normalize that vector to find the direction to move in.
            Vector2 direction = enemyToTarget.GetNormalized();
            //Set our velocity to be that vector scaled by speed.
            Velocity = direction * 100f;

            base.Update(deltaTime);
        }
    }
}
