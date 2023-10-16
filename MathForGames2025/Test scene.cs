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

            _testPlayer = new Player('0', startPosition);
            _testPlayer.Start();
        }

        public override void Draw()
        {
            base.Draw();
            _testPlayer.Draw();
        }

        public override void Update()
        {
            base.Update();
            _testPlayer.Update();
        }
    }
}
