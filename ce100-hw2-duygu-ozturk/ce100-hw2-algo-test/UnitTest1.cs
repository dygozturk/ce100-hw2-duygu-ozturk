using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw2_duygu_ozturk;
using ce100_hw2_algo_test;

namespace ce100_hw2_algo_test
{
    [TestClass]
    public class UnitTest1
    {
        //MatrixMulRecTest
        [TestMethod]
        public void MatrixMulRecTest1()
        {
            int row1 = 2, col1 = 2,
            row2 = 2, col2 = 2;
            int[,] A = {{5, 8},
                       {12, 1} };
            Class1.i = 0; Class1.j = 0; Class1.k = 0;

            int[,] B = {{9, 6},
                       {2, 4} };

            int[,] C = new int[row1, col2];

            int[,] expected = { { 61, 62 },
                              { 110, 76 } };

            Class1.multiplyMatrixRec(row1, col1, A, row2, col2, B, C);
            CollectionAssert.AreEqual(expected, C);
        }


        [TestMethod]
        public void MatrixMulRecTest2()
        {
            int row1 = 2, col1 = 2,
            row2 = 2, col2 = 2;
            int[,] A = {{9, 0},
                       {4, 8} };
            Class1.i = 0; Class1.j = 0; Class1.k = 0;

            int[,] B = {{5, 6},
                       {7, 1} };

            int[,] C = new int[row1, col2];

            int[,] expected = { { 45, 54 },
                              { 76, 32 } };

            Class1.multiplyMatrixRec(row1, col1, A, row2, col2, B, C);
            CollectionAssert.AreEqual(expected, C);
        }

        [TestMethod]
        public void MatrixMulRecTest3()
        {
            int row1 = 2, col1 = 2,
            row2 = 2, col2 = 2;
            int[,] A = {{11, 3},
                       {6, 1} };
            Class1.i = 0; Class1.j = 0; Class1.k = 0;

            int[,] B = {{5 ,5},
                        {8, 7} };

            int[,] C = new int[row1, col2];

            int[,] expected = { { 79, 76 },
                              { 38, 37 } };

            Class1.multiplyMatrixRec(row1, col1, A, row2, col2, B, C);
            CollectionAssert.AreEqual(expected, C);
        }

        //MatrixMulStrTest
        [TestMethod]
        public void MatrixMulStrTest1()
        {
            float[,] array = { { 16, 15 },
                           { 12, 21 } };
            float n = 2;

            float[,] array2 = { { 13, 23 },
                            { 41, 58 } };

            float[,] result = { { 823, 1238 },
                            { 1017, 1494 } };

            float[,] exp = Class1.strassen(array, array2, 2);
            CollectionAssert.AreEqual(exp, result);
        }

        [TestMethod]
        public void MatrixMulStrTest2()
        {
            float[,] array = { { 9, 1 },
                           { 8, 2 } };
            float n = 2;

            float[,] array2 = { { 7, 3 },
                            { 6, 4 } };

            float[,] result = { { 69, 31 },
                            { 68, 32 } };

            float[,] exp = Class1.strassen(array, array2, 2);
            CollectionAssert.AreEqual(exp, result);
        }

        [TestMethod]
        public void MatrixMulStrTest3()
        {
            float[,] array = { { 18, 33 },
                           { 3, 16 } };
            float n = 2;

            float[,] array2 = { { 1, 1 },
                            { 1, 1 } };

            float[,] result = { { 51, 51 },
                            { 19, 19 } };

            float[,] exp = Class1.strassen(array, array2, 2);
            CollectionAssert.AreEqual(exp, result);
        }

        //MatrixMulItrTest
        [TestMethod]
        public void MatrixMulItrTest1()
        {
            int[,] array = { { 1, 4, 6, 1 },
                           { 1, 9, 6, 7 },
                           { 3, 4, 8, 6 },
                           { 7, 6, 4, 9 } };

            int[,] array2 = { { 1, 4, 5, 3 },
                            { 1, 8, 5, 2 },
                            { 6, 4, 8, 2 },
                            { 6, 7, 1, 3 } };

            int[,] result =  { { 47, 67, 74, 26 },
                             { 88, 149, 105, 54 },
                             { 91, 118, 105, 51 },
                             { 91, 155, 106,68 } };

            int[,] exp = Class1.multiply(array, array2, result);
            CollectionAssert.AreEqual(exp, result);
        }

        [TestMethod]
        public void MatrixMulItrTest2()
        {
            int[,] array = { { 9, 8, 7, 2 },
                           { 1, 9, 7, 4},
                           { 2, 0, 0, 2 },
                           { 9, 9, 9, 9 } };

            int[,] array2 = { { 1, 1, 1, 1 },
                            { 8, 6, 9, 4 },
                            { 3, 4, 7, 7  },
                            { 6, 1, 1, 6 } };

            int[,] result = { { 106, 87, 132, 102 },
                            { 118, 87, 135, 110 },
                            { 14, 4, 4, 14 },
                            { 162, 108, 162, 162 } };

            int[,] exp = Class1.multiply(array, array2, result);
            CollectionAssert.AreEqual(exp, result);

        }

        [TestMethod]
        public void MatrixMulItrTest3()
        {
            int[,] array = { { 8, 1, 3, 5 },
                           { 9, 6, 5, 6 },
                           { 8, 1, 6, 7 },
                           { 6, 7, 2, 3 } };

            int[,] array2 = { { 4, 6, 2, 1 },
                            { 6, 8, 2, 9 },
                            { 3, 8, 1, 9 },
                            { 4, 6, 7, 3 } };

            int[,] result = { { 678, 110, 56, 59 },
                            { 111, 178, 77, 126 },
                            { 84, 146, 73, 92 },
                            { 84, 126, 49, 96 } };
            int[,] exp = Class1.multiply(array, array2, result);
            CollectionAssert.AreEqual(exp, result);
        }

        //QuickSoLoTest
        [TestMethod]
        public void QuickSoLoTest1()
        {
            int[] array = { 8, 6, 9, 3, 1, 7, 4, 2 };
            int n = array.Length - 1;
            int[] expected = { 1, 2, 3, 4, 6, 7, 8, 9 };

            Class1.quickSort(array, 0, n);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void QuickSoLoTest2()
        {
            int[] array = { 21, 46, 68, 29, 38, 19, 73 };
            int n = array.Length - 1;
            int[] expected = { 19, 21, 29, 38, 46, 68, 73 };

            Class1.quickSort(array, 0, n);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void QuickSoLoTest3()
        {
            int[] array = { 813, 567, 327, 61, 55, 22, 67 };
            int n = array.Length - 1;
            int[] expected = { 22, 55, 61, 67, 327, 567, 813 };

            Class1.quickSort(array, 0, n);
            CollectionAssert.AreEqual(array, expected);
        }

        //QuickSoHoTest
        [TestMethod]
        public void QuickSoHoTest1()
        {
            int[] array = { 3, 7, 0, 5, 9, 2, 8 };
            int n = array.Length - 1;
            int[] expected = { 0, 2, 3, 5, 7, 8, 9};

            Class1.quickSortHo(array, 0, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void QuickSoHoTest2()
        {
            int[] array = { 81, 62, 93, 65, 36, 74, 53 };
            int n = array.Length - 1;
            int[] expected = { 36, 53, 62, 65, 74, 81, 93 };

            Class1.quickSortHo(array, 0, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void QuickSoHoTest3()
        {
            int[] array = { 67, 110, 56, 59, 84, 126, 96};
            int n = array.Length - 1;
            int[] expected = { 56, 59, 67, 84, 96, 110, 126 };

            Class1.quickSortHo(array, 0, n);
            CollectionAssert.AreEqual(expected, array);
        }

        //RandomizedQuickSoLoTest
        [TestMethod]
        public void RandomizedQuickSoLoTest1()
        {
            int[] array = { 9, 8, 0, 6, 5, 2, 3 };
            int n = array.Length - 1;
            int[] expected = { 0, 2, 3, 5, 6, 8, 9 };

            Class1.QuickSoLo(array, 0, n);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void RandomizedQuickSoLoTest2()
        {
            int[] array = { 46, 68, 22, 19, 63, 88, 21 };
            int n = array.Length - 1;
            int[] expected = { 19, 21, 22, 46, 63, 68, 88 };

            Class1.QuickSoLo(array, 0, n);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void RandomizedQuickSoLoTest3()
        {
            int[] array = { 898, 161, 356, 567, 172, 867, 981 };
            int n = array.Length - 1;
            int[] expected = { 161, 172, 356, 567, 867, 898, 981 };

            Class1.QuickSoLo(array, 0, n);
            CollectionAssert.AreEqual(array, expected);
        }

        //RandomizedQuickSoHoTest
        [TestMethod]
        public void RandomizedQuickSoHoTest1()
        {
            int[] array = { 18, 13, 21, 54, 8, 32, 17 };
            int n = array.Length;
            int[] expected = { 8, 13, 17, 18, 21, 32, 54 };

            Class1.randomQuicksortHoare(array, 0, n - 1);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void RandomizedQuickSoHoTest2()
        {
            int[] array = { 54, 23, 86, 14, 16, 89, 77 };
            int n = array.Length;
            int[] expected = { 14, 16, 23, 54, 77, 86, 89, };

            Class1.randomQuicksortHoare(array, 0, n - 1);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void RandomizedQuickSoHoTest3()
        {
            int[] array = { 789, 456, 123, 369, 258, 147, 357};
            int n = array.Length;
            int[] expected = { 123, 147, 258, 357, 369, 456, 789  };

            Class1.randomQuicksortHoare(array, 0, n - 1);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void SelectionProblemTest1()
        {
            int[] arr = { 4, 6, 12, 5, 9, 29, 56 };
            int n = arr.Length, k = 3;
            int result = Class1.SelectionProblem(arr, 0, n - 1, k);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void SelectionProblemTest2()
        {
            int[] arr = { 4, 1, 6, 3, 12, 18, 76 };
            int n = arr.Length, k = 3;
            int result = Class1.SelectionProblem(arr, 0, n - 1, k);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void SelectionProblemTest3()
        {
            int[] arr = { 5, 2, 0, 9, 8, 44, 61 };
            int n = arr.Length, k = 3;
            int result = Class1.SelectionProblem(arr, 0, n - 1, k);
            Assert.AreEqual(5, result);
        }

        //HeapSoTest
        [TestMethod]
        public void HeapSoTest1()
        {
            int[] array = new int[] { 3, 8, 9, 6, 2 };
            int n = array.Length;
            int[] expected = new int[] { 2, 3, 6, 8, 9 };

            Class1.heapSort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void HeapSoTest2()
        {
            int[] array = new int[] {65, 987, 321, 32, 98, };
            int n = array.Length;
            int[] expected = new int[] { 32, 65, 98, 321, 987 };

            Class1.heapSort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void HeapSoTest3()
        {
            int[] array = new int[] { 963, 147, 852, 369, 654, 159 };
            int n = array.Length;
            int[] expected = new int[] { 147, 159, 369, 654, 852, 963 };

            Class1.heapSort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }

        //PriotyQueueWithHeapTest
        [TestMethod]
        public void PriotyQueueWithHeapTest1()
        {
            int[] arr = new int[] { 3, 6, 1, 9, 2, };
            Class1.insert(9);
            Class1.insert(6);
            Class1.insert(3);
            Class1.insert(2);
            Class1.insert(1);
            int expected = Class1.extractMax();
            Assert.AreEqual(9, expected);
        }

        [TestMethod]
        public void PriotyQueueWithHeapTest2()
        {
            int[] arr = new int[] { 92, 37, 83, 65, 12 };
            Class1.insert(92);
            Class1.insert(83);
            Class1.insert(65);
            Class1.insert(37);
            Class1.insert(12);
            int expected = Class1.extractMax();
            Assert.AreEqual(92, expected);
        }

        [TestMethod]
        public void PriotyQueueWithHeapTest3()
        {
            int[] arr = new int[] { 467, 918, 723, 167, 816};
            Class1.insert(918);
            Class1.insert(816);
            Class1.insert(723);
            Class1.insert(467);
            Class1.insert(167);
            int expected = Class1.extractMax();
            Assert.AreEqual(918, expected);
        }


        //CountingSoTest
        [TestMethod]
        public void CountingSoTest1()
        {
            int[] array = new int[] { 16, 18, 12, 19, 13, 26 };
            int n = array.Length;
            int[] expected = new int[] { 12, 13, 16, 18, 19, 26 };

            Class1.CountingSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CountingSoTest2()
        {
            int[] array = { 68, 26, 37, 98, 64, 61 };
            int n = array.Length;
            int[] expected = new int[] { 26, 37, 61, 64, 68, 98 };

            Class1.CountingSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CountingSoTest3()
        {
            int[] array = { 8, 3, 2, 7, 9, 6, 4 };
            int n = array.Length;
            int[] expected = { 2, 3, 4, 6, 7, 8, 9 };

            Class1.CountingSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        //RadixSoTest
        [TestMethod]
        public void RadixSoTest1()
        {
            int[] array = { 6, 8, 7, 1, 9, 4, 2 };
            int n = array.Length;
            int[] expected = { 1, 2, 4, 6, 7, 8, 9 };

            Class1.radixsort(array, n);
            CollectionAssert.AreEqual(expected, array);

        }

        [TestMethod]
        public void RadixSoTest2()
        {
            int[] array = { 25, 36, 14, 74, 85, 96 };
            int n = array.Length;
            int[] expected = { 14, 25, 36, 74, 85, 96 };

            Class1.radixsort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void RadixSoTest3()
        {
            int[] array = { 399, 177, 864, 267, 135 };
            int n = array.Length;
            int[] expected = { 135, 177, 267, 399, 864 };

            Class1.radixsort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }


    }
}