class Program
{
	public interface IInter<T>
	{
		T GetValue();
	}

	public class MyClass : IInter<int>
	{
		private int m_value = 1;
		public MyClass()
		{

		}

		public int value => m_value;

		public void SetValue(int value)
		{
			this.m_value = value;
		}

		public int GetValue()
		{
			return m_value;
		}
	}

	static void Main()
	{
		// MyList<int> myList = new MyList<int>();
		// myList.Add(1);
		// myList.Add(2);
		// myList.Add(3);
		// // myList.Remove(2);
		// // myList.RemoveAt(0);

		// for (int i = 0; i < myList.Count; i++)
		// {
		// 	Console.WriteLine(myList[i]);
		// }

		// foreach (int item in myList)
		// {
		// 	Console.WriteLine(item);
		// }

		// Print(0);
		// Print(0.1f);
		// List<int> list = new List<int>();
		// list.Add(0);
		// list.Add(5);
		// list.Add(10);
		// foreach (int item in list)
		// {
		// 	Console.WriteLine(item);
		// }

		Animals animal = Animals.Lion;
		switch(animal)
		{
			case Animals.Cat : Console.WriteLine("select cat"); break;
			case Animals.Dog: Console.WriteLine("select dog"); break;
			case Animals.Lion: Console.WriteLine("select lion"); break;
		}

		Print(animal);
		Print(Animals.Monkey);
	}

	

	public static void Print(Animals p)
	{
		Console.WriteLine(p);
	}

	public enum Animals
	{
		Cat,
		Dog,
		Monkey,
		Lion,
	}

}