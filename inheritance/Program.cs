using System;
public class A
{
    public void talk()
    {
        Console.WriteLine("Hello World");
    }
}
public class B : A
{
    public void say()
    {
        Console.WriteLine("My name is Aanchal");
    }
}
public class c : A
{
    public void speak()
    {
        Console.WriteLine("My name is Reshma");
    }
}
class Myclass
{
    static void Main()
    {
        B myB = new B();
        myB.talk();
        myB.say();

        c myc = new c();
        myc.talk();
        myc.speak();
    }
}