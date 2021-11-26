using System;
using System.Collections.Generic;
using System.Text;
abstract class SmartHome
{
        protected int x = 1;
        protected int y = 2;

        protected bool[,] datos = new bool[10, 2];
        protected bool[,] datosV = new bool[10, 2];

        public void Abrir(int x)
        {
            if (datos[x,1] == false)
            {
                if (datos[x,0] == false)
                {
                    datos[x,0] = true;
                }
                else YaAbierto();
            }
            else YaBloqueado();
        }

        public void Cerrar(int x)
        {
            if (datos[x,0] == true)
            {
                datos[x,0] = false;
            }
            else YaCerrado();
        }

        public void bloquear(int x)
        {
            if (datos[x, 0] == false)
            {
                if (datos[x, 1] == false)
                {
                    datos[x, 1] = true;
                }
                else YaBloqueado();
            }
            else ErrAbierto();
        }

        public void desbloquear(int x)
        {
                if (datos[x,1] == true)
                {
                    datos[x,1] = false;
                }
                else YaDesbloqueado();
        }

        public void Mostrar()
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(datos[i,0]);
            }
        }

        //Ventanas
        public void AbrirV(int x)
        {
            if (datosV[x, 1] == false)
            {
                if (datosV[x, 0] == false)
                {
                    datosV[x, 0] = true;
                }
                else YaAbierto();
            }
            else YaBloqueado();
        }

        public void CerrarV(int x)
        {
            if (datosV[x, 0] == true)
            {
                datosV[x, 0] = false;
            }
            else YaCerrado();
        }

        public void bloquearV(int x)
        {
            if (datosV[x, 0] == false)
            {
                if (datosV[x, 1] == false)
                {
                    datosV[x, 1] = true;
                }
                else YaBloqueado();
            }
            else ErrAbierto();
        }

        public void desbloquearV(int x)
        {
            if (datosV[x, 1] == true)
            {
                datosV[x, 1] = false;
            }
            else YaDesbloqueado();
        }

        public void MostrarV()
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(datos[i, 0]);
            }
        }

        //Errores 

        public void YaAbierto()
        {
            Console.WriteLine("Ya esta abierta");
        }

        public void YaCerrado()
        {
            Console.WriteLine("Ya esta cerrada");
        }

        public void YaBloqueado()
        {
            Console.WriteLine("Ya esta bloqueada");
        }

        public void YaDesbloqueado()
        {
            Console.WriteLine("Ya esta desbloqueada");
        }
        public void ErrAbierto()
        {
            Console.WriteLine("No se puede bloquear, esta abierta");
        }
}