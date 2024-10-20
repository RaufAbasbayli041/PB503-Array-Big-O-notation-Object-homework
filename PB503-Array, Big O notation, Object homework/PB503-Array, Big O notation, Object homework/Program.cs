namespace PB503_Array__Big_O_notation__Object_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Taks 1

            //// Verilmiş ededler siyahisindaki(int[]) en böyük ededi tapan alqoritm

            int[] array = { 1, 2, 55, 4, -9 };
            int maxValue = array[0];
           

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
                
            }

            Console.WriteLine(maxValue);
           

            #endregion


            #region Task 2

            ///* Verilmiş Products arrayindəki Product objectlərinin Id'ləri tək olanlarının Price'larının ədədi ortasını tapan
            //algorithm yazın.(Product objectinin propertyləri: Id(yeni reqem ve ya eded), Name, Price, StockCount)  */

            //var product1 = new { ID = 5, Name = "Defter", Price = 4, StockCount = 2 };
            //var product2 = new { ID = 3, Name = "Kitab", Price = 9, StockCount = 1 };
            //var product3 = new { ID = 10, Name = "Qelem", Price = 8, StockCount = 11 };
            //var product4 = new { ID = 12, Name = "Pozan", Price = 6, StockCount = 7 };

            //var products = new[] { product1, product2, product3, product4 };

            //decimal count = 0;
            //decimal sum = 0;

            //for (int i = 0; i < products.Length; i++)
            //{
            //    if (products[i].ID % 2 != 0)
            //    {
            //        count++;
            //        sum += products[i].Price;
            //        Console.WriteLine(products[i]);
            //    }
            //}

            ////foreach (var product in products)
            ////{
            ////    if (product.ID % 2 != 0)
            ////    {
            ////        count++;
            ////        sum += product.Price;
            ////        Console.WriteLine(product);
            ////    }
            ////}

            //Console.WriteLine(sum);
            //decimal avg = sum / count;
            //Console.WriteLine(avg);

            #endregion

        }
    }
}

