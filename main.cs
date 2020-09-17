using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("What is your name?");
    string name = Console.ReadLine();

    Console.WriteLine("What is your height in inches?");
    double height = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("What is your weight in pounds?");
    double weight = Convert.ToDouble(Console.ReadLine());

    double BMI = (703 * weight)/(height * height);
    Console.WriteLine(name + ", your BMI is " + BMI + ".");

    if (BMI < 18.5)
    {
      Console.WriteLine("Well, " + name + "you are underweight.");
    }
    else if (BMI >= 18.5 && BMI <= 24.9)
    {
      Console.WriteLine("Well, " + name + "you are normal/average based on the numbers.");
    }
    else if (BMI >= 25 && BMI <= 29.9)
    {
      Console.WriteLine("Well, " + name + "you are overweight...");
    }
    else if (BMI >= 30)
    {
      Console.WriteLine("Welll, " + name + "you are obese,,,.");
    }
    else 
    {

    } 


  }
}