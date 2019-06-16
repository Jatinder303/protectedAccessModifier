namespace protectedAccessModifier
{
    class Y : X
    {
        // Members of Y can access 'x' 
        public int getX()
        {
            return x;
        }
    }
}
