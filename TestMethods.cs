using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal enum EValueType
        {
            Two,
            Three,
            Five,
            Seven,
            Prime
        }

        internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
        {
            Stack<int> result = new Stack<int>();

            int[] arregloCopia = sourceStack.ToArray();

            List<int> resultadosSinOrdenar = new List<int>();

            for (int i = 0; i < arregloCopia.Length; i++)
            {
                int actual = arregloCopia[i];
                int masGrande = actual;

                for (int j = i; j >= 0; j--)
                {
                    if (arregloCopia[j] > masGrande)
                    {
                        masGrande = arregloCopia[j];
                    }
                }

                if (masGrande == actual)
                {
                    resultadosSinOrdenar.Add(-1);
                }
                if (masGrande > actual)
                {
                    resultadosSinOrdenar.Add(masGrande);
                }
            }
       
            for (int i = resultadosSinOrdenar.Count - 1; i >= 0; i--)
            {
                result.Push(resultadosSinOrdenar[i]);
            }

            return result;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();

            int[] copia = new int[sourceArr.Length];
            sourceArr.CopyTo(copia, 0);

            for (int i = 0; i < copia.Length; i++)
            {

                if (copia[i] % 2 == 0)
                {
                    result.Add(copia[i], EValueType.Two);
                }
                else if (copia[i] % 3 == 0)
                {
                    result.Add(copia[i], EValueType.Three);
                }
                else if (copia[i] % 5 == 0)
                {
                    result.Add(copia[i], EValueType.Five);
                }
                else if (copia[i] % 7 == 0)
                {
                    result.Add(copia[i], EValueType.Seven);
                }
                else
                {
                    result.Add(copia[i], EValueType.Prime);
                }
            }

            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            return 0;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = null;

            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = null;

            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            return result;
        }        
    }
}