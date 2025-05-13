#Este script genera un excel con el nº de palabas random que el usuario indique.

import pandas as pd
import random
import string


def generar_palabra_aleatoria(longitud):
    return ''.join(random.choices(string.ascii_lowercase, k=longitud))

palabras = [generar_palabra_aleatoria(random.randint(3, 10)) for _ in range(500)]

df = pd.DataFrame(palabras, columns=["Palabras"])

df.to_csv("500_palabras_random.csv", index=False)
