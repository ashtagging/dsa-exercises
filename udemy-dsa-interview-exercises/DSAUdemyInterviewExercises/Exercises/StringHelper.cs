namespace Exercises
{
    public static class StringHelper
    {
        public static string ReverseString(string inputString)
        {
            var charArray = inputString.ToCharArray();
            int length = inputString.Length;

            for (int i = 0; i < length; i++)
            {
                charArray[length - i - 1] = inputString[i];
            }

            return new string(charArray);
        }
    }
}
