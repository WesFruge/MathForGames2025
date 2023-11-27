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
            CircleCollider sunCollider = new CircleCollider(250, _sun);
            _sun.AttachedCollider = sunCollider;
            
            
            
            
            _planet = new Rotating_Actor(1,"Images/player.png", planetOrigin);
            _planet.Size = new Vector2(1,1);
            CircleCollider planetCollider = new CircleCollider(50, _planet);
            _planet.AttachedCollider = planetCollider;
            _planet.Parent = _sun;
            
          


            _moon = new Rotating_Actor(1,"Images/enemy.png", moonOrigin);
            _moon.Size = new Vector2(1, 1);
            CircleCollider moonCollider = new CircleCollider(50, _moon);
            _moon.AttachedCollider = moonCollider;
            _moon.Parent = _planet;

            _hiya = new ProjectileSpawner(_planet, new Vector2(0,0), 100, "Images/Planet06");
            
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

            _sun.Update(1900);
            _planet.Update(1900);
            _moon.Update(1900);

            _testPlayer.Start();
            _moon.Start();
            _planet.Start();
            _sun.Start();
        }

    }
}
