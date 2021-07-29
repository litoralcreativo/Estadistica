using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estadistica
{
    public static class Funciones
    {
        public static double Media(double[] muestra)
        {
            double sum = 0;
            for (int i = 0; i < muestra.Length; i++)
            {
                sum += muestra[i];
            }
            return sum / muestra.Length;
        }
        public static double Media(int[] muestra)
        {
            double sum = 0;
            for (int i = 0; i < muestra.Length; i++)
            {
                sum += muestra[i];
            }
            return sum / muestra.Length;
        }

        public static double Mediana(double[] muestra)
        {
            double result; 
            muestra = Sort(muestra);
            if (EsPar(muestra))
            {
                int middle = muestra.Length / 2;
                double superior = muestra[middle];
                double inferior = muestra[middle - 1];
                result = (superior + inferior) / 2;
            }
            else
            {
                result = muestra[(muestra.Length - 1) / 2];
            }
            return result;
        }
        public static double Mediana(int[] muestra)
        {
            double result;
            muestra = Sort(muestra);
            if (EsPar(muestra))
            {
                int middle = muestra.Length / 2;
                double superior = muestra[middle];
                double inferior = muestra[middle - 1];
                result = (superior + inferior) / 2;
            }
            else
            {
                result = muestra[(muestra.Length - 1) / 2];
            }
            return result;
        }

        public static double Moda(int[] muestra)
        {
            Dictionary<int, int> repetition = Repetitions(muestra);
            return 0;
        }

        public static DistributionSimetry Simetria(double [] muestra)
        {
            DistributionSimetry simetria;
            double media = Media(muestra);
            double mediana = Media(muestra);
            if (media == mediana)
            {
                simetria = DistributionSimetry.Symmetrical;
            } else if (media < mediana)
            {
                simetria = DistributionSimetry.NegativeSkew;
            }
            else
            {
                simetria = DistributionSimetry.PositiveSkew;
            }
            return simetria;
        }

        public static double Moda(double muestra)
        {
            return 0;
        }

        #region utils
        public static int[] Sort(int[] muestra)
        {
            int length = muestra.Length;
            int aux;
            for (int i = 1; i < length; ++i)
            {
                for (int j = 0; j < (length - i); j++)
                {
                    if (muestra[j] > muestra[j + 1])
                    {
                        aux = muestra[j];
                        muestra[j] = muestra[j + 1];
                        muestra[j + 1] = aux;
                    }
                }
            }
            return muestra;
        }
        public static double[] Sort(double[] muestra)
        {
            int length = muestra.Length;
            double aux;
            for (int i = 1; i < length; ++i)
            {
                for (int j = 0; j < (length - i); j++)
                {
                    if (muestra[j] > muestra[j + 1])
                    {
                        aux = muestra[j];
                        muestra[j] = muestra[j + 1];
                        muestra[j + 1] = aux;
                    }
                }
            }
            return muestra;
        }
        public static Dictionary<int, int> SortByRepetition(Dictionary<int, int> dictionary)
        {
            return dictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        public static bool EsPar(double[] muestra)
        {
            return muestra.Length % 2 == 0;
        }
        public static bool EsPar(int[] muestra)
        {
            return muestra.Length % 2 == 0;
        }

        public static Dictionary<int, int> Repetitions(int[] muestra)
        {
            Dictionary<int, int> repetitions = new Dictionary<int, int>();
            for (int i = 0; i < muestra.Length; i++)
            {
                int element = muestra[i];
                repetitions.TryGetValue(element, out int count);
                repetitions[element] = count + 1;
            }
            return SortByRepetition(repetitions);
        }

        public enum DistributionSimetry
        {
            Symmetrical = 0,
            NegativeSkew = -1,
            PositiveSkew = 1
        }

        #endregion
    }
}
