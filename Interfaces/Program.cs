namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
           class1 o = new class1();
            // method 1
            o.Insert();
          //  o.
            //method 2

            IDFunction oIDf;
            oIDf = o;
            oIDf.Delete();


            //method 3

            ((IDFunction)oIDf).Delete();

            //method 4

            (o as IDFunction).Update();
        }
    }

    public interface IDFunction {
        void Insert();
        void Update();
        void Delete();



    }

    public class class1 : IDFunction
    {

        public void Display() {
            Console.WriteLine("display");
        }
        public void Delete()
        {
            Console.WriteLine("delete");
            throw new NotImplementedException();
        }

        public void Insert()
        {
            Console.WriteLine("insert");
            throw new NotImplementedException();
        }

        public void Update()
        {
            Console.WriteLine("update");
            throw new NotImplementedException();
        }
    }

}