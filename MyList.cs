

using System.Collections;

public class MyList<TItem> : IEnumerable<TItem>
{
	private TItem[] m_array = new TItem[4];

	public int Count { get; private set; }

	public TItem this[int index]
	{
		get
		{
			return m_array[index];
		}
		set
		{
			m_array[index] = value;
		}
	}

	public void Add(TItem item)
	{
		if (Count == m_array.Length)
		{

		}
		m_array[Count++] = item;
	}

	public void Remove(TItem item)
	{

	}

	public void RemoveAt(int index)
	{

	}

	public void Clear()
	{

	}

	public IEnumerator<TItem> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return m_array[i];
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}