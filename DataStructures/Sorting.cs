namespace DataStructures;

partial class Program
{
	public class Sorting
{

	// TIME : best case, avg case, worst case
	// SPACE : best case, avg case, worst case


	// O(n^2), O(n^2), O(n^2)
	// O(1) // temp 
	public static void bubble(int[] arr)
	{
		int n = arr.Length;

		for (int i = 0; i < n - 1; i++)
			for (int j = 0; j < n - 1; j++)
				if (arr[j] > arr[j + 1])
				{
					int temp = arr[j];
					arr[j] = arr[j + 1];
					arr[j + 1] = temp;
				}

	}

	// O(n) ,O(n^2), O(n^2)
	// O(1)
	public static void Insertion(int[] dizi)
	{
		int temp, j;

		for (int i = 1; i < dizi.Length; i++)
		{
			temp = dizi[i];
			j = i - 1;

			while (j >= 0 && temp < dizi[j])
				dizi[j + 1] = dizi[j--];
			dizi[j + 1] = temp;
		}
	}

	// O(n^2), O(n^2), O(n^2)
	//O(1)
	public static void Selection(int[] a)
	{
		int temp, min;

		for (int i = 0; i < a.Length - 1; i++)
		{
			min = i;

			for (int j = i; j < a.Length; j++)
				if (a[min] > a[j])
					min = j;

			temp = a[min];
			a[min] = a[i];
			a[i] = temp;

		}
	}

	// all O(n*logn)
	//O(n)
	public static void mergeSort(int[] dizi, int beg, int end)
	{
		if (beg < end)
		{
			int mid = (beg + end) / 2;
			mergeSort(dizi, beg, mid);
			mergeSort(dizi, mid + 1, end);
			merge(dizi, beg, mid, end);
		}
	}
	private static void merge(int[] dizi, int beg, int mid, int end)
	{
		int i, j, k = beg;

		int l = mid - beg + 1;
		int r = end - mid;

		int[] Left = new int[l];
		int[] Right = new int[r];

		for (i = 0; i < l; i++)
			Left[i] = dizi[beg + i];

		for (j = 0; j < r; j++)
			Right[j] = dizi[j + mid + 1];

		j = i = 0;
		// left = i

		while (i < l && j < r)
		{
			if (Left[i] <= Right[j])
				dizi[k] = Left[i++];
			else
				dizi[k] = Right[j++];
			k++;
		}

		while (i < l)
			dizi[k++] = Left[i++];

		while (j < r)
			dizi[k++] = Right[j++];

	}

	// O(n*logn), O(n*logn), O(n^2) 
	// O(n*logn)
	public static void quick(int[] a, int beg, int end)
	{
		if (beg < end)
		{
			int p = partition(a, beg, end);
			quick(a, beg, p - 1);
			quick(a, p + 1, end);
		}
	}
	private static int partition(int[] a, int beg, int end)
	{
		int pivot = a[end];
		int t, i = beg - 1;

		for (int j = beg; j < end; j++)
		{
			if (a[j] < pivot)
			{
				t = a[j];
				a[j] = a[++i];
				a[i] = t;
			}
		}

		int t2 = a[end];
		a[end] = a[++i];
		a[i] = t2;

		return i;
	}
}
}