namespace Step_1_Copy_Paste;


public class Program
{
    private static void Main(string[] args)
    {
        Cat();
        Dog();
        Fish();
        Robot();
        Fish_Robot();
        Robot_Dog();
    }

    private static void Cat()
    {
        Console.WriteLine(" -- Cat -- ");
        var cat = new Cat(Speed.Fast);

        var can = (cat.Can_Walk ? "Walk, " : string.Empty) +
                    (cat.Can_Make_Sound ? "Make_Sound, " : string.Empty) +
                    (cat.Can_Swim ? "Swim, " : string.Empty);
        Console.WriteLine("Cat can: " + can.Remove(can.Length - 2, 2));

        cat.Walk();
        cat.Make_Sound();
        cat.Swim();

        cat.Injure();

        can = (cat.Can_Walk ? "Walk, " : string.Empty) +
                            (cat.Can_Make_Sound ? "Make_Sound, " : string.Empty) +
                            (cat.Can_Swim ? "Swim, " : string.Empty);
        Console.WriteLine("Cat can: " + can.Remove(can.Length - 2, 2));

        cat.Walk();
        cat.Make_Sound();
        cat.Swim();
        Console.WriteLine();
    }

    private static void Dog()
    {
        Console.WriteLine(" -- Dog -- ");
        var dog = new Dog(Speed.Normal);

        var can = (dog.Can_Walk ? "Walk, " : string.Empty) +
                    (dog.Can_Make_Sound ? "Make_Sound, " : string.Empty) +
                    (dog.Can_Swim ? "Swim, " : string.Empty);
        Console.WriteLine("Dog can: " + can.Remove(can.Length - 2, 2));

        dog.Walk();
        dog.Make_Sound();
        dog.Swim();

        dog.Injure();

        can = (dog.Can_Walk ? "Walk, " : string.Empty) +
                            (dog.Can_Make_Sound ? "Make_Sound, " : string.Empty) +
                            (dog.Can_Swim ? "Swim, " : string.Empty);
        Console.WriteLine("Dog can: " + can.Remove(can.Length - 2, 2));

        dog.Walk();
        dog.Make_Sound();
        dog.Swim();

        Console.WriteLine();
    }

    private static void Fish()
    {
        Console.WriteLine(" -- Fish -- ");
        var fish = new Fish(Speed.Fast);

        var can = (fish.Can_Walk ? "Walk, " : string.Empty) +
                    (fish.Can_Make_Sound ? "Make_Sound, " : string.Empty) +
                    (fish.Can_Swim ? "Swim, " : string.Empty);
        Console.WriteLine("Fish can: " + can.Remove(can.Length - 2, 2));

        fish.Walk();
        fish.Make_Sound();
        fish.Swim();

        fish.Injure();

        can = (fish.Can_Walk ? "Walk, " : string.Empty) +
                            (fish.Can_Make_Sound ? "Make_Sound, " : string.Empty) +
                            (fish.Can_Swim ? "Swim, " : string.Empty);
        if (can.Length != 0)
            Console.WriteLine("Fish can: " + can.Remove(can.Length - 2, 2));
        else
            Console.WriteLine("Fish cannot do anything");

        fish.Walk();
        fish.Make_Sound();
        fish.Swim();

        Console.WriteLine();
    }

    private static void Robot()
    {
        Console.WriteLine(" -- Robot -- ");
        var robot = new Robot(Speed.Slow);

        var can = (robot.Can_Walk ? "Walk, " : string.Empty) +
                    (robot.Can_Make_Sound ? "Make_Sound, " : string.Empty) +
                    (robot.Can_Swim ? "Swim, " : string.Empty);
        Console.WriteLine("Robot can: " + can.Remove(can.Length - 2, 2));

        robot.Walk();
        robot.Make_Sound();
        robot.Swim();

        robot.Injure();

        can = (robot.Can_Walk ? "Walk, " : string.Empty) +
                            (robot.Can_Make_Sound ? "Make_Sound, " : string.Empty) +
                            (robot.Can_Swim ? "Swim, " : string.Empty);
        Console.WriteLine("Robot can: " + can.Remove(can.Length - 2, 2));

        robot.Walk();
        robot.Make_Sound();
        robot.Swim();
        Console.WriteLine();
    }

    private static void Fish_Robot()
    {
        Console.WriteLine(" -- Fish_Robot -- ");
        var fish_robot = new Fish_Robot(Speed.Normal);

        var can = (fish_robot.Can_Walk ? "Walk, " : string.Empty) +
                    (fish_robot.Can_Make_Sound ? "Make_Sound, " : string.Empty) +
                    (fish_robot.Can_Swim ? "Swim, " : string.Empty);
        Console.WriteLine("Fish_Robot can: " + can.Remove(can.Length - 2, 2));

        fish_robot.Walk();
        fish_robot.Make_Sound();
        fish_robot.Swim();

        fish_robot.Injure();

        can = (fish_robot.Can_Walk ? "Walk, " : string.Empty) +
                           (fish_robot.Can_Make_Sound ? "Make_Sound, " : string.Empty) +
                           (fish_robot.Can_Swim ? "Swim, " : string.Empty);
        Console.WriteLine("Fish_Robot can: " + can.Remove(can.Length - 2, 2));

        fish_robot.Walk();
        fish_robot.Make_Sound();
        fish_robot.Swim();
        Console.WriteLine();
    }

    private static void Robot_Dog()
    {
        Console.WriteLine(" -- Robot_Dog -- ");
        var robot_dog = new Robot_Dog(Speed.Fast);

        var can = (robot_dog.Can_Walk ? "Walk, " : string.Empty) +
                    (robot_dog.Can_Make_Sound ? "Make_Sound, " : string.Empty) +
                    (robot_dog.Can_Swim ? "Swim, " : string.Empty);
        Console.WriteLine("Robot_Dog can: " + can.Remove(can.Length - 2, 2));

        robot_dog.Walk();
        robot_dog.Make_Sound();
        robot_dog.Swim();

        robot_dog.Injure();

        robot_dog.Walk();
        robot_dog.Make_Sound();
        robot_dog.Swim();
        Console.WriteLine();
    }
}