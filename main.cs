using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    //there is an array of integers called celsiusTemperature. The length of this is 7.
   int[] celsiusTemperature = new int[7];
    //there is an array of integers called farenheitTemperature. The length of this is 7.
   int[] farenheitTemperature = new int[7];
    //Getting user input for the celsiusTemperature array
      for(int  i = 0; i < celsiusTemperature.Length; i++)
        {
    celsiusTemperature[i] = Convert.ToInt32(Console.ReadLine());
        }
    //Doing the maths to make celsius into farenheit
      for(int i = 0; i < farenheitTemperature.Length; i++)
        {
     farenheitTemperature[i] = celsiusTemperature[i] * 9 / 5 + 32;
        }
    //sorting the farenheitTemperature array in DESCENDING order
    Array.Reverse(farenheitTemperature);
    
    Console.WriteLine("Here are the temperatures in farenheit");
    foreach (int farenheit in farenheitTemperature)
      {
      Console.WriteLine(farenheit);
      }
     /*I'm gonna leave this horrendous mess in here, because this is the solution I came up with before figuring out how to use the foreach loop.

      Console.WriteLine(farenheitTemperature[0]);
      Console.WriteLine(farenheitTemperature[1]);
      Console.WriteLine(farenheitTemperature[2]); Console.WriteLine(farenheitTemperature[3]);Console.WriteLine(farenheitTemperature[4]); Console.WriteLine(farenheitTemperature[5]);Console.WriteLine(farenheitTemperature[6]);
    */
    //theres probably a better way to do this. 
      int sum = farenheitTemperature[0] + farenheitTemperature[1] + farenheitTemperature[2] + farenheitTemperature[3] + farenheitTemperature[4] + farenheitTemperature[5] + farenheitTemperature[6];
      Console.WriteLine("The sum of these temperatures in farenhit is " + sum);
      int avg = sum / 7;
      Console.WriteLine("The average temperture in farenheit for the next seven days is " + avg + " degrees.");
    }
    }