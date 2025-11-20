namespace CSP6
{
    class MatrixUtils
    {
        public static void PrintMatrix(double[,] matrixm)
        {
            int rows = matrixm.GetLength(0);
            int cols = matrixm.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrixm[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static double[,] Add(double[,] A, double[,] B)
        {
            int rows = A.GetLength(0);
            int cols = A.GetLength(1);
            double[,] result = new double[rows, cols];
            if (rows != B.GetLength(0) || cols != B.GetLength(1))
            {
                throw new ArgumentException("Macierze są innej długości");
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = A[i, j] + B[i, j];
                }
            }
            
            return result;
        }
        public static double[,] Odd(double[,] A, double[,] B)
        {
            int rows = A.GetLength(0);
            int cols = A.GetLength(1);
            double[,] result = new double[rows, cols];
            if (rows != B.GetLength(0) || cols != B.GetLength(1))
            {
                throw new ArgumentException("Macierze są innej długości");
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = A[i, j] - B[i, j];
                }
            }

            return result;
        }
        public static double[,] Transpose(double[,] A)
        {
            int rows = A.GetLength(0);
            int cols = A.GetLength(1);
            double[,] result = new double[cols, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[j, i] = A[i, j];
                }
            }
            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            double [,] A = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            double[,] B = {
                { 6, 11, 2 },
                { 2, 4, 8 }
            };
            MatrixUtils.PrintMatrix(A); Console.WriteLine("\t +"); MatrixUtils.PrintMatrix(B); Console.WriteLine("\t ="); MatrixUtils.PrintMatrix(MatrixUtils.Add(A, B));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            MatrixUtils.PrintMatrix(A); Console.WriteLine("\t -"); MatrixUtils.PrintMatrix(B); Console.WriteLine("\t ="); MatrixUtils.PrintMatrix(MatrixUtils.Odd(A, B));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            MatrixUtils.PrintMatrix(MatrixUtils.Transpose(A)); Console.WriteLine(); Console.WriteLine(); MatrixUtils.PrintMatrix(MatrixUtils.Transpose(B));
        }
    }
}