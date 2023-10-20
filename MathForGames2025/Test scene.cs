using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MathForGames2025
{
    internal class Test_scene : Scene
    {


        private Actor _testActor;
        private Player _testPlayer;
       

        public override void Start()
        {
            base.Start();
            Vector2 startPosition = new Vector2(0, 0);

            Icon playerIcon = new Icon { IconColor = Color.BLACK, Symbol = "OwO" };

            _testPlayer = new Player(playerIcon, startPosition);
            _testPlayer.Start();
        }

        public override void Draw()
        {
            base.Draw();
            _testPlayer.Draw();
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            _testPlayer.Update(deltaTime);
            
        }
    }
}
