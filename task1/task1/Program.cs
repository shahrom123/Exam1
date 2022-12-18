

int cnt = 0, n;
n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 1; i <= n; i++)
{
    if (arr[i - 1] != arr[i])
    {
        cnt++;
    }
}
Console.WriteLine(cnt);
