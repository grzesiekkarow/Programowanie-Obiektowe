using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            #region trycatch
            /*int liczba1, liczba2, liczba3;
            liczba2 = 30;
            liczba3 = 0;
            int[] table = new int[2];
            */
            /*try
            {
                liczba1 = liczba2 / liczba3;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("FINALLY");
            }*/
            /*try
            {
                table[25] = 2;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            catch (Exception)
            {
                Console.WriteLine("Blablabla");
                throw;
            }*/
            /*try
            {
                throw new IndexOutOfRangeException();
            }
            catch (Exception)
            {
                Console.WriteLine("przechwycony");
                throw;
            }*/
            #endregion

            Console.ReadKey();
            
        }
    }
}
