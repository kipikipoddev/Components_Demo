namespace Step_1_Copy_Paste_Approach;


public class Program
{
    private static void Main(string[] args)
    {
        var cat = new Cat();
        cat.Walk(Speed.Slow);
        cat.Make_Sound();

        var dog = new Dog();
        dog.Walk(Speed.Slow);
        dog.Make_Sound();
        dog.Swim();

        var fish = new Fish();
        fish.Swim();

        var robot = new Robot();
        robot.Walk(Speed.Slow);
        robot.Make_Sound();

        var robot_dog = new Robot_Dog();
        robot_dog.Walk(Speed.Slow);
        robot_dog.Make_Sound();
        robot_dog.Swim();

        var fish_Robot = new Fish_Robot();
        fish_Robot.Make_Sound();
        fish_Robot.Swim();
    }
}