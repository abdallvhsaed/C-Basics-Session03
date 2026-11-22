using System.Drawing;
using System.Security.Cryptography;
using System.Text;
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
            //string title = "clean code";
            //String upperTitle = title.ToUpper();
            //Console.WriteLine($"title = {title}  ,  upperTitle = {upperTitle}");


            #endregion
            #region question 2
            //Declare two separate string variables, both set to the literal "Clean Code".Use ReferenceEquals()
            //to check if they point to the same object in memory.
            //String s1 = "Clean Code";
            //String s2 = "Clean Code";
            //Console.WriteLine(object.ReferenceEquals(s1, s2)); //true

            #endregion
            #region question 3
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            //object.Print the final result.
            StringBuilder sp = new StringBuilder("");
            sp.Append("Book List");
            sp.Append("- Updated");
            String result = sp.ToString();
            Console.WriteLine("result : " + result);


            #endregion
            #region question 4 
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //Print the result.
            sp.Replace("Book List", "Library");
            String Result = sp.ToString();
            Console.WriteLine("Result : " + Result);
            #endregion

        }
    }
}