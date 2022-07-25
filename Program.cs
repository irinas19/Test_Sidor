string[] array;
int count; 


Console.Write("count = ");
count = Int32.Parse(Console.ReadLine());

array = new string[count];

Console.WriteLine("Enter array:");

      for (int i=0; i<array.Length; i++)
      {
        Console.Write("array[{0}] = ", i);
        array[i] = Console.ReadLine();
      }
 for (int i=0; i<array.Length; i++)
 {
    if (array[i].Length <= 3)
    {
       Console.Write(array[i] + ", ");
    }
}
