namespace Step_1_Copy_Paste_Approach;


public class Program
{
    private static void Main(string[] args)
    {
        var cat = new Cat();
        cat.Walk();
        cat.Make_Sound();

        var dog = new Dog();
        dog.Walk();
        dog.Make_Sound();

        var robot = new Robot();
        robot.Walk();
        robot.Make_Sound();

        var robot_dog = new Robot_Dog();
        robot_dog.Walk();
        robot_dog.Make_Sound();

        var robot_cat_dog = new Robot_Cat_Dog();
        robot_cat_dog.Walk();
        robot_cat_dog.Make_Sound();
    }
}