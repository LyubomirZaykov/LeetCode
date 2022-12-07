// See https://aka.ms/new-console-template for more information
string s = Console.ReadLine();
int num = RomanToInt(s);
Console.WriteLine(num);
int RomanToInt(string s)
{
    Dictionary<string,int> romanArabicNums= new Dictionary<string,int>();
    romanArabicNums.Add("I", 1);
    romanArabicNums.Add("V", 5);
    romanArabicNums.Add("X", 10);
    romanArabicNums.Add("L", 50);
    romanArabicNums.Add("C", 100);
    romanArabicNums.Add("D", 500);
    romanArabicNums.Add("M", 1000);
    romanArabicNums.Add("IV", 4);
    romanArabicNums.Add("IX", 9);
    romanArabicNums.Add("XL", 40);
    romanArabicNums.Add("XC", 90);
    romanArabicNums.Add("CD", 400);
    romanArabicNums.Add("CM", 900);
    int num = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (i<s.Length-1)
        {
            string subString = null;
            subString += s[i];
            subString+= s[i+1];
            if (romanArabicNums.ContainsKey(subString))
            {
                num += romanArabicNums.GetValueOrDefault(subString);
                i++;
                continue;
            }
        }
        string currNumeral = s[i].ToString();
        if (romanArabicNums.ContainsKey(currNumeral))
        {
            num += romanArabicNums.GetValueOrDefault(currNumeral);
        }
    }
    return num;
}
