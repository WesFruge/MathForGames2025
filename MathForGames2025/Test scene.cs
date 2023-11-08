using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;

namespace MathForGames2025
{
    internal class TestScene : Scene
    {

        private Actor _sun;
        private Actor _planet;
        private Actor _moon;
        private Player _testPlayer;
        private Enemy _testEnemy;

        public override void Start()
        {
           
            Vector2 startPosition = new Vector2(150, 150);
            Vector2 enemyStartPosition = new Vector2(400, 500);


            Icon playerIcon = new Icon { IconColor = Color.BLACK, Symbol = "|>=0=<|" };
            Icon enemyIcon = new Icon { IconColor = Color.RED, Symbol = ">-8v8-<" };


            _testPlayer = new Player("Images/player.png", startPosition);
            _testPlayer.Size = new Vector2(100, 100);


            _testEnemy = new Enemy(_testPlayer, 1f, 160f,enemyIcon, enemyStartPosition);

            CircleCollider playerCollider = new CircleCollider(50, _testPlayer);
            _testPlayer.AttachedCollider = playerCollider;


            CircleCollider enemyCollider = new CircleCollider(50, _testEnemy);
            _testEnemy.AttachedCollider = enemyCollider;


            Vector2 sunOrigin = new Vector2(0,0);
            Vector2 planetOrigin = new Vector2(100, 100); 
            Vector2 moonOrigin = new Vector2(100, 150);


            _sun = new Actor("Images/player.png", sunOrigin);
            _sun.Size = new Vector2(10, 10);
            CircleCollider sunCollider = new CircleCollider(50, _sun);
            _sun.AttachedCollider = sunCollider;
            _sun.Parent = _testPlayer;

            _planet = new Actor("Images/player.png", planetOrigin);
            _planet.Size = new Vector2(1,1);
            CircleCollider planetCollider = new CircleCollider(50, _planet);
            _planet.AttachedCollider = planetCollider;
            _planet.Parent = _sun;


            _moon = new Actor("Images/player.png", moonOrigin);
            _moon.Size = new Vector2(25, 25);
            CircleCollider moonCollider = new CircleCollider(50, _moon);
            _moon.AttachedCollider = moonCollider;
            _moon.Parent = _planet;


            AddActor(_testEnemy);
            AddActor(_testPlayer);
            AddActor(_sun);
            AddActor(_planet);
            AddActor(_moon);

            base.Start();

            float maxAngle = 1;

            float dotProduct = 0.5f;

            float radians = MathF.Acos(dotProduct);

            if(radians <= maxAngle)
            {
                maxAngle = 0;
            }


            _testPlayer.Start();
            _testEnemy.Start();
            _moon.Start();
            _planet.Start();
            _sun.Start();
        }

    }
}
