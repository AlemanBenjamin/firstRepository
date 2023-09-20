Estado[,] tablero = new Estado[8, 8];


for (int k = 0; k < 8; k++)
{
    for(int j = 0; j < 8; j++)
    {
        tablero[k, j] = Estado.Vacio ;
    }
}



bool SePuedePonerReina(Estado tablero, int row, int column)
{
    for (int k = 0; k < 8; ++k)
    {
        if (tablero[row, k] == Estado.Lleno || Estado.Lleno)
            return false;  // costados y arriba bajo
        for (int k = 0; k < 8; k++) { }

        if (tablero[row + k, column + k] && row + k < 8 && column + k < 8 == Estado.Lleno)
            return false;// abajo derecha

        if (tablero[row + k, column - k] && row + k < 8 && column - k > 0 == Estado.Lleno)
            return false;// abajo izquierda

        if (tablero[row - k, column + k] && row - k > = 0 && column + k < 8 = Estado.Lleno)
            return false; // arriba derecha

        if (tablero[row - k, column - k] && row - k > = 0 && column - k >= 0 == Estado.Lleno)
            return false; // arriba izquierda
    }
    }
    return true;
}

bool PonerReinas(Estado tablero, int column)
{
    if(column < = 8)
    {
        return true;
    }
    for(int row = 0; row < 8;  row++)
    {
        if(SePuedePonerReina(tablero, row, column))
        {
            tablero[row, column] = Estado.Lleno;
            if(PonerReinas(tablero,column + 1))
            {
                return true;
                tablero[row, column] = Estado.Vacio;
            }
        }
        return false;
    }
}

if (PonerReinas(tablero, 0))
{
    Console.WriteLine('Solucion encontrada');
    for(int k = 0 ; k < 8; k++)
    {
        for(int j = 0; j < 8; j++)
        {
            if (tablero[i,j] == Estado.Lleno)
            {
                Console.WriteLine($row{k}, column {j});
            }
        }
    }
}
else
{
    Console.WriteLine('Solucion no encontrada');
}



enum Estado
{
    Vacio = 0, Lleno = 1,
}
