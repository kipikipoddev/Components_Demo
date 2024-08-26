namespace Step_1_Copy_Paste_Approach;


public class Program
{
    private static void Main(string[] args)
    {
        var cat = new Cat();
        cat.Walk();
        cat.Meow();

        var dog = new Dog();
        dog.Walk();
        dog.Bark();

        var robot = new Robot();
        robot.Walk();
        robot.Beep();

        var robot_dog = new Robot_Dog();
        robot_dog.Walk();
        robot_dog.Bark();
    }
}