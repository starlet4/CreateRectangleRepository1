using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;


namespace CreateRectanglesWithClonedProject
	{
	class Program
		{
		static void Main(string[] args)
			{


			string inputString;
			int length;
			int width;
			string EnterColor;
			int length2;
			int width2;
				

			 //when you don't know what the user will type on use no parameters in the objects i created.
			   AddClassToCreateRectangle Rectangle1 = new AddClassToCreateRectangle();
			   AddClassToCreateRectangle Rectangle2 = new AddClassToCreateRectangle();	


			   Console.WriteLine("\t\t\tMy First Project with Claim Academy");
			   Console.WriteLine("");
			   Console.WriteLine("");

			   Console.Write(" Please enter a color: ");
			   EnterColor = Console.ReadLine();

			   Console.WriteLine("");

			   Console.Write(" Please enter a length ");
			   inputString = Console.ReadLine();
		       length = Convert.ToInt32(inputString);

			   Console.WriteLine("");


			  Console.Write(" Please enter a width ");
			  inputString = Console.ReadLine();
			  width = Convert.ToInt32(inputString);

			  Console.WriteLine("");

			  Console.Write(" Please enter a length ");
			  inputString = Console.ReadLine();
			  length2 = Convert.ToInt32(inputString);

			  Console.WriteLine("");


			  Console.Write(" Please enter a width ");
			  inputString = Console.ReadLine();
			  width2 = Convert.ToInt32(inputString);

			  Console.WriteLine("");


			  Rectangle1.length = 20;
			  Rectangle1.width = 30;

			  Rectangle2.length = 30;
			  Rectangle2.width =20;

			  AddClassToCreateRectangle.color = EnterColor; 

			 

			Console.Write(" Display the total area of Rectangle 1 \n", Rectangle1.FindArea());
			Console.Write(" Display the area of Rectangle 2 \n",Rectangle2.FindArea());
			Console.Write(" Display the total area of both Retangles.{0} \n", Rectangle1.FindArea() + Rectangle2.FindArea());
			Console.Write(" Display the colors of both Retangles {0} \n", AddClassToCreateRectangle.color);


			Console.Read();











			}
		}
	}

