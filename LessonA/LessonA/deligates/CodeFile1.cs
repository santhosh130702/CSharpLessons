public delegate void MethodHandlerA();
public delegate int MethodHandlerB(int x,int y);

public class MathCalculator
{
    public void DoTask()
    {
        Console.WriteLine("calculator DoTask");
    }
    public int Add(int x,int y)
    {
        Console.WriteLine(x + ", " + y);
        return x + y;
    }
    public int Multiply(int x, int y)
    {
        Console.WriteLine(x + ", " + y);
        return x*y;
    }
    public double Divide(double x, double y)
    {
        Console.WriteLine(x + ", " + y);
        return x/y;
    }
    public String GetModel()
    {
        return "x500";

    }
}
public class DelegateDemo
{
    public static void TestOne()
    {
        MathCalculator mc = new MathCalculator();
        MethodHandlerA methodHandlerA = mc.DoTask;// new MethodHandlerA(mc.DoTask);
        MethodHandlerB methodHandlerB = mc.Add;
        MethodHandlerB methodHandlerTwo = mc.Multiply;
        methodHandlerA();
        int addresult = methodHandlerB(100, 50);
        Console.WriteLine(addresult);
        int multiplyresult = methodHandlerTwo(20, 5);
        Console.WriteLine(multiplyresult);



    }
    public static void TestTWO()
    {
        MathCalculator mc= new MathCalculator();
        MethodHandlerB methodHandlerB = mc.Add;
        methodHandlerB += mc.Multiply;
        int x= methodHandlerB(100, 50);
        Console.WriteLine(x);


    }
}