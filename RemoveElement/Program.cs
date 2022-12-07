using System.ComponentModel.DataAnnotations;

int[] nums = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
int val = int.Parse(Console.ReadLine());
int result = RemoveElement(nums, val);
Console.WriteLine(result);

int RemoveElement(int[] nums, int val)
{
    int[] newArr=nums;
    int j = 0;
    for (int i = 0; i < newArr.Length;)
    {
        int currNum = newArr[i];
        if (currNum == val)
        {
            i++;
            continue;
        }
        else
        {
            nums[j]=currNum;
            i++;
            j++;
        }
        
    }
    
    return j;
}