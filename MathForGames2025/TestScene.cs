﻿using System;
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

            //Create the icons for the characters.
            Icon playerIcon = new Icon { IconColor = Color.BLUE, Symbol = "@" };
            Icon enemyIcon = new Icon { IconColor = Color.RED, Symbol = "E" };

            //Create the new actors for the scene.
            _testActor = new Player(playerIcon, startPosition);
            _testEnemy = new Enemy(_testActor, enemyIcon, startPosition);

            AddActor(_testEnemy);
            AddActor(_testActor);

            base.Start();
        }
    }
}
