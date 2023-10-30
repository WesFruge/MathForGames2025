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


        private Player _testPlayer;
        private Enemy _testEnemy;

        public override void Start()
        {
           
            Vector2 startPosition = new Vector2(0, 0);
            Vector2 enemyStartPosition = new Vector2(400, 500);


            Icon playerIcon = new Icon { IconColor = Color.BLACK, Symbol = "|>0<|" };
            Icon enemyIcon = new Icon { IconColor = Color.RED, Symbol = ">-8v8-<" };

            _testPlayer = new Player(playerIcon, startPosition);

            _testEnemy = new Enemy(_testPlayer, -1f, 50f,enemyIcon, enemyStartPosition);

            AddActor(_testEnemy);
            AddActor(_testPlayer);
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
        }

    }
}
