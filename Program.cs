string[] array;
int count; 
string[] result;

Console.Write("count = ");
count = Int32.Parse(Console.ReadLine());

array = new string[count];

Console.WriteLine("Enter array:");

      for (int i=0; i<array.Length; i++)
      {
        Console.Write("array[{0}] = ", i);
        array[i] = Console.ReadLine();
      }
result = new string[count];
     for (int i=0; i<array.Length; i++)
      {
       if (array[i].Length <= 3)
          {
            result[i] = array[i];
            Console.Write(result[i] + ", ");
          }
      }
