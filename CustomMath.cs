namespace CustomMath
{
    interface IMathLibInterface
    {
        public int AddNumber();
        public int SubNumber();
    }
    class MathLib:IMathLibInterface
    {
       readonly int num1, num2;

        public MathLib(int Num1,  int Num2)
        {
            num1 = Num1;
            num2 = Num2;
        }
        public int AddNumber ()
        {
            return num1 + num2;
        }


        public int SubNumber()
        {
            if (num1 > num2)
            {
                return num1 - num2;
            }
            else
            {
                return num2 - num1;
            }
        }
    }
}