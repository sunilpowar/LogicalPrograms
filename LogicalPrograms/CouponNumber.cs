using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class CouponNumber
    {
        public void couponsNumbers()
        {
            Console.WriteLine("Enter the number of distinct coupons you want to generate :");
            int N = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] coupomCollection = new int[N];
            for (int i = 0; i <= N - 1;)
            {
                int coupon = random.Next(1001, 2001);
                if ((coupon.CompareTo(coupomCollection[i])) == 0)
                {
                    continue;
                }
                else if ((coupon.CompareTo(coupomCollection[i])) != 0)
                {
                    int[] coupunCollection = new int[i];
                    coupomCollection[i] = coupon;
                    i++;
                }
            }
            foreach (int i in coupomCollection)
            {
                Console.WriteLine("Coupons Collection : " + i + " ");
            }
        }
    }
}
