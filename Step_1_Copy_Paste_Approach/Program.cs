﻿namespace Step_1_Copy_Paste_Approach;


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
        dog.Swim();

        var fish = new Fish();
        fish.Swim();

        var robot = new Robot();
        robot.Walk();
        robot.Make_Sound();

        var robot_dog = new Robot_Dog();
        robot_dog.Walk();
        robot_dog.Make_Sound();

        var fish_Robot = new Fish_Robot();
        fish_Robot.Make_Sound();
        fish_Robot.Swim();
    }
}