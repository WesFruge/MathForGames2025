using MathForGames2025;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
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
                return new Matrix4(1, 0, 0, 0,
                                   0, 1, 0, 0,
                                   0, 0, 1, 0,
                                   0, 0, 0, 1);
            }
        }

        public static Matrix4 CreateRotationZ(float radians)
        {
            return new Matrix4(1,0,0,0,
                               0,MathF.Cos(radians),-MathF.Sin(radians),0, 
                               0,MathF.Sin(radians), MathF.Cos(radians),0, 
                               0,0,0,1);
        }
        public static Matrix4 CreateRotationX(float radians)
        {
            return new Matrix4(MathF.Cos(radians),0,MathF.Sin(radians),0,
                               0,1,0,0,
                               -MathF.Sin(radians),0,MathF.Cos(radians),0,
                               0,0,0,1);
        }
        public static Matrix4 CreateRotationY(float radians)
        {
            return new Matrix4(MathF.Cos(radians),-MathF.Sin(radians),0,0,
                               MathF.Sin(radians),MathF.Cos(radians),0,0,
                               0,0,1,0,
                               0,0,0,1);
        }

        public static Matrix4 CreateTranslation(float x, float y, float z)
        {
            return new Matrix4(1, 0, 0, x,
                               0, 1, 0, y,
                               0, 0, 1, z,
                               0, 0, 0, 1);
        }

        public static Matrix4 CreateScale(float x, float y, float z)
        {
            return new Matrix4(x, 0, 0, 0,
                               0, y, 0, 0,
                               0, 0, z, 0,
                               0, 0, 0, 1);
        }


        public static Matrix4 operator +(Matrix4 a, Matrix4 b)
        {
            return new Matrix4(a.M00 + b.M00,
                               a.M01 + b.M01,
                               a.M02 + b.M02,
                               a.M03 + b.M03,
                               a.M10 + b.M10,
                               a.M11 + b.M11,
                               a.M12 + b.M12,
                               a.M13 + b.M13,
                               a.M20 + b.M20,
                               a.M21 + b.M21,
                               a.M22 + b.M22,
                               a.M23 + b.M23,
                               a.M30 + b.M30,
                               a.M31 + b.M31,
                               a.M32 + b.M32,
                               a.M33 + b.M33);
        }


        public static Matrix4 operator -(Matrix4 a, Matrix4 b)
        {
            return new Matrix4(a.M00 - b.M00,
                               a.M01 - b.M01,
                               a.M02 - b.M02,
                               a.M03 - b.M03,
                               a.M10 - b.M10,
                               a.M11 - b.M11,
                               a.M12 - b.M12,
                               a.M13 - b.M13,
                               a.M20 - b.M20,
                               a.M21 - b.M21,
                               a.M22 - b.M22,
                               a.M23 - b.M23,
                               a.M30 - b.M30,
                               a.M31 - b.M31,
                               a.M32 - b.M32,
                               a.M33 - b.M33);
        }

        public static Matrix4 operator *(Matrix4 a, Matrix4 b)
        {
            return new Matrix4((a.M00 * b.M00) + (a.M01 * b.M10) + (a.M02 * b.M20) + (a.M03 * b.M30),

                               (a.M00 * b.M01) + (a.M01 * b.M11) + (a.M02 * b.M21) + (a.M03 * b.M31),

                               (a.M00 * b.M02) + (a.M01 * b.M12) + (a.M02 * b.M22) + (a.M03 * b.M32), 

                               (a.M00 * b.M03) + (a.M01 * b.M13) + (a.M02 * b.M23) + (a.M03 * b.M33),
                               
                               (a.M10 * b.M00) + (a.M11 * b.M10) + (a.M12 * b.M20) + (a.M13 * b.M30),

                               (a.M10 * b.M01) + (a.M11 * b.M11) + (a.M12 * b.M21) + (a.M13 * b.M31),

                               (a.M10 * b.M02) + (a.M11 * b.M12) + (a.M12 * b.M22) + (a.M13 * b.M32),

                               (a.M10 * b.M03) + (a.M11 * b.M31) + (a.M12 * b.M32) + (a.M13 * b.M33),

                               (a.M20 * b.M00) + (a.M21 * b.M10) + (a.M22 * b.M20) + (a.M23 * b.M30),

                               (a.M20 * b.M01) + (a.M21 * b.M11) + (a.M22 * b.M21) + (a.M23 * b.M31),

                               (a.M20 * b.M02) + (a.M21 * b.M12) + (a.M22 * b.M22) + (a.M23 * b.M32),

                               (a.M20 * b.M03) + (a.M21 * b.M31) + (a.M22 * b.M32) + (a.M23 * b.M33),

                               (a.M30 * b.M00) + (a.M31 * b.M10) + (a.M32 * b.M20) + (a.M33 * b.M30),

                               (a.M30 * b.M01) + (a.M31 * b.M11) + (a.M32 * b.M21) + (a.M33 * b.M31),

                               (a.M30 * b.M02) + (a.M31 * b.M12) + (a.M32 * b.M22) + (a.M33 * b.M32),

                               (a.M30 * b.M03) + (a.M31 * b.M31) + (a.M32 * b.M32) + (a.M33 * b.M33));






        }


    }
}
