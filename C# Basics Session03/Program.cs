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
            //StringBuilder sp = new StringBuilder("");
            //sp.Append("Book List");
            //sp.Append("- Updated");
            //String result = sp.ToString();
            //Console.WriteLine("result : " + result);


            #endregion
            #region question 4 
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //Print the result.
            //sp.Replace("Book List", "Library");
            //String Result = sp.ToString();
            //Console.WriteLine("Result : " + Result);
            #endregion
            #region question 5
            //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            //Pages: 464" using the + operator.
            //String title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine("Book : " + title + " , pages : " + pages);
            #endregion
            #region question 6
            //Build the same sentence as above, but using string interpolation ($"...").
            //Console.WriteLine($"book : {title} , pages : {pages}");
            #endregion
            #region question 7
            //Build the same sentence as above, but using string interpolation ($"...").
            //Console.WriteLine("book : {0} , pages : {1}", title, pages);
            #endregion
            #region question 8
            //Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
            //300, otherwise prints "Short Book".
            int pages = 464; 
            if(pages > 300)
            {
                Console.WriteLine("long book");
            }
            else
            {
                Console.WriteLine("short book");
            }
            #endregion
            #region question 9
            //Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
            //greater than 300 and isAvailable is true.Use the && operator.
            bool isAvailable = true;
            if(pages > 300 && isAvailable == true)
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion
            #region question 10
            //Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
            //"Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
            String title = "Refactoring";
            switch(title)
            {
                case "Clean Code":
                case "Nice pick":
                    Console.WriteLine("Great Choice!");
                    break;
                case "Refactoring":
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion
            #region question 11 
            //Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
            //variable sizeLabel(same rule as question 8: long if pages > 300).

            String sizelable = (pages > 300) ? "long book" : "short book";
            Console.WriteLine(sizelable);
            #endregion


        }
    }
}