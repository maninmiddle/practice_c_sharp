class Program
{
   public static void Main() {
	int[] array = new int[15];
        Random rand = new Random();
        
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-50, 51);
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }
	Console.WriteLine($"Максимальный элемент: {array[maxIndex]} на позиции {maxIndex}");
	int temp = array[0];
        array[0] = array[maxIndex];
        array[maxIndex] = temp;
        
        Console.WriteLine("Массив после обмена:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

   }
}
