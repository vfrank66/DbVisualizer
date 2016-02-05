using System;
using System.Data;

namespace VictorsVisualizer
{
    public class CompareData
    {
        public static bool Compare(DataRow row1, DataRow row2, int index1, int index2)
        {
            return row1[index1].ToString().IndexOf(row2[index2].ToString(), 0, row1[index1].ToString().Length, StringComparison.Ordinal) == 0;
        }

        public static bool Compare(DataRow row1, object[] row2, int index1, int index2)
        {
            return row1[index1].ToString().IndexOf(row2[index2].ToString(), 0, row1[index1].ToString().Length, StringComparison.Ordinal) == 0;
        }
    }
}