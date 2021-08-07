using System;

namespace Line_Comparison_Oops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Comparison Program!");

            UC1_Length.getCartesian();
            UC2_CheckLinesareEqual.getCartesian();
            UC3_CheckTwoLines.getCartesian();
            UC4_LineCompare obj = new UC4_LineCompare();
            obj.input();
            obj.cal();
            obj.CompareLines();
        }
    }
}
