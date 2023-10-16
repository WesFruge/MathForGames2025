
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace MathForGames2025
{
    struct Icon
    {
        private char _symbol;
        private ConsoleColor _color;

        public char Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }    
        }

        public ConsoleColor Color
        {
            get { return _color; }
            set { _color = value; }
        }
    }

    internal class Actor
    {
        private Icon _icon;
        private Vector2 _position;

        public Vector2 Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public Actor(Icon icon, Vector2 position)
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
