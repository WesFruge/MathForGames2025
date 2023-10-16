using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MathForGames2025
{
    internal class Player : Actor
    {

        char playerInput = '\0';

        public Player(char icon, Vector2 position) :base(icon, position)
        {
            
        }
        public override void Start()
        {
            base.Start();
        }

        public override void Update()
        {
            base.Update();

            playerInput = Console.ReadKey().KeyChar;

            if (playerInput == 'w')
            {
                Position = Position + new Vector2(0, -1);
            }
            if (playerInput == 's')
            {
                Position = Position + new Vector2(0, 1);
            }
            if (playerInput == 'd')
            {
                Position = Position + new Vector2(1, 0);
            }
            if (playerInput == 'a')
            {
                Position = Position + new Vector2(-1, 0);
            }
        }
        public override void Draw()
        {
            base.Draw();
        }

        public override void End()
        {
            base.End();
        }
    }
}
