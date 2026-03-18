// See https://aka.ms/new-console-template for more information

for (int i = 0; i < 12; i++){
    Console.WriteLine("Hello, World feature-average!??????????");
}



Console.WriteLine("Goodbye, World!");

void CalculateMax(int[] values)
{
    int max = values[0];
    for (int i = 1; i < values.Length; i++)
    {
        if (values[i] > max)
        {
            max = values[i];
        }
    }
    Console.WriteLine("Max value: " + max);
}