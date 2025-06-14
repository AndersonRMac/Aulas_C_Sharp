namespace CodeWars
{
    public class CodeWarsTests
    {
        //CONVERT A STRING TO A NUMBER
        public static int StringToNumber(string s)
        {
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
        public static double SumArray(double[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }
            else
            {
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
            return (n > 10) ? "Great, now move on to tricks" : "Keep at it until you get it";
        }
        /*
        Messi goals function
        Messi is a soccer player with goals in three leagues:LaLiga, Copa del Rey, Champions
        Complete the function to return his total number of goals in all three leagues.
        Note: the input will always be valid.
        For example:
        5, 10, 2  -->  17
        */
        public static int GetGoals(int laLigaGoals, int copaDelReyGoals, int championsLeagueGoals)
        {

            int total = laLigaGoals + copaDelReyGoals + championsLeagueGoals;
            return total;

        }

        /*
        The cockroach is one of the fastest insects. Write a function which takes its speed in km per hour and returns
         it in cm per second, rounded down to the integer (= floored).*/
        public static int CockroachSpeed(double x)
        {
            int ConvertValor = (int)(x * 27.7778);
            return ConvertValor;
        }

        /*
        Clock shows h hours, m minutes and s seconds after midnight.
        Your task is to write a function which returns the time since midnight in milliseconds.*/
        public static int relogio(int h, int m, int s)
        {
            h = *3600000;
            m = *60000;
            s = *1000;
            return h + m + s;
        }
        public static boolean setAlarm(bool employed, bool vacation)
        {
            return (employed, vacation) switch
            {
                (true, true) => false,
                (true, false) => true,
                (false, true) => false,
                (false, false) => false,
            };
            /*
            switch (employed | vacation)
            {
                case employed | vacation: true | true = false;
                case employed | vacation: true | false = true;
                case employed | vacation: false | true = false;
                case employed | vacation: false | false = false;
            }*/
            




        }
    }
}