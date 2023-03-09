namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static int GetSquare(this int value)
        {
            return (int)Math.Pow(value, 2);
        }

        public static string RemoveMiddleEmpty(this string value)
        {
            return value.Replace(" ", "");
        }

        public static string NextLetter(this Random random, bool isUpper = false)
        {

            int randomNumber = isUpper ? random.Next(65, 91) : random.Next(97, 122);
            char letter = (char)randomNumber;
            return Convert.ToString(letter);

        }

        public static string NextWord(this Random random, int count, bool isUpper = false)
        {
            string word = string.Empty;
            for (int i = 0; i < count; i++)
            {
                word += random.NextLetter(isUpper);
            }

            return word;
        }

    }


}
