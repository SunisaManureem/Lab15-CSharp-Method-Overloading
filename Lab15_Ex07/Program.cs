class Program
{
    static void Main()
    {
        Derived_2 d2 = new Derived_2();
        Base b = (Base) d2;
        Derived_1 d1 = (Derived_1) d2;

        b.A();  // เรียกใช้เมธอดจาก Base
        d1.A(); // เรียกใช้เมธอดจาก Derived_1
        d2.A(); // เรียกใช้เมธอดจาก Derived_2
    }
}

class Base
{
    public virtual void A()
    {
        System.Console.WriteLine("Base.A()");
    }
}

class Derived_1 : Base
{
    public override void A()
    {
        System.Console.WriteLine("Derived_1.A()");
    }
}

class Derived_2 : Derived_1
{
    public override void A()
    {
        System.Console.WriteLine("Derived_2.A()");
    }
}