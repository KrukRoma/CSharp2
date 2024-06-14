namespace CSharp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3
            int[] A = new int[5];
            double[,] B = new double[3, 4];
            Random rand = new Random();

            Console.WriteLine("Enter 5 elements for array A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("A[" + i + "] = ");
                A[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = rand.NextDouble() * 10;
                }
            }

            Console.WriteLine("\nArray A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }

            Console.WriteLine("\n\nArray B:");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i, j].ToString("F2") + " ");
                }
                Console.WriteLine();
            }

            double maxElement = A[0];
            double minElement = A[0];
            double sum = 0;
            double product = 1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > maxElement) maxElement = A[i];
                if (A[i] < minElement) minElement = A[i];
                sum += A[i];
                product *= A[i];
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] > maxElement) maxElement = B[i, j];
                    if (B[i, j] < minElement) minElement = B[i, j];
                    sum += B[i, j];
                    product *= B[i, j];
                }
            }

            int sumEvenA = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0) sumEvenA += A[i];
            }

            double sumOddColumnsB = 0;
            for (int j = 1; j < B.GetLength(1); j += 2)
            {
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    sumOddColumnsB += B[i, j];
                }
            }

            Console.WriteLine("\nMax element: " + maxElement.ToString("F2"));
            Console.WriteLine("Min element: " + minElement.ToString("F2"));
            Console.WriteLine("Total sum of all elements: " + sum.ToString("F2"));
            Console.WriteLine("Total product of all elements: " + product.ToString("F0"));
            Console.WriteLine("Sum of even elements in array A: " + sumEvenA);
            Console.WriteLine("Sum of elements in odd columns of array B: " + sumOddColumnsB.ToString("F2"));

            //4
            const int SIZE = 5;
            int[,] array = new int[SIZE, SIZE];
            Random random = new Random();

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    array[i, j] = random.Next(-100, 101);
                }
            }

            int minElement1 = array[0, 0];
            int maxElement1 = array[0, 0];
            int minRowIndex = 0, minColIndex = 0;
            int maxRowIndex = 0, maxColIndex = 0;

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (array[i, j] < minElement1)
                    {
                        minElement1 = array[i, j];
                        minRowIndex = i;
                        minColIndex = j;
                    }
                    if (array[i, j] > maxElement1)
                    {
                        maxElement1 = array[i, j];
                        maxRowIndex = i;
                        maxColIndex = j;
                    }
                }
            }

            int startRow = Math.Min(minRowIndex, maxRowIndex) + 1;
            int endRow = Math.Max(minRowIndex, maxRowIndex) - 1;
            int startCol = Math.Min(minColIndex, maxColIndex) + 1;
            int endCol = Math.Max(minColIndex, maxColIndex) - 1;

            int suma = 0;
            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    suma += array[i, j];
                }
            }

            Console.WriteLine("Two-dimensional array:");
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nMinimum element: {minElement1} at position [{minRowIndex},{minColIndex}]");
            Console.WriteLine($"Maximum element: {maxElement1} at position [{maxRowIndex},{maxColIndex}]");
            Console.WriteLine($"Sum of elements between the minimum and maximum elements: {suma}");

            //5
            int[] array1 = { 10, 7, 12, 6, 9, 15, 5, 8, 10, 12 }; 

            int minElement2 = array1[0];
            for (int i = 1; i < array1.Length; i++)
            {
                if (array1[i] < minElement2)
                {
                    minElement2 = array1[i];
                }
            }

            int count = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == minElement2 + 5)
                {
                    count++;
                }
            }

            Console.WriteLine("Array:");
            foreach (var element in array1)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Minimum element: {minElement2}");
            Console.WriteLine($"Number of elements differing from minimum by 5: {count}");
        }
    }
}
