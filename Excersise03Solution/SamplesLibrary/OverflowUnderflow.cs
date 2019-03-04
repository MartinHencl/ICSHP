namespace SamplesLibrary
{
    class OverflowUnderflow
    {
        public static void DoItFlow()
        {
            uint max = uint.MaxValue;
            uint min = uint.MinValue;

            System.Console.WriteLine($"max: {max}, min: {min}");
            checked
            {
                max++;
                min--;
            }
            System.Console.WriteLine($"max: {max}, min: {min}");
        }
    }
}
