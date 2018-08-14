using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class Search
    {
        private int[,] matrix = null;
        /// <summary>
        /// 初始化矩阵
        /// </summary>
        /// <param name="matrix"></param>
        private void InitMatrix(ref int[,] matrix)
        {
            matrix = new int[9, 9];

            for (int j = 0; j < 9; j++)
            {

                if (j == 1 || j == 5)
                    matrix[0, j] = 1;
                else
                    matrix[0, j] = 0;


                if (j == 0 || j == 2 || j == 6 || j == 8)
                    matrix[1, j] = 1;
                else
                    matrix[1, j] = 0;

                if (j == 1 || j == 3 || j == 8)
                    matrix[2, j] = 1;
                else
                    matrix[2, j] = 0;

                if (j == 2 || j == 4 || j == 6 || j == 7 || j == 8)
                    matrix[3, j] = 1;
                else
                    matrix[3, j] = 0;

                if (j == 3 || j == 5 || j == 7)
                    matrix[4, j] = 1;
                else
                    matrix[4, j] = 0;

                if (j == 0 || j == 4 || j == 6)
                    matrix[5, j] = 1;
                else
                    matrix[5, j] = 0;

                if (j == 1 || j == 3 || j == 5 || j == 7)
                    matrix[6, j] = 1;
                else
                    matrix[6, j] = 0;

                if (j == 3 | j == 4 || j == 6)
                    matrix[7, j] = 1;
                else
                    matrix[7, j] = 0;

                if (j == 1 || j == 2 || j == 3)
                    matrix[8, j] = 1;
                else
                    matrix[8, j] = 0;


            }

        }
        /// <summary>
        /// 深度遍历
        /// </summary>
        public List<string> DFS()
        {
            InitMatrix(ref matrix);
            var stackrow = new Stack<int>();
            var stackcolumn = new Stack<int>();
            int column = 0;
            var matrixnew = new List<string>();
            double length = Math.Sqrt(matrix.Length);
            for (int i = 0; i < length; i++)
            {
                for (int j = column; j < length; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        stackrow.Push(i);
                        stackcolumn.Push(j);
                        matrixnew.Add(i.ToString() + "," + j.ToString());
                        //当满足条件时，交换当前行列的值，退出该列循环
                        int mid = 0;
                        mid = i;
                        i = j-1 ;
                        j = mid+1;
                        column = j;
                        break;
                    }
                    if (j == length - 1)
                    {
                        stackrow.Pop();
                        i = stackrow.Peek()-1;
                        stackcolumn.Pop();
                        column = stackcolumn.Peek() + 1;
                        break;
                    }

                }
            }
            return matrixnew;
        }
    }
}
