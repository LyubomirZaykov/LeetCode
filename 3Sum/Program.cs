// See https://aka.ms/new-console-template for more information

int[] nums = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
IList<IList<int>> listOfTriplets = new List<IList<int>>();
Array.Sort(nums);
if (nums == null || nums.Length < 3)
{
    //return listOfTriplets;
}
for (int i = 0; i < nums.Length - 2; i++)
{
    if (nums[i] > 0)
    {
        //return listOfTriplets;
    }
    if ((i > 0 && nums[i] == nums[i - 1]))
    {
        continue;
    }
    int j = i + 1;
    int k = nums.Length - 1;
    while (j < k)
    {
        int sum = nums[i] + nums[j] + nums[k];

        if (sum < 0)
        {
            j++;
        }
        else if (sum > 0)
        {
            k--;
        }
        else
        {

            IList<int> currList = new List<int>()
            {
                nums[i],nums[j],nums[k]
            };
            listOfTriplets.Add(currList);

            j++;
            k--;
            while (j < k && nums[j] == nums[j - 1])
            {
                j++;
            }

            while (j < k && nums[k] == nums[k + 1])
            {
                k--;
            }
        }
    }
}

