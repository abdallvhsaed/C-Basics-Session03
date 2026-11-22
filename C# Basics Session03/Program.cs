using System.Security.Cryptography;
using System.Threading.Channels;

namespace C__Basics_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
            //both title and upperTitle to show that title did not change.
            string title = "clean code";
            String upperTitle = title.ToUpper();
            Console.WriteLine($"title = {title}  ,  upperTitle = {upperTitle}");


            #endregion
        }
    }
}
