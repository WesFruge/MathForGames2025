using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using MathLib;

namespace MathForGames2025
{
    struct Icon
    {
        private string _symbol;
        private Color _color;

        public string Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }
        public Color IconColor
        {
            get { return _color; }
            set { _color = value; }
        }
    }
    internal class Actor
    {
        private Icon _icon;
        private Vector2 _position;
        private Vector2 _facing = new Vector2(1,0);

        /// <summary>
        /// Constructor for an instance of an Actor
        /// </summary>
        /// <param name="icon">what will visually represent the Actor</param>
        /// <param name="position">starting location for the Actor</param>
        
        public Actor(Icon icon, Vector2 position)
        {
            _icon = icon;
            _position = position;
            
        }

        public Vector2 Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }

        public Vector2 Facing
        {
            get { return _facing; }
            set { _facing = value; }
        }

        public Icon ActorIcon
        {
            get { return _icon; }
            set { _icon = value; }
        }



        public virtual void Start()
        {
            
        }

        public virtual void Update(float deltaTime)
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
