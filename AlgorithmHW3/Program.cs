using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmHW3
{
    class Program
    {
        private static int count;

        /// <summary>
        /// Обычный свап
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Сортировка пузырьком
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] BubbleSort( ref int[] arr )
        {
            count = 0;
            for( int i = 0; i < arr.Length; i++ )
            {
                for( int j = 0; j < arr.Length - 1; j++ )
                {
                    if( arr[ j ] > arr[ j + 1 ] )
                    {
                        Swap( ref arr[ j ], ref arr[ j + 1 ] );
                        count++;
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// Шейкерная сортировка
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] ShakerSort( ref int[] arr )
        {
            count = 0;
            for( int i = 0; i < arr.Length; i++ )
            {
                for( int j = 0; j < arr.Length - 1; j++ )
                {
                    if( arr[ j ] > arr[ j + 1 ] )
                    {
                        Swap( ref arr[ j ], ref arr[ j + 1 ] );
                        count++;
                    }
                }
                for( int j = arr.Length - 2; j > 0; j-- )
                {
                    if( arr[ j ] < arr[ j - 1 ] )
                    {
                        Swap( ref arr[ j ], ref arr[ j - 1 ] );
                        count++;
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// Сортировка вставками
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] InserstionSort( ref int[] arr )
        {
            count = 0;
            for( int i = 1; i < arr.Length; i++ )
            {
                for( int j = i; j > 0 && arr[ j - 1 ] > arr[ j ]; j-- )
                {
                    Swap( ref arr[ j - 1 ], ref arr[ j ] );
                    count++;
                }
            }
            return arr;
        }

        /// <summary>
        /// Сортировка методом выбора
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] SelectionSort(ref int[] arr )
        {
            count = 0;
            int jmin = 0;
            for( int i = 0; i < arr.Length; i++ )
            {
                jmin = i;
                for(int j = i + 1; j < arr.Length; j++ )
                    if( arr[ j ] < arr[ jmin ] )
                    {
                        jmin = j;
                        count++;
                    }
                Swap( ref arr[ i ], ref arr[ jmin ] );
            }
            return arr;
        }

        /// <summary>
        /// Бинарный поиск
        /// </summary>
        /// <param name="value"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int BinarySearch( int value, int[] arr )
        {
            int left = 0;
            int right = arr.Length;
            int mid = 0;
            while( !( left >= right ) )
            {
                mid = left + ( right - left ) / 2;

                if( arr[ mid ] == value )
                    return mid;

                if( arr[ mid ] > value )
                    right = mid;
                else
                    left = mid + 1;
            }
            return -1;
        }

        /// <summary>
        /// Вывод массива
        /// </summary>
        /// <param name="arr"></param>
        public static void ShowArr( int[] arr )
        {
            foreach( int i in arr )
            {
                Console.Write( $"{i, 3} " );
            }
            Console.WriteLine();
        }

        static void Main( string[] args )
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }; //<- массив для проверки бинарного поиска
            int[] unsortedArr = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }; //<- массив для проверки сортировки
            //ShowArr( BubbleSort( ref unsortedArr ) ); //<- Вывод массива после пузырьковой сортировки
            //ShowArr( ShakerSort( ref unsortedArr ) ); //<- Вывод массива после шейкерной сортировки
            //ShowArr( InserstionSort( ref unsortedArr ) ); //<- Вывод массива после сортировки вставками
            //ShowArr( SelectionSort( ref unsortedArr ) ); //<- Вывод массива после сортировки методом выбора
            //Console.WriteLine( count ); //<- Вывод количества выполненных операций в сортировках

            //Console.WriteLine( BinarySearch( 30, arr ) ); //<- Проверка бинарного поиска
        }
    }
}
