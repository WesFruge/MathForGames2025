
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
        private Sprite _sprite;
        private Actor _parent;

        private Matrix3 _globalTransform = Matrix3.Identity;
        private Matrix3 _localTransform = Matrix3.Identity;
        private Matrix3 _translation = Matrix3.Identity;
        private Matrix3 _rotation = Matrix3.Identity;
        private Matrix3 _scale = Matrix3.Identity;

        private bool _started;
        private Collider _collider;

        public Matrix3 LocalTransform
        {
            get { return _localTransform; }
        }

        public Matrix3 GlobalTransform
        {
            get { return _globalTransform; }
        }

        public Vector2 GlobalPosition
        {
            get { return new Vector2(_globalTransform.M02, _globalTransform.M12); }
            set
            {
                _globalTransform.M02 = value.X;
                _globalTransform.M12 = value.Y;
            }
        }

        public Vector2 LocalPosition
        {
            get { return new Vector2(_translation.M02, _translation.M12); }
            set 
            {
                _translation.M02 = value.X;
                _translation.M12 = value.Y;
            }
        }

        public Actor Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        public Vector2 Facing
        {
            get 
            {
                return new Vector2(_rotation.M00, _rotation.M10).GetNormalized();
            }
        }

        /// <summary>
        /// The current width and height of the actor.
        /// </summary>
        public Vector2 Size
        {
            get
            {
                //Returns a new vector that represents the length of the x axis and the length of the y axis.
                return new Vector2(_scale.M00, _scale.M11);
            }
            set
            {
                //Set the scale matrix values to be the values given.
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

        public Icon GetIcon()
        {
            return _icon;
        }

        public bool Started
        {
            get { return _started; }
        }

        public Actor(Icon icon, Vector2 position)
        {
            _icon = icon;
            LocalPosition = position;
        }

        /// <param name="spritePath">The path the sprite will be at in the build. Ex: "Images/player.png"</param>
        /// <param name="position">The position of the sprite on the screen.</param>
        public Actor(string spritePath, Vector2 position)
        {
            _sprite = new Sprite(spritePath);
            LocalPosition = position;
        }


        public virtual void OnCollision(Actor other)
        {

        }


        /// <summary>
        /// Constructor for an instance of an Actor
        /// </summary>
        /// <param name="icon">what will visually represent the Actor</param>
        /// <param name="position">starting location for the Actor</param>
   

        public bool CheckCollision(Actor other)
        {
            if(AttachedCollider == null)
            {
                return false;
                
            }
            if(other.AttachedCollider == null)
            {
                return false;
                
            }
            return AttachedCollider.CheckCollision(other.AttachedCollider);
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
            Engine.Render(_icon, GlobalPosition);
            if(AttachedCollider != null)
            {
                AttachedCollider.Draw();
            }  
            if (_sprite != null)
            {
                _sprite.Draw(GlobalTransform);
            }    
        }

        public virtual void End()
        {

        }

        /// <summary>
        /// Move the actor by the given amount start from it's current position.
        /// </summary>
        /// <param name="x">The amount to move on the x axis.</param>
        /// <param name="y">The amount to move on the y axis.</param>
        public void Translate(float x, float y)
        {
            _translation *= Matrix3.CreateTranslation(x, y);
        }

        /// <summary>
        /// Sets the actors position to be the given values.
        /// </summary>
        /// <param name="x">The new x axis position.</param>
        /// <param name="y">The new y axis position.</param>
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
            _localTransform = _translation * _rotation * _scale;

            if(_parent != null)
            {
                _globalTransform = Parent.GlobalTransform * _localTransform;

            }
            else
            {
                _globalTransform = _localTransform;
            }    

        }



    }
}
