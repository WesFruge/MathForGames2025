
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;
using Raylib_cs;

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
        private bool _started;
        private Collider _collider;
        private Sprite _sprite;

        public Vector2 Position
        {
            get { return new Vector2(_transform.M02, _transform.M12); }
            set 
            {
                _transform.M02 = value.X;
                _transform.M12 = value.Y;
            }
        }

        public Vector2 Facing
        {
            get 
            {
                return new Vector2(_transform.M00, _transform.M10).GetNormalized();
            }
        }

        public Vector2 Scale
        {
            get
            {
                //Find the scale by getting the magnitude of the x and y columns in the transform matrix.
                float xAxisScale = new Vector2(_transform.M00, _transform.M01).GetMagnitude();
                float yAxisScale = new Vector2(_transform.M01, _transform.M11).GetMagnitude();

                return new Vector2(xAxisScale, yAxisScale);
            }
            set
            {
                //Get the current direction the x and y axis are facing and scale it by the desired scale on the x and y.
                Vector2 xAxis = new Vector2(_transform.M00, _transform.M01).GetNormalized() * value.X;
                Vector2 yAxis = new Vector2(_transform.M01, _transform.M11).GetNormalized() * value.Y;

                //Set the transform x column values to be the new x axis values that we just found.
                _transform.M00 = xAxis.X;
                _transform.M10 = xAxis.Y;

                //Set the transform y column values to be the new y axis values that we just found.
                _transform.M01 = yAxis.X;
                _transform.M11 = yAxis.Y;
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
            Position = position;
        }

        /// <param name="spritePath">The path the sprite will be at in the build. Ex: "Images/player.png"</param>
        /// <param name="position">The position of the sprite on the screen.</param>
        public Actor(string spritePath, Vector2 position)
        {

        }

        public bool CheckCollision(Actor other)
        {
            return AttachedCollider.CheckCollision(other.AttachedCollider);
        }

        public virtual void OnCollision(Actor other)
        {

        }

        public virtual void Start()
        {
            _started = true;
        }

        public virtual void Update(float deltaTime)
        {
        }

        public virtual void Draw()
        {
            Engine.Render(_icon, Position);

            if (AttachedCollider != null)
                AttachedCollider.Draw();

            //Draw the sprite if this actor has one
            if (_sprite != null)
                _sprite.Draw(_transform);
        }

        public virtual void End()
        {

        }
    }
}
