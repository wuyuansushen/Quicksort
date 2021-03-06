using System;
using System.Collections;
using System.Collections.Generic;

//Ascend
namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input Section
            #region
            int total;
            total=Convert.ToInt32(Console.ReadLine());

            string[] inputReal = Console.ReadLine().Split(' ');

            List<int> input = new List<int>();

            for(int i=0;i<total;i++)
            {
                input.Add(Convert.ToInt32(inputReal[i]));
            }
            #endregion

        }

        static IEnumerable<int> LeftYield(List<int> ListInput,int Start,int End)
        {
            int iLeft;
            for(iLeft=Start; iLeft<End;iLeft++)
            {
                if (ListInput[iLeft] >= ListInput[Start])
                    yield return iLeft;
            }
        }
        static IEnumerable<int> RightYield(List<int> ListInput,int Start,int End)
        {
            int iRight;
            for(iRight=End-1; iRight>Start;iRight--)
            {
                if (ListInput[iRight] < ListInput[Start])
                    yield return iRight;
            }
        }
        //Full List reference
        static void Process(ref List<int> listInput,int Start,int End)
        {
            #region
            /*
            int total;
            total=Convert.ToInt32(Console.ReadLine());

            string[] inputReal = Console.ReadLine().Split(' ');

            List<int> input = new List<int>();

            for(int i=0;i<total;i++)
            {
                input.Add(Convert.ToInt32(inputReal[i]));
            }
            */
            #endregion

            #region
            /*int flag = listInput[Start];
            int iLeft,iRight;
            for(iLeft=Start;iLeft<End;iLeft++)
            {
                if (listInput[iLeft] > flag)
                    break;
            }
            for(iRight=End-1;iRight>=Start;iRight--)
            {
                if (listInput[iRight] <= flag)
                    break;
            }*/
            #endregion
            foreach(int LeftInt in LeftYield(listInput,Start,End))
            {
                foreach(int RightInt in RightYield(listInput,Start,End))
                {
                    if(LeftInt<RightInt)
                    {
                        int tmp = listInput[LeftInt];
                        listInput[LeftInt] = listInput[RightInt];
                        listInput[RightInt] = tmp;
                        break;
                    }
                    else
                    {
                        int tmp = listInput[Start];
                        int middle = (Start + End) / 2;
                        listInput[Start]=
                    }
                }
            }
            if (iLeft<iRight)
            {
                int tmp = listInput[iLeft];
                listInput[iLeft] = listInput[iRight];
                listInput[iRight] = tmp;
            }
            else
            {
                int tmp = input[iLeft];
                //flag value
                input[iLeft]=input[0];
                input[0]=tmp;
            }

        }
    }
}
