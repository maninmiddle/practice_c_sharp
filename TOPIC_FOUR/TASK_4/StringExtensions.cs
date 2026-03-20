using System;

static class StringExtensions
{
    public static int CountVowels(this string str)
    {
        int count = 0;
        string vowels = "aeiouyAEIOUYаеёиоуыэюяАЕЁИОУЫЭЮЯ";
        foreach (char c in str)
            if (vowels.Contains(c))
                count++;
        return count;
    }
}

