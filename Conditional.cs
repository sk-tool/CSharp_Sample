// if文による条件分岐　else if
using System;
public class Program{
    public static void Main(){
        var random = new Random();
        var number = random.Next(1, 6);
        Console.WriteLine("あなたの順位は" + number + "位です");
        if (number == 1) {
            Console.WriteLine("おめでとう");
        } else if (number == 2) {
            Console.WriteLine("あと少し");
        } else {
            Console.WriteLine("よくがんばったね");
        }
    }
}
