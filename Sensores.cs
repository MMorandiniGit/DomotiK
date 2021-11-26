using System;
using System.Text;
class Sensores:SmartHome
    {
        private bool estado = false;
        public void Cambiar()
        {
            if (estado == true)
                estado = false;
            else estado = true;
        }

        public new void Mostrar()
        {
            if (estado == true)
                Console.WriteLine("Sensor encendido");
            else Console.WriteLine("Sensor apagado");
        }
    }