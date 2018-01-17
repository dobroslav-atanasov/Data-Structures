public class Startup
{
    public static void Main()
    {
        ArrayList<int> list = new ArrayList<int>();
        list.Add(5);
        list[0] = list[0] + 1;
        int element = list.RemoveAt(0);
    }
}