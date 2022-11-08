using System;

namespace Coin_amounts
{
    class Program
    {
        /*
         * В Англии валютой являются фунты стерлингов £ и пенсы. В обращении есть восемь монет:     
         * 1p, 2p, 5p, 10p, 20p, 50p, £1 (100p) и £2 (200p).  £2 возможно составить следующим образом:      
         * 1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p
         * Сколькими разными способами можно составить £2, используя любое количество монет?
         */
                                      
        
        static void Main(string[] args)
        {
            int TOTAL = 200;
            int[] COINS = { 1, 2, 5, 10, 20, 50, 100, 200 };
            int[,] ways = new int[COINS.Length + 1, TOTAL + 1];

            ways[0, 0] = 1;
            for (int i = 0; i < COINS.Length; i++)
            {
                int coin = COINS[i];
                for (int j = 0; j <= TOTAL; j++)
                    ways[i + 1, j] = ways[i, j] + (j >= coin ? ways[i + 1, j - coin] : 0);
            }
            Console.WriteLine("Result : " + ways[COINS.Length, TOTAL]);
        }
    }
}
