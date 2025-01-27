namespace CodeWars
{
    //CONVERT A STRING TO A NUMBER
    public class Desafios
    {
        public static int StringToNumber(string s){
        return int.Parse(s);
        }
        
        //Convert boolean values to strings 'Yes' or 'No'.
        //Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.
        public static string boolToWord(bool word)
        {
            return word ? "Yes" : "No";
        }


    }  
}