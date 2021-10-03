using System;

namespace tasklar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            int n = 21;

            if (n % 3 == 0 && n % 7 == 0)

            {
                Console.WriteLine(true);
            }
            
            else
            {
                
                Console.WriteLine(false);
 
            }
            #endregion
            #region
            n və m(n<m) ədədləri arasında neçə tək ədəd olduğunu tapın
            int n = 20;
            int m = 60;
            int count = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 3 == 0)

                {

                    count++;

                }
            }
            Console.WriteLine(count);
            #regionend
             











































































        }
    }
}
