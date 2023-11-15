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

        public static Vector2 operator *(float scalar, Vector2 lhs)
        {
            return new Vector2(lhs.X * scalar, lhs.Y * scalar);

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
            float magnitude = GetMagnitude();
            
            if(magnitude == 0)
            {
                return;
            }

            X /= magnitude;
            Y /= magnitude;
        }

        public Vector2 GetNormalized()
        {
            float magnitude = GetMagnitude();
            if (magnitude == 0)
            {
                return new Vector2(0,0);
            }
            Vector2 temp = new Vector2(X / magnitude, Y / magnitude);
            return temp;
        }

        public static float DotProduct(Vector2 a, Vector2 b)
        {
          return a.X * b.X + a.Y * b.Y;
        }

        public static float GetDistance(Vector2 a, Vector2 b)
        {
            return (b - a).GetMagnitude(); 
            
            
        }

    }

}