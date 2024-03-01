using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class IntLista
{
	public int[] number {get; private set;} = new int[10];
	
	public int count {get; private set;}
	
	private int addedindex = 0;
		
	public IntLista() 
	{
		
	}
	public void Add(int num)
	{
		number[addedindex] = num;
		addedindex++;
		count++;
	}
	
	public bool Remove(int num2)
	{
		for(int i = 0; i < number.Length; i++)
		{
			if(number[i] == num2)
			{
				number[i] = 0;
				count--;
				return true;
			}
		}
		return false;
	}
	
	public void Clear()
	{
		Array.Clear(number);
	}
	
	public bool Contains(int num3)
	{
		if(number.Contains(num3))
		{
			return true;
		}
		return false;
	}
	
	public void Print()
	{
		foreach (var item in number)
		{
			Console.WriteLine(item);
		}
	}
}