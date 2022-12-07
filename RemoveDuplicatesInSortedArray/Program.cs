// See https://aka.ms/new-console-template for more information
int[] nums = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
int result = RemoveDuplicates(nums);
Console.WriteLine(result);
int RemoveDuplicates(int[] nums)
{
	HashSet<int> result = nums.ToHashSet<int>();
	int[] expectedNums = result.ToArray();
	for(int i=0;i<nums.Length;i++)
	{
		if (i<expectedNums.Length)
		{
			nums[i] = expectedNums[i];
		}
		else
		{
            return result.Count;
        }
	}
	return result.Count;
}
