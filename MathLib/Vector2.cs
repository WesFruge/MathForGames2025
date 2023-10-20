namespace MathLib
{
    public struct Vector2
    {
        private float _x;
        private float _y;


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

        public Vector2(float x, float y)
        {
            _x = x;
            _y = y;
        }

        public static Vector2 operator +(Vector2 lhs,Vector2 rhs)
        {
            return new Vector2(lhs.X + rhs.X, lhs.Y + rhs.Y);

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



        public float GetMagnitude()
        {
             return MathF.Sqrt(X*X + Y*Y);

           
        }

        public void Normalize()
        {
            
        }

        public Vector2 GetNormalized()
        {
           return GetMagnitude()/ Vector2;
        }



    }

}