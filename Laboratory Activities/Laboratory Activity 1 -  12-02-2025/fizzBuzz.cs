using System;
class HelloWorld {
  static void Main() {
    
        for (int upperBound = 1; upperBound <=15; upperBound++)
        {
            if (((upperBound%5) ==0) && ((upperBound%3) == 0) ==true){
               Console.WriteLine("FizzBuzz");
            }
            else if ((upperBound%3) ==0)
            {
                Console.WriteLine ("Fizz");
            }
            else if ((upperBound%5) ==0){
                Console.WriteLine("Buzz");
            }
            else{
                Console.WriteLine($"{upperBound}");
            }
        }
}
}