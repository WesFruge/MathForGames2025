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
        private Actor _ship1;
        private Actor _Ship2;
        private Player _testPlayer;
        private ProjectileSpawner _hiya;
        public override void Start()
        {
           
            Vector2 startPosition = new Vector2(10, 10);
            _testPlayer = new Player("Images/player.png", startPosition);
            _testPlayer.Size = new Vector2(50, 50);

            CircleCollider playerCollider = new CircleCollider(50, _testPlayer);
            _testPlayer.AttachedCollider = playerCollider;

            Vector2 sunOrigin = new Vector2(500,500);
            Vector2 planetOrigin = new Vector2(5, 5); 
            Vector2 moonOrigin = new Vector2(2, 2);


            _sun = new Blackhole(1, "Images/yikes.png", sunOrigin);
            _sun.Size = new Vector2(50, 50);
            CircleCollider sunCollider = new CircleCollider(100, _sun);
            _sun.AttachedCollider = sunCollider;
            
            
            
            
            _ship1 = new Rotating_Actor(1,"Images/player.png", planetOrigin);
            _ship1.Size = new Vector2(1,1);
            CircleCollider planetCollider = new CircleCollider(130, _ship1);
            _ship1.AttachedCollider = planetCollider;
            _ship1.Parent = _sun;
            
          


            _Ship2 = new Rotating_Actor(1,"Images/enemy.png", moonOrigin);
            _Ship2.Size = new Vector2(1, 1);
            CircleCollider moonCollider = new CircleCollider(50, _Ship2);
            _Ship2.AttachedCollider = moonCollider;
            _Ship2.Parent = _ship1;

            
            
            AddActor(_testPlayer);
            AddActor(_sun);
            AddActor(_ship1);
            AddActor(_Ship2);

            base.Start();

            float maxAngle = 1;

            float dotProduct = 0.5f;

            float radians = MathF.Acos(dotProduct);

            if(radians <= maxAngle)
            {
                maxAngle = 0;
            }

          Matrix4 ree = new Matrix4(0, 0, 0, 1,
                                    0, 0, 2, 0,
                                    0, 3, 0, 0,
                                    4, 0, 0, 0);

            Matrix4 tee = new Matrix4(0, 0, 0, 1,
                                      0, 0, 2, 0,
                                      0, 3, 0, 0,
                                      5, 0, 0, 0);

            Matrix4 dee = ree * tee;

            Console.WriteLine(ree * tee);

            

        }

    }
}
