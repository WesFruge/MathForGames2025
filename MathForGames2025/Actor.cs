
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace MathForGames2025
{

    internal class Actor
    {
        private char _icon;
        private Vector2 _position;
        public Actor(char icon, Vector2 position)
        {
            _icon = icon;
            _position = position;
        }

        public virtual void Start()
        {

        }

        public virtual void Update()
        {

        }

        public virtual void Draw()
        {
            Engine.Render(_icon, _position);
        }

        public virtual void End()
        {

        }
    }
}
