using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;
using Raylib_cs;

namespace MathForGames2025
{
    internal class TestScene : Scene
    {
        private Player _testActor;
        private Enemy _testEnemy;

        public override void Start()
        {
            Vector2 startPosition = new Vector2(0, 0);
            Vector2 enemyStartPosition = new Vector2(400, 200);

            float maxAngle = 1;

            float dotProduct = 0.5f;

            //Convert dot product to radians.
            float radians = MathF.Acos(dotProduct);

            //Create the icons for the characters.
            Icon playerIcon = new Icon { IconColor = Color.BLUE, Symbol = "@" };
            Icon enemyIcon = new Icon { IconColor = Color.RED, Symbol = "E" };

            //Create the new actors for the scene.
            _testActor = new Player("Images/player.png", startPosition);

            _testActor.Scale = new Vector2(50, 50);
            _testEnemy = new Enemy(_testActor, enemyIcon, enemyStartPosition);

            CircleCollider playerCollider = new CircleCollider(50, _testActor);
            CircleCollider enemyCollider = new CircleCollider(50, _testEnemy);

            _testActor.AttachedCollider = playerCollider;
            _testEnemy.AttachedCollider = enemyCollider;

            AddActor(_testEnemy);
            AddActor(_testActor);

            base.Start();
        }
    }
}
