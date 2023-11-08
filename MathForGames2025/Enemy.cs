using MathLib;
using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathForGames2025
{
    internal class Enemy : Character
    {
        private Character _target;
        private float _viewAngle;
        private float _distance;

        public Enemy(Character target, float viewAngle, float distance, Icon Icon, Vector2 position) : base(Icon,position)
        {
            _target = target;
            _viewAngle = viewAngle;
            _distance = distance;
        }



        public override void Draw()
        {
            Vector2 endPosition = GlobalPosition + Facing * 100;

            Raylib.DrawLine((int)GlobalPosition.X, (int)GlobalPosition.Y, (int)endPosition.X, (int)endPosition.Y, ActorIcon.IconColor);
            base.Draw();
        }



        public override void Update(float deltaTime)
        {

           


           Vector2 enemyToTarget = _target.GlobalPosition - GlobalPosition;

           Vector2 direction = enemyToTarget.GetNormalized();

           float dotProduct = Vector2.DotProduct(direction, Facing);

            float getDistance = Vector2.GetDistance(LocalPosition, _target.GlobalPosition);

            Icon newIcon = ActorIcon;

            newIcon.IconColor = Color.YELLOW;

            ActorIcon = newIcon;


           if(dotProduct <= _viewAngle || getDistance >= _distance)
           {
             return;
           }

            newIcon.IconColor = Color.RED;
            ActorIcon = newIcon;

            Velocity = direction * 75f;

           

            base.Update(deltaTime);
        }





    }
}
