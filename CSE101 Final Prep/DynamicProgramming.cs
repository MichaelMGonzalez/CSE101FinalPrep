using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE101_Final_Prep
{
    class DynamicProgramming
    {
        public static int FindEditDistance(String str1, String str2)
        {
            String newStr1 = " " + str1;
            String newStr2 = " " + str2;
            int[,] dpMatrix = new int[newStr1.Length, newStr2.Length];
            for (int i = 0; i < newStr1.Length; i++)
                dpMatrix[i, 0] = i;
            for (int j = 0; j < newStr2.Length; j++)
                dpMatrix[0, j] = j;
            for( int i = 1; i < newStr1.Length; i++) {
                for (int j = 1; j < newStr2.Length; j++)
                {
                    int dist = 1;
                    if (newStr1[i] == newStr2[j])
                        dist = 0;
                    dpMatrix[i,j] = Math.Min(dpMatrix[i - 1, j] ,dpMatrix[i, j - 1]) + 1;
                    dpMatrix[i, j] = Math.Min(dpMatrix[i, j], dpMatrix[i - 1, j - 1] + dist);
                }
            }
            return dpMatrix[str1.Length, str2.Length];
        }
        public static String FindGreatestSubsequence(String str1, String str2)
        {
            String retVal = "";
            int[,] dpMatrix = new int[str2.Length + 1, str1.Length + 1];
            String[,] retMatrix = new String[str2.Length + 1, str1.Length + 1];
            for (int j = 0; j <= str1.Length; j++)
            {
                dpMatrix[0, j] = 0;
                retMatrix[0, j] = "";
            }
            for (int i = 0; i <= str2.Length; i++)
            {
                dpMatrix[i, 0] = 0;
                retMatrix[i, 0] = "";
            }
            int max = 0;
            for (int j = 0; j < str1.Length; j++)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    if (dpMatrix[i, j + 1] > dpMatrix[i + 1, j])
                        retMatrix[i + 1, j + 1] = retMatrix[i, j + 1];
                    else
                        retMatrix[i + 1, j + 1] = retMatrix[i + 1, j] ;
                    dpMatrix[i + 1, j + 1] = Math.Max(dpMatrix[i, j + 1], dpMatrix[i + 1, j]);
                    if (str1[j] == str2[i])
                    {
                        if (dpMatrix[i + 1, j + 1] < dpMatrix[i, j] + 1)
                            retMatrix[i + 1, j + 1] = retMatrix[i, j] + str1[j];
                        dpMatrix[i + 1, j + 1] = Math.Max(dpMatrix[i + 1, j + 1], dpMatrix[i, j] + 1);
                        if (dpMatrix[i + 1, j + 1] > max)
                        {
                            retVal = retMatrix[i + 1, j + 1];
                        }
                    }
                }
            }
            return retVal;
        }
    }
}
