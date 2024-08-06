namespace DrawShapes;

class Program
{
    static void Main(string[] args)
    {
       while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle (bottom-left)");
            Console.WriteLine("3. Print the square triangle (top-left)");
            Console.WriteLine("4. Print isosceles triangle");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        PrintRectangle();
                        break;
                    case 2:
                        PrintSquareTriangleBottomLeft();
                        break;
                    case 3:
                        PrintSquareTriangleTopLeft();
                        break;
                    case 4:
                        PrintIsoscelesTriangle();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }
        }
    }
    static void PrintRectangle()
    {
        Console.Write("Enter the width: ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("Enter the height: ");
        int height = int.Parse(Console.ReadLine());

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void PrintSquareTriangleBottomLeft()
    {
        Console.Write("Enter the height: ");
        int height = int.Parse(Console.ReadLine());

        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void PrintSquareTriangleTopLeft()
    {
        Console.Write("Enter the height: ");
        int height = int.Parse(Console.ReadLine());

        for (int i = height; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void PrintIsoscelesTriangle()
    {
        Console.Write("Enter the height: ");
        int height = int.Parse(Console.ReadLine());

        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= height - i; j++)
            {
                Console.Write("  "); // In khoảng trắng
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
