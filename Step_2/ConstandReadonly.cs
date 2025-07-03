using System;
class MathValues
{

    const int i = 10;
    const string name = "Usha";
    //const int j;//a const field requires a value to be provided other wise it will thorugh compiler error

    readonly int a = 20;
    readonly string student = "Vinitha";
    readonly string employee;//this member is created but unused anywhere,we can just simply create without using in readonly

    public MathValues()
    {

        //this.i = 30;//cannot be accessed with an instance reference
        int i = 20;//qualify it with a type name instead of using this keyword
        this.a = 40;//while using readonly we can use instance reference
        this.student = "Vinitha";
        this.employee = "You";

        Console.WriteLine($"a is {a},student is {student},employee is {employee} ");
    }
    static void Main()
    {
        MathValues mathValues = new MathValues();

    }
}