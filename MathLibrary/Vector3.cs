using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public struct Vector3
    {
        private float _x;
        private float _y;
        private float _z;

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

        public Vector3(float x, float y, float z)
        {
            _x = x;
            _y = y;
            _z = z;
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
        public Vector3 GetNormalized()
        {
            float magnitude = GetMagnitude();

            if (magnitude == 0)
            {
                return new Vector3();
            }

            return new Vector3(X / magnitude, Y / magnitude, Z / magnitude);
        }

        public static float DotProduct(Vector3 a, Vector3 b)
        {
            return 0;
        }

        public static Vector3 CrossProduct(Vector3 a, Vector3 b)
        {
            return new Vector3();
        }

        public static float GetDistance(Vector3 a, Vector3 b)
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

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.X + rhs.X, lhs.Y + rhs.Y);
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
