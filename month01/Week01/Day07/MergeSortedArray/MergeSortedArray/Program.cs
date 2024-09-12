
int[] arr1 = new int[] {1, 2, 3, 0, 0, 0};

int[] arr2 = new int[] { 2, 5, 6 };

GFG.mergeArrays(arr1, arr2);


Console.WriteLine("Array after merging");
for (int i = 0; i < arr1.Length; i++)
    Console.Write(arr1[i] + " ");


Console.ReadKey();

public class GFG
{
    public static void mergeArrays(int[] arr1, int[] arr2)
    {
        int n = 0;
        for(int i = 0;i < arr1.Length; i++)
        {
            if (arr1[i] == 0)
                arr1[i] = arr2[n++];
        }
        

        // sort the whole array arr3
        Array.Sort(arr1);
    }
}