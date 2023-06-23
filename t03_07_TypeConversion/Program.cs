namespace t03_07_TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            int iCast = 2;
            byte bCast = (byte)iCast;
            Console.WriteLine(bCast);

            string number = "1234";
            int num = Convert.ToInt32(number);
            Console.WriteLine(num);

            try
            {
                byte bConvert = Convert.ToByte(number);
                Console.WriteLine(bConvert);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to byte.");
            }

            try
            {
                string str = "true";
                bool bBool = Convert.ToBoolean(str);
                Console.WriteLine(bBool);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}