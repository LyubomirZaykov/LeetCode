// See https://aka.ms/new-console-template for more information

string[] input = Console.ReadLine().Split(",");
string commonPrefix = LongestCommonPrefix(input);
Console.WriteLine(commonPrefix);
string LongestCommonPrefix(string[] strs)
{
    string shortestString = strs.OrderBy(str => str.Length).First();
    string commonPrefix = shortestString;
    int j = 0;
    bool isCommon = false;
    for (int i = 0; i < strs.Length; i++)
    {
        
        while (j<shortestString.Length)
        {
            isCommon = strs[i][j] == shortestString[j];
            //if (i==0)
            //{
            //    commonPrefix += shortestString[j];
            //    j++;
            //    continue;
            //}
            if (isCommon)
            {
                j++;
                continue;
            }
            else
            {
                if (j==1)
                {
                    return "";
                }
                commonPrefix = commonPrefix.Substring(0, j);
                break;
            }
        }
        j = 0;
    }
    return commonPrefix+"\"";
}