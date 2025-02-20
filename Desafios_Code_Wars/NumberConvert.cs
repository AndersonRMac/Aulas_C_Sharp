namespace CodeWars
{
    public class Desafios
    {
            //CONVERT A STRING TO A NUMBER
        public static int StringToNumber(string s){
        return int.Parse(s);
        }
        
        //Convert boolean values to strings 'Yes' or 'No'.
        //Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.
        public static string boolToWord(bool word)
        {
            return word ? "Yes" : "No";
        }

        //Sum Arrays
        /*Write a function that takes an array of numbers and returns the sum of the numbers. The numbers can be negative or non-integer.
         If the array does not contain any numbers then you should return 0.*/
         public static double SumArray (double[] numbers)
         {
            if (numbers.Length == 0)
            {
                return 0;
            }else{
                double cont = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    cont += numbers[i];
                }
                return cont;
            }
         }

        //NumberToString
         public static string NumberToString(int num)
        {
            return num.ToString();
        }

        /*Alex just got a new hula hoop, he loves it but feels discouraged because his little brother is better than him.
Write a program where Alex can input (n) how many times the hoop goes round and it will return him an encouraging message:
If Alex gets 10 or more hoops, return the string "Great, now move on to tricks".
If he doesn't get 10 hoops, return the string "Keep at it until you get it".*/

        public static string HoopCount(int n)
        {
            return (n > 10)?"Great, now move on to tricks" : "Keep at it until you get it";
        }
    }  
}