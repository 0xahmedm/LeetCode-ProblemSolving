public class Solution {
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> sCounts = new Dictionary<char, int>();
        Dictionary<char, int> tCounts = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (!sCounts.ContainsKey(c))
            {
                sCounts.Add(c, 1);
            }
            else
            {
                sCounts[c]++;
            }
        }

        foreach (char c in t)
        {
            if (!sCounts.ContainsKey(c) || sCounts[c] == 0)
            {
                return false;
            }
            sCounts[c]--;
        }
        return true;
    }
}