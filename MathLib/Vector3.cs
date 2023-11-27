using MathForGames2025;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public struct Vector3
    {
        private float _x;
        private float _y;
        private float _z;




        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        } 
        
        public float Z
        {
            get
            {
                return _z;
            }
            set
            {
                _z = value;
            }
        }

        public Vector3(float x, float y,float z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);

        }

        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);

        }

        public static Vector3 operator *(float scalar, Vector3 lhs)
        {
            return new Vector3(lhs.X * scalar, lhs.Y * scalar, lhs.Z * scalar);

        }  
        public static Vector3 operator *( Vector3 lhs, float scalar)
        {
            return new Vector3(lhs.X * scalar, lhs.Y * scalar, lhs.Z * scalar);

        }
        public static Vector3 operator /(Vector3 lhs, float scalar)
        {
            return new Vector3(lhs.X / scalar, lhs.Y / scalar, lhs.Z / scalar);

        }



        public float GetMagnitude()
        {
            return MathF.Sqrt(X * X + Y * Y + Z * Z);


        }

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

        public Vector3 GetNormalized()
        {
            float magnitude = GetMagnitude();
            if (magnitude == 0)
            {
                return new Vector3(0, 0, 0);
            }
            Vector3 temp = new Vector3(X / magnitude, Y / magnitude, Z/ magnitude);
            return temp;
        }

        public static Vector3 CrossProduct(Vector3 a, Vector3 b)
        {
            return new Vector3(a.Y * b.Z - a.Z * b.Y,
                              a.Z * b.X - a.X * b.Z,
                              a.X * b.Y - a.Y * b.X);
        }



        public static float DotProduct(Vector3 a, Vector3 b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }

        public static float GetDistance(Vector3 a, Vector3 b)
        {
            return (b - a).GetMagnitude();


        }




    }
}
