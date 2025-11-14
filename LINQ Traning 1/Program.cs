using DemoG01.Data;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static DemoG01.Data.ListGenerator;


namespace LINQ_Traning_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators


            #region Q1
            /*. Find all products that are out of stock*/

            //var result =ProductList?.Where(p => p.UnitsInStock == 0);
            //foreach (var items in result??Enumerable.Empty<Object>()) {
            //    Console.WriteLine(items);
            //}

            #endregion
            #region Q2
            /*Find all products that are in stock and cost more than 3.00 per unit.*/

            //var result2 = ProductList?.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
            //foreach (var items in result2 ?? Enumerable.Empty<Object>())
            //{
            //    Console.WriteLine(items);
            //}
            #endregion

            #region Q3
            /*Returns digits whose name is shorter than their value.
            String [] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            */

            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where((digits, Index) => digits.Length < Index);
            //foreach (var items in result)
            //{
            //    Console.WriteLine(items);
            //}


            #endregion


            #endregion

            #region Ordering Operators
            #region Q1
            /*Sort a list of products by name*/


            // var result = ProductList?.OrderBy(p => p.ProductName);
            //foreach (var items in result ?? Enumerable.Empty<Object>())
            // {
            //     Console.WriteLine(items);
            // }

            #endregion

            #region Q2

            /*Uses a custom comparer to do a case-insensitive sort of the words in an array.
            String [] Arr = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};
            */


            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);
            //foreach (var items in result)
            //{
            //    Console.WriteLine(items);
            //}

            #endregion

            #region Q3
            /*3. Sort a list of products by units in stock from highest to lowest.*/

            //var result = ProductList?.OrderByDescending(p => p.UnitsInStock);
            //foreach (var items in result ?? Enumerable.Empty<Object>()) 
            //{
            //    Console.WriteLine(items);

            //}

            #endregion

            #region Q4
            /*Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            string [] Arr = {“zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine”};
            */

            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.OrderBy(p=>p.Length).ThenBy(p=>p);
            //foreach (var items in result)
            //{
            //    Console.WriteLine(items);
            //}


            #endregion

            #region Q5
            /*Sort first by-word length and then by a case-insensitive sort of the words in an array.
            String [] Arr = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};
            */
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result =Arr.OrderBy(p => p.Length).ThenBy(p => p, StringComparer.OrdinalIgnoreCase);
            //foreach (var items in result)
            //{
            //    Console.WriteLine(items);
            //}

            #endregion
            #region Q6
            /*Sort a list of products, first by category, and then by unit price, from highest to lowest.*/
            //var result = ProductList?.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var items in result ?? Enumerable.Empty<Object>())
            //{
            //    Console.WriteLine(items);
            //}


            #endregion

            #region Q7
            /*Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            String [] Arr = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};
            */
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(p=>p.Length).ThenBy(p => p, StringComparer.OrdinalIgnoreCase);
            //foreach (var items in result)
            //{
            //    Console.WriteLine(items);
            //}

            #endregion

            #region Q8
            /*Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            string [] Arr = {“zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine”};
            */
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //List<String> Ls = Arr.Where(p => p[1]=='i').Reverse().ToList();
            //foreach (var items in Ls)
            //{
            //    Console.WriteLine(items);
            //}


            #endregion


            #endregion

            #region Transformation Operators
            #region Q1
            /*Return a sequence of just the names of a list of products.*/


            //var result = ProductList?.Select(p => p.ProductName);
            //foreach (var items in result ?? Enumerable.Empty<String>())
            //{
            //    Console.WriteLine(items);
            //}

            #endregion
            #region Q2

            /*Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            String [] words = {"aPPLE", "BlUeBeRrY", "cHeRry"};
            */

            // String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            // var result =new  {
            //     Uppercase = words.Select(word => word.ToUpper()),
            //     Lowercase = words.Select(word => word.ToLower())
            // };
            // Console.WriteLine("Uppercase:");
            // foreach (var item in result.Uppercase)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("Lowercase:");
            //foreach(var item in result.Lowercase)
            // {
            //     Console.WriteLine(item );
            // }

            #endregion

            #region Q3
            /*. Produce a sequence containing some properties of Products, including 
             * UnitPrice which is renamed to Price in the resulting type.*/

            //var result = ProductList?.Select(p => new { Price = p.UnitPrice });
            //foreach (var items in result ?? Enumerable.Empty<Object>())
            //{
            //    Console.WriteLine(items);
            //}
            #endregion

            #region Q4
            /*4. Determine if the value of int in an array matches their position in the array.
              Int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            */

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((number, index) => new { Number = number, IsMatch = number == index });
            //foreach (var items in result)
            //{
            //    Console.WriteLine($"Number: {items.Number}, IsMatch: {items.IsMatch}");
            //}



            #endregion

            #region Q5
            /*Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            */

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = from a in numbersA
            //             from b in numbersB
            //                where a < b
            //                select new { A = a, B = b };
            //foreach (var items in result)
            //{

            //    Console.WriteLine($" {items.A}, is less than  {items.B}");
            //}

            #endregion

            #region Q6
            /*Select all orders where the order total is less than 500.00.*/

            //var result = CustomerList?
            //    .SelectMany(c => c.Orders, (customer, order) => new { Customer = customer, Order = order })
            //    .Where(co => co.Order.Total < 500.00M)
            //    .Select(co => new { co.Customer.CustomerID, co.Order.OrderID, co.Order.Total });
            //foreach (var items in result ?? Enumerable.Empty<Object>())
            //{
            //    Console.WriteLine(items);
            //}
            #endregion

            #region Q7
            /*Select all orders where the order was made in 1998 or later.*/

            //var result  = CustomerList?
            //    .SelectMany(c => c.Orders, (customer, order) => new { Customer = customer, Order = order })
            //    .Where(co => co.Order.OrderDate.Year >= 1998)
            //    .Select(co => new { co.Customer.CustomerID, co.Order.OrderID, co.Order.OrderDate });

            //foreach (var items in result ?? Enumerable.Empty<Object>())
            //{
            //    Console.WriteLine(items);
            //}

            #endregion




                #endregion

        }
    }
}
