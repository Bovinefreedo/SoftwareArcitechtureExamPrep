using ConsolePractice.Reccursion;
using ConsolePractice.ONotation;


int[] nums1 = new int[1000000];
int[] nums2 = new int[1000000];

for (int i = 0; i < 1000000; i++)
{
    nums1[i] = i;
    nums2[i] = i;
}

nums2[32434] = 1;

Console.WriteLine(ONotation.containsDuplicates1(nums1));
Console.WriteLine(ONotation.containsDuplicates1(nums2));
