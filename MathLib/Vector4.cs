﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public struct Vector4
    {
        private float _x;
        private float _y;
        private float _z;
        private float _w;




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
        
        public float W
        {
            get
            {
                return _w;
            }
            set
            {
                _w = value;
            }
        }

        public Vector4(float x, float y, float z, float w)
        {
            _x = x;
            _y = y;
            _z = z;
            _w = w;
        }

        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z, lhs.W + rhs.W);

        }

        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z, lhs.W - rhs.W);

        }

        public static Vector4 operator *(float scalar, Vector4 lhs)
        {
            return new Vector4(lhs.X * scalar, lhs.Y * scalar, lhs.Z * scalar, lhs.W * scalar);

        }
        public static Vector4 operator /(Vector4 lhs, float scalar)
        {
            return new Vector4(lhs.X / scalar, lhs.Y / scalar, lhs.Z / scalar, lhs.W / scalar);

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

        public Vector4 GetNormalized()
        {
            float magnitude = GetMagnitude();
            if (magnitude == 0)
            {
                return new Vector4(0, 0, 0, 0);
            }
            Vector4 temp = new Vector4(X / magnitude, Y / magnitude, Z / magnitude, W);
            return temp;
        }



        public static float DotProduct(Vector4 a, Vector4 b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z* b.Z + a.W * b.W;
        }

        public static float GetDistance(Vector4 a, Vector4 b)
        {
            return (b - a).GetMagnitude();


        }



    }
}
