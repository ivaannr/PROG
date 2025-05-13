        using (StreamReader sr = new StreamReader(fichero))
        {
            string linea;
            while ((linea = sr.ReadLine()) != null)
            {
                int numero = int.Parse(linea);
                InsertarOrdenado(sw, numero);
            }
        }
    }
    static void InsertarOrdenado(StreamWriter sw, int numero)
    {
        // Leer el contenido actual del fichero de salida
        string[] lineas = File.ReadAllLines(sw.BaseStream.ToString());
        bool insertado = false;
        // Insertar el número en su posición ordenada
        for (int i = 0; i < lineas.Length; i++)
        {
            int numeroExistente = int.Parse(lineas[i]);
            if (numero < numeroExistente)
            {
                // Escribir el nuevo número antes del existente
                sw.WriteLine(numero);
                insertado = true;
                break;
            }
            else
            {
                // Escribir el número existente
                sw.WriteLine(numeroExistente);
            }
        }
        // Si no se insertó, escribir al final
        if (!insertado)
        {
            sw.WriteLine(numero);
        }
    }
}
