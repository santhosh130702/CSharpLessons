using System.Text;

public class TestoneAnswer
{
    public static void QuestionOne()
    {
        byte byteOne = 1;
        sbyte sbyteOne = 1;
        short shortOne = 1;
        int intOne = 1;
        long longOne = 1;
        float floatOne = 1.543f;
        double doubleOne = 2345.76534d;
        decimal decimalOne = 627637263.36263726372M;
        char charOne = 'A';
        bool boolOne = true;
        Console.WriteLine(byte.MaxValue);
        Console.WriteLine(sbyte.MaxValue);
        Console.WriteLine(short.MaxValue);
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(long.MaxValue);
        Console.WriteLine(float.MaxValue);
        Console.WriteLine(double.MaxValue);
        Console.WriteLine(decimal.MaxValue);


    }
    static int x = 100;
    public static void QuestionTwo()
    {
        int y = 10;
        Console.WriteLine(y);
        Console.WriteLine(x);
    }
    public static void QuestionThreeA()
    {
        String strFriends = "Tom and Jerry are good friends"; string[] words = strFriends.Split(" ");
        int wordCount = words.Length;
        Console.WriteLine($"Word Count {wordCount}");
    }
    //  Write a function that can reverse the string
    public static void QuestionThreeB()
    {
        String strFriends = "Tom and Jerry are good friends";
        Console.WriteLine(strFriends);
        // first Method
        char[] charData = strFriends.ToCharArray();
        int len = charData.Length;
        StringBuilder sb = new StringBuilder(len + 10);
        for (int i = len - 1; i >= 0; i--)
        {
            sb.Append(charData[i]);
        }
        Console.WriteLine(sb.ToString());
        // Second Method
        var strReverse = strFriends.Reverse();
        foreach (var item in strReverse)
        {
            Console.Write(item);
        }
    }
    public static void QuestionThreeC()
    {
        String strFriends = "Tom and Jerry are good friends";
        Console.WriteLine($"Char Count: {strFriends.Length} ");
    }
    // Change the string to Uppercase and print
    public static void QuestionThreeD()
    {
        String strFriends = "Tom and Jerry are good friends";
        string strInUpper = strFriends.ToUpper();
        Console.WriteLine(strFriends);
        Console.WriteLine(strInUpper);
    }
    // Change the string to Uppercase and print
    //Print from 10th char to the 15th char
    public static void QuestionThreeE()
    {
        String strFriends = "Tom and Jerry are good friends";
        String strPart = strFriends.Substring(10, 5);
        Console.WriteLine(strFriends);
        Console.WriteLine(strPart);
    }

    

//What are the essential differences between C# consts, Static, and readonly fields? 

    /**

    * For Constant Fields a Value must be assigned on declaration

    * Constant value can not be changed

    * Static Value need not be assigned on declaration

    * Static Value can be changed

    * An Object for the class need not be created for Static, and Constants

    * Static, and Constants can be accessed using [ClassName.FieldName]

    * Constants, and Static Fields are loaded in the stack, and shared 

    * 

    * For readonly fields value can be assigned only through the constructor

    * Readonly Field can be accessed only through a reference

    * ReadOnly Fields can not be modified after a value is assigned

    * Different instances of the class can have different value for Readonly field

    * Readonly fields are not shared

*/

  

public const float Pi = 3.14f; // Const Value must be assigned on declaration

    public static int Price; // Static Value need not be assigned on declaration

    public readonly int Id;

    public TestoneAnswer(int id)

    {

        this.Id = id;// For readonly fields value can be assigned only through the constructor

    }

    public static void TestStaticConstantReadOnly()

    {

        Console.WriteLine($"Constant Value: {TestoneAnswer.Pi}");

        // TestOneAnswers.pi = 5454f; Constant value can not be changed

        Console.WriteLine($"Static Value: {TestoneAnswer.Price}");

        TestoneAnswer.Price = 3000; // Static Value can be changed

        Console.WriteLine($"Static Value: {TestoneAnswer.Price}");

        // Readonly Field can be accessed only through a reference

        //  Console.WriteLine($"ReadOnly Value: {TestOneAnswers.Id}");

        TestoneAnswer testOneAnswers = new TestoneAnswer(10001);

        Console.WriteLine($"ReadOnly Value: {testOneAnswers.Id}");

        // testOneAnswers.Id = 200001; ReadOnly Fields can not be modified after assigning Value

        TestoneAnswer testtwoAnswers = new TestoneAnswer(10002);

        Console.WriteLine($"ReadOnly Value: {testtwoAnswers.Id}");

        // Different instances of the class can have different value for Readonly field

        // Readonly fields are not shared



    }

  /***

   * Write a C# method called Swap that takes two int numbers as parameters (x and y) and 

   * swaps their values.Then, write some code that declares v1 and v2 as int, initializes their

   * values, and then calls Swap, passing in v1 and v2 as arguments.

   * After calling Swap, v1 should have v2’s original value, and 

   * v2 should have v1’s original value.

   * 

   */

  public static void QuestionSeven()

    {

        int v1 = 35;

        int v2 = 55;

        Console.WriteLine($"v1={v1}, v2={v2}");

        Swap(ref v1, ref v2);

        Console.WriteLine("After Swap");

        Console.WriteLine($"v1={v1}, v2={v2}");

    }

    public static void Swap(ref int x, ref int y)

    {

        x = x + y;// 90

        y = x - y; // 90-55=35

        x = x - y; //90-35=55

    }

  /**

   * Create two interfaces ServiceA, ServiceB. 

   * The interface ServiceA has the following methods: void fly()

   * The interface ServiceB has the following methods: void run (), void swim() .

   * Implement both the interfaces in a single class. 

   * Test the implementation by writing a Test Class.

   */

public interface IServiceA

    {

        void Fly();

    }

    public interface IServiceB

    {

        void Run();

        void Swim();

    }

    public class ABServices : IServiceA, IServiceB

    {

        public void Fly()

        {

            Console.WriteLine("Fly");

        }



        public void Run()

        {

            Console.WriteLine("Run");

        }



        public void Swim()

        {

            Console.WriteLine("Swim");

        }

    }

    public static void QuestionEight()

    {

        ABServices serviceA = new ABServices();

        serviceA.Fly();

        serviceA.Swim();

        serviceA.Run();

    }


/***

  * Find the error in the following code. 

  * Fix the error and write a child class for the Box class

  * public class Box{ public abstract void show();}

  * Answer:

  *       A class with abstract method must be declared as abstract

  */

public abstract class Box

    {

        public Box()

        {

            Console.WriteLine("Box Constructor");

        }

        public abstract void Show();

    }

    public class WoodenBox : Box

    {

        public WoodenBox()

        {

            Console.WriteLine("WoodenBox constructor");

        }

        public override void Show()

        {

            Console.WriteLine("WoodenBox.Show");

        }

    }

    public static void QuestionNine()

    {

        Box box = new WoodenBox();

        box.Show();

    }

  

// Study the below code, and give the Exception path:

    // ex8=>ex4=>ex1=>ex0=>bla bla
}
public class Four
{

    public static void DoLogin()
    {
        Console.WriteLine("Enter Your Name");
        String name = Console.ReadLine();
        bool flag = QuestionFour(name);
        if (!flag)
        {
            return;
        }
        Console.WriteLine($"Welcome {name} ");
    }

    public static bool QuestionFour(String name)
    {

      
        bool result = false;
        if (string.IsNullOrEmpty(name))
        {
            result = false;
            Console.WriteLine("Name is NULL or EMPTY");
        }
        name = name.Trim().ToLower();
        char[] chars = name.ToCharArray();
        int length = chars.Length;
        if (length < 8)
        {
            Console.WriteLine("Name Length Must be 8!!!");
            result = false;
            return result;
        }
        for (int i = 0; i < length; i++)
        {
            int ascii = chars[i];
            if (ascii < 97 || ascii > 122)
            {
                Console.WriteLine($"Invalid char in NAME {chars[i]}");
                result = false;
                return result;
            }
        }
        result = true;
        return result;
    }
}

