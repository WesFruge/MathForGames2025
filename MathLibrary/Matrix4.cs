using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public struct Matrix4
    {
        public float M00, M01, M02, M03,
                     M10, M11, M12, M13,
                     M20, M21, M22, M23,
                     M30, M31, M32, M33;

        public Matrix4(float m00, float m01, float m02, float m03,
                       float m10, float m11, float m12, float m13,
                       float m20, float m21, float m22, float m23,
                       float m30, float m31, float m32, float m33)
        {
            M00 = m00;
            M01 = m01;
            M02 = m02;
            M03 = m03;

            M10 = m10;
            M11 = m11;
            M12 = m12;
            M13 = m13;

            M20 = m20;
            M21 = m21;
            M22 = m22;
            M23 = m23;

            M30 = m30;
            M31 = m31;
            M32 = m32;
            M33 = m33;
        }

        public static Matrix4 Identity
        {
            get
            {
                //return identity
            }
        }

        public static Matrix4 CreateRotationZ(float radians)
        {

        }

        public static Matrix4 CreateRotationY(float radians)
        {

        }

        public static Matrix4 CreateRotationX(float radians)
        {

        }

        public static Matrix4 CreateTranslation(float x, float y, float z)
        {

        }

        public static Matrix4 CreateScale(float x, float y, float z)
        {

        }

        public static Matrix4 operator +(Matrix4 a, Matrix4 b)
        {

        }

        public static Matrix4 operator -(Matrix4 a, Matrix4 b)
        {

        }

        public static Matrix4 operator *(Matrix4 a, Matrix4 b)
        {

        }

        public static Vector4 operator *(Matrix4 a, Vector4 b)
        {

        }
    }
}
