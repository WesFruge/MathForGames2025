using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public struct Vector4
    {

        private float _x;
        private float _y;
        private float _z;
        private float _w;

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public float Z
        {
            get { return _z; }
            set { _z = value; }
        }

        public float W
        {
            get { return _w; }
            set { _w = value; }
        }

        public Vector4(float x, float y, float z, float w)
        {
            _x = x;
            _y = y;
            _z = z;
            _w = w;
        }

        public float GetMagnitude()
        {
            return MathF.Sqrt(X * X + Y * Y + Z * Z);
        }

        /// <summary>
        /// Change the size of this vector to have a magnitude of one.
        /// </summary>
        public void Normalize()
        {
            float magnitude = GetMagnitude();

            if (magnitude == 0)
            {
                return;
            }

            X /= magnitude;
            Y /= magnitude;
            Z /= magnitude;
        }

        /// <summary>
        /// Divide the vector by the magnitude to get a vector with
        /// a magnitude of 1.
        /// </summary>
        /// <returns>A new normalized vector without changing the original.</returns>
        public Vector4 GetNormalized()
        {
            float magnitude = GetMagnitude();

            if (magnitude == 0)
            {
                return new Vector4();
            }

            return new Vector4(X / magnitude, Y / magnitude, Z / magnitude, W);
        }

        public static float DotProduct(Vector4 a, Vector4 b)
        {
            //Ignore the w value
            return 0;
        }

        public static Vector4 CrossProduct(Vector4 a, Vector4 b)
        {
            //Set W to 0
            return new Vector4();
        }

        public static float GetDistance(Vector4 a, Vector4 b)
        {
            return 0;
            //Get a vector between a and b and get the magnitude.
        }

        /// <summary>
        /// Create overloaded operators for subtracting a vector 
        /// from another vector,
        /// multiplying a vector by a scalar
        /// and dividing a vector by a scalar.
        /// 
        /// Create a new class called player.
        /// The class should override the update function
        /// and change the position based on player input.
        /// </summary>

        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z, lhs.W + rhs.W);
        }


        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }

        public static Vector2 operator *(Vector2 lhs, float scalar)
        {
            return new Vector2(lhs.X * scalar, lhs.Y * scalar);
        }

        public static Vector2 operator /(Vector2 lhs, float scalar)
        {
            return new Vector2(lhs.X / scalar, lhs.Y / scalar);
        }
    }
}
