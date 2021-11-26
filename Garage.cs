using System;
class garage:SmartHome
{
    protected new int x = 1;

    public garage()
        {
            for (int i = 0; i < x; i++)
            {
                datos[i, 1] = false;
                datos[i, 0] = true;
            }

        }
        
        public new void Mostrar()
        {
            for (int i = 0; i < x; i++)
            {
                if (datos[i, 0] == true)
                {
                    Console.WriteLine("El porton "+ (i+1)+ " esta abierto");
                }
                else if (datos[i, 0] == false && datos[i, 1] == false)
                    Console.WriteLine("El porton " + (i + 1) + " esta cerrado y desbloqueado");
                else Console.WriteLine("El porton "+ (i+1)+  " esta cerrado y bloqueado");
            }

        }
}