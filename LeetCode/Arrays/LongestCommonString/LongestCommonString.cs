public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string commonPrefix = "";
        int stringsCount = strs.Length;
        if(stringsCount > 0)
        {
            commonPrefix = strs[0];
            int currentStringLength = 0;

            for(int i=1; i< stringsCount; i++)
            {
                currentStringLength = strs[i].Length;
                if(currentStringLength < commonPrefix.Length)
                {
                    commonPrefix = commonPrefix.Substring(0, currentStringLength);
                }
                if(commonPrefix.Length == 0)
                {
                    break;
                }

                for(int j=0; j<currentStringLength; j++)
                {
                    if(j > commonPrefix.Length-1)
                    {
                        break;
                    }
                    if(strs[i][j] != commonPrefix[j])
                    {
                        commonPrefix = commonPrefix.Substring(0, j);
                    }
                }
            }
        }
        return commonPrefix;
    }
}