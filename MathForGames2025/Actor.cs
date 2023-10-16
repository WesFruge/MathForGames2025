using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MathForGames2025
{
    internal class Actor
    {
        private char _icon;
        private Vector2 _position;

        /// <summary>
        /// Constructor for an instance of an Actor
        /// </summary>
        /// <param name="icon">what will visually represent the Actor</param>
        /// <param name="position">starting location for the Actor</param>
        
        public Actor(char icon, Vector2 position)
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
