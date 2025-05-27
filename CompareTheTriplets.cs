public static List<int> compareTriplets(List<int> a, List<int> b)
{
	int alicePoint = 0;
	int bobPoint = 0;

	for (int i = 0; i < a.Count; i++)
	{
		if (a[i] > b[i])
		{
			alicePoint += 1;
		}
		else if (a[i] < b[i])
		{
			bobPoint += 1;
		}
		else
		{
			continue;
		}
	}

	List<int> dizi = new List<int> { alicePoint, bobPoint };
	return dizi;
}