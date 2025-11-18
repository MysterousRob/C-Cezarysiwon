using Lab9.Models;
using Lab9.Shapes;



namespace Lab9;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("=========== Person / Student / Employee ===========");
        DemoPeople();

        System.Console.WriteLine("\n========== Shapes & Drawing ============");
        DemoShapes();
    }


    public static void DemoPeople()
    {
        Student s = new Student()
        {
            FirstName = "Karol",
            LastName = "Borusk",
            BirthDate = new DateTime(2001, 9, 14),
            Password = "1234",
            AlbumId = 189076,
            StudyField = "Informatyka Stosowa"
        };

        System.Console.WriteLine($"Student: {s.FirstName} {s.LastName}");
        System.Console.WriteLine($"Study Field: {s.StudyField}");
        System.Console.WriteLine($"Password Valid: {s.isPasswordValid("1234")}");


        Employee e = new Employee()
        {
            FirstName = "Anna",
            LastName = "Lewandowski",
            BirthDate = new DateTime(1990, 2, 20),
            Password = "qwerty",
            Salary = 5500m,
            Position = "Manager",
            Division = "IT"
        }; 
        System.Console.WriteLine($"Employee: {e.FirstName} {e.LastName}, Position: {e.Position}");
    }

    public static void DemoShapes()
    {
        IDrawable[] picture = new IDrawable[10];

        picture[0] = new Rectangle()
        {
            Color = 3,
            X = 1,
            Y = 1, 
            Width = 4,
            Height = 5
        };

        picture[1] = new Circle()
        {
            Color = 7,
            Radius = 3,
            CenterX = 5,
            CenterY = 5
        };

        picture[2] = new Point()
        {
            Color = 9,
            X = 10,
            Y = 15
        };
        
        DrawPicture(picture);

        System.Console.WriteLine($"Total area of shapes: {AreaSum(picture)}");
    }

    public static void DrawPicture(IDrawable[] picture)
    {
        foreach (var drawable in picture)
            if (drawable != null)
                drawable.Draw();
    }

    public static double AreaSum(IDrawable[] picture)
    {
        double sum = 0;

        foreach (var drawable in picture)
        {
            if (drawable is Shape shape)
            {
                sum += shape.Area();
            }
        }
        return sum;
    }
}