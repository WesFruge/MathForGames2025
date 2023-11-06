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
        private Matrix3 _transform = Matrix3.Identity;
        private Matrix3 _translation = Matrix3.Identity;
        private Matrix3 _rotation = Matrix3.Identity;
        private Matrix3 _scale = Matrix3.Identity;
        
        private bool _started;
        private Collider _collider;
        private Sprite _sprite;
        

        /// <summary>
        /// Constructor for an instance of an Actor
        /// </summary>
        /// <param name="icon">what will visually represent the Actor</param>
        /// <param name="position">starting location for the Actor</param>
        
        public Actor(Icon icon, Vector2 position)
        {
            _icon = icon;
            Position = position;
            
        }
        public Actor(string spritePath, Vector2 position)
        {
            _sprite = new Sprite(spritePath);
            Position = position;

        }


        public bool CheckCollision(Actor other)
        {
            return AttachedCollider.CheckCollision(other.AttachedCollider);
        }


        public virtual void OnCollison(Actor other)
        {
            
        }



        public Vector2 Position
        {
            get
            {
                return new Vector2(_transform.M02, _transform.M12);
            }
            set
            {
                _transform.M02  = value.X;
                _transform.M12 = value.Y;
            }
        }

        public bool Started
        {
            get { return _started; }
        }


        public Vector2 Facing
        {
            get { return new Vector2(_rotation.M00, _rotation.M10).GetNormalized(); }
            
 
        }

        public Vector2 Size
        {
            get
            {

                return new Vector2(_scale.M00, _scale.M11);
            }

            set
            {
                _scale.M00 = value.X;
                _scale.M11 = value.Y;

            }
        }



        public Icon ActorIcon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        public Collider AttachedCollider
        {
            get { return _collider; }
            set { _collider = value; }
        }


        public virtual void Start()
        {
            _started = true;
        }

        public virtual void Update(float deltaTime)
        {
            UpdateTransforms();
        }

        public virtual void Draw()
        {
            Engine.Render(_icon, Position);
            if(AttachedCollider != null)
            {
                AttachedCollider.Draw();
            }  
            if (_sprite != null)
            {
                _sprite.Draw(_transform);
            }    
        }

        public virtual void End()
        {

        }

        public void Translate(float x, float y)
        {
            _translation *= Matrix3.CreateTranslation(x, y);
        }

        public void SetTranslation(float x, float y)
        {
            _translation = Matrix3.CreateTranslation(x, y);
        }

        public void Scale(float x, float y)
        {
            _scale *= Matrix3.CreateScale(x, y);
        } 
        public void SetScale(float x, float y)
        {
            _scale = Matrix3.CreateScale(x, y);
        } 
        public void Rotate(float radians)
        {
            _rotation *= Matrix3.CreateRotation(radians);
        } 
        public void SetRotate(float radians)
        {
            _rotation = Matrix3.CreateRotation(radians);
        } 
     
        private void UpdateTransforms()
        {
            _transform = _translation * _rotation * _scale;
        }



    }
}
