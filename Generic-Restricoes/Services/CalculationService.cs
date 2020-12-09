using System;
using System.Collections.Generic;

namespace Generic_Restricoes.Services
{
    class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable  //where faz a comparação
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
