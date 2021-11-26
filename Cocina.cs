using System;
using System.Collections.Generic;
using System.Text;

class cocina:SmartHome
{
    protected new int x = 5;
    protected new int y = 1;

    public cocina()
        {
            for (int i = 0; i < x; i++)
            {
                datos[i, 1] = false;
                datos[i, 0] = true;
            }
            for (int i = 0; i < y; i++)
            {
                datosV[i, 1] = false;
                datosV[i, 0] = true;
            }

        }
        
        public new void Mostrar()
        {
            for (int i = 0; i < x; i++)
            {
                if (datos[i, 0] == true)
                {
                    Console.WriteLine("La puerta "+ (i+1)+ " esta abierta");
                }
                else if (datos[i, 0] == false && datos[i, 1] == false)
                    Console.WriteLine("La puerta " + (i + 1) + " esta cerrada y desbloqueada");
                else Console.WriteLine("La puerta "+ (i + 1)+  " esta cerrada y bloqueada");
            }

        }
        public new void MostrarV()
        {
            for (int i = 0; i < y; i++)
            {
                if (datosV[i, 0] == true)
                {
                    Console.WriteLine("La ventana " + (i + 1) + " esta abierta");
                }
                else if (datosV[i, 0] == false && datosV[i, 1] == false)
                    Console.WriteLine("La ventana " + (i + 1) + " esta cerrada y desbloqueada");
                else Console.WriteLine("La ventana " + (i + 1) + " esta cerrada y bloqueada");
            }

        }
    
}