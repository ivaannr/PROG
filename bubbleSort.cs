static void BubbleSort(int[] array)
    {
        int n = array.Length;
        bool intercambiado;

        for (int i = 0; i < n - 1; i++)
        {
            intercambiado = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;

                    intercambiado = true;
                }
            }

           
            if (!intercambiado) break;
        }
    }
