
using System.Collections;

public class LinkedList<TItem> : IEnumerable<TItem>
{
	private class Node
	{
		public TItem value;
		public Node prev;
		public Node next;
	}


	public void Push(TItem value)
	{

	}

	public void Pop()
	{

	}

	public TItem Peek()
	{
		return default;
	}

	public void Clear()
	{
		
	}

	public IEnumerator<TItem> GetEnumerator()
	{
		yield return default;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}