using System.ComponentModel;

IntLista nums = new IntLista();

int[] ints = new int[]{10,12,13,53,45,1,12,};

for(int i = 0; ints.Length > i; i++)
{
	nums.Add(ints[i]);
}

nums.Remove(12);


// nums.Clear();

nums.Print();

Console.WriteLine();

nums.Remove(0);

nums.Print();

Console.WriteLine(nums.Remove(0));


Console.WriteLine(nums.Contains(53));
Console.WriteLine(nums.Contains(1111111));
Console.WriteLine(nums.count);