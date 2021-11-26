using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace Vs_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion, opcion2, opcion3, opcion4, opcion5, opcion6, opcion7, opcion8;

            //Cuartos
            cuartos cuarto = new cuartos();
            cuartos cuarto1 = new cuartos();
            cuartos cuarto2 = new cuartos();
            cuartos cuarto3 = new cuartos();
            //Cocina
            cocina cocina = new cocina();
            //Living
            living living = new living();
            //Playroom
            playroom playroom = new playroom();
            //Garages
            garage garage = new garage();
            garage garage1 = new garage();


            do
            {
                
                Console.WriteLine("-------OPCIONES-------");
                Console.WriteLine("1) Ver puertas y ventanas");
                Console.WriteLine("2) Abrir, cerrar, bloquear y desbloquear las puertas y ventanas");
                Console.WriteLine("0) Salir");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("-------OPCIONES-------");
                            Console.WriteLine("1) Ver puertas y ventanas de la cocina");
                            Console.WriteLine("2) Ver puertas y ventanas de las habitaciones");
                            Console.WriteLine("3) Ver puertas y ventanas del playroom");
                            Console.WriteLine("4) Ver puertas y ventanas del living");
                            Console.WriteLine("5) Ver porton del garage");
                            Console.WriteLine("0) Para volver atras");
                            opcion2 = int.Parse(Console.ReadLine());
                            switch(opcion2)
                            {
                                case 1:
                                Console.WriteLine("Puertas: ");
                                cocina.Mostrar();
                                Console.WriteLine("Ventanas: ");
                                cocina.MostrarV();
                                break;
                                case 2:
                                Console.WriteLine("Elegi el cuarto: ");
                                    do
                                    {
                                        Console.WriteLine("1) Para el cuarto 1");
                                        Console.WriteLine("2) Para el cuarto 2");
                                        Console.WriteLine("3) Para el cuarto 3");
                                        Console.WriteLine("4) Para el cuarto 4");
                                        Console.WriteLine("0) Para volver");
                                        opcion3 = int.Parse(Console.ReadLine());
                                        switch(opcion3)
                                        {
                                            case 1:
                                            Console.WriteLine("Puerta: ");
                                            cuarto.Mostrar();
                                            Console.WriteLine("Ventanas: ");
                                            cuarto.MostrarV();
                                            break;
                                            case 2:
                                            Console.WriteLine("Puerta: ");
                                            cuarto1.Mostrar();
                                            Console.WriteLine("Ventanas: ");
                                            cuarto1.MostrarV();
                                            break;
                                            case 3:
                                            Console.WriteLine("Puerta: ");
                                            cuarto2.Mostrar();
                                            Console.WriteLine("Ventanas: ");
                                            cuarto2.MostrarV();
                                            break;
                                            case 4:
                                            Console.WriteLine("Puerta: ");
                                            cuarto3.Mostrar();
                                            Console.WriteLine("Ventanas: ");
                                            cuarto3.MostrarV();
                                            break;
                                        }
                                    }while(opcion3 != 0);
                                break;
                                case 3:
                                Console.WriteLine("Puertas: ");
                                playroom.Mostrar();
                                Console.WriteLine("Ventanas: ");
                                playroom.MostrarV();
                                break;
                                case 4:
                                Console.WriteLine("Pueras: ");
                                living.Mostrar();
                                Console.WriteLine("Ventanas: ");
                                living.MostrarV();
                                break;
                                case 5:
                                Console.WriteLine("Elegi el garage: ");
                                    do
                                    {
                                        Console.WriteLine("1) Para ver el garage 1");
                                        Console.WriteLine("2) Para ver el garage 2");
                                        Console.WriteLine("0) para volver");
                                        opcion4 = int.Parse(Console.ReadLine());
                                        switch(opcion4)
                                        {
                                            case 1:
                                            
                                            Console.WriteLine("Garage: ");
                                            garage.Mostrar();
                                            break;
                                            case 2:
                                            
                                            Console.WriteLine("Garage: ");
                                            garage1.Mostrar();
                                            break;
                                        }
                                    }while (opcion4 != 0);
                                break;
                            }
                        }while(opcion2 !=0);
                    break;
                    case 2:
                        do
                        {
                            
                            Console.WriteLine("-------OPCIONES-------");
                            Console.WriteLine("1) Cuartos");
                            Console.WriteLine("2) Cocina");
                            Console.WriteLine("3) Living");
                            Console.WriteLine("4) Playroom");
                            Console.WriteLine("5) Garage");
                            Console.WriteLine("6) Sensores");
                            Console.WriteLine("0) Para volver atras");
                            opcion5 = int.Parse(Console.ReadLine());
                                switch(opcion5)
                                {
                                    case 1:
                                        do
                                        {
                                            Console.WriteLine("-------Cuartos-------");
                                            Console.WriteLine("1) 1er cuarto");
                                            Console.WriteLine("2) 2do cuarto");
                                            Console.WriteLine("3) 3er cuarto");
                                            Console.WriteLine("4) 4to cuarto");
                                            Console.WriteLine("0) Para volver");
                                            opcion6 = int.Parse(Console.ReadLine());
                                            switch(opcion6)
                                            {
                                                case 1:
                                                    do
                                                    {
                                                        Console.WriteLine("Cuarto 1: ");
                                                        Console.WriteLine("1) Para abrir");
                                                        Console.WriteLine("2) Para cerrar");
                                                        Console.WriteLine("3) Para bloquear");
                                                        Console.WriteLine("4) Para desbloquear");
                                                        Console.WriteLine("0) Para volver atras");
                                                        opcion7 = int.Parse(Console.ReadLine());
                                                        switch(opcion7)
                                                        {
                                                            case 1:
                                                            
                                                            Console.WriteLine("Abriste la puerta");
                                                            cuarto.Abrir(0);
                                                            break;
                                                            case 2:
                                                            
                                                            Console.WriteLine("Cerraste la puerta");
                                                            cuarto.Cerrar(0);
                                                            break;
                                                            case 3:
                                                            
                                                            Console.WriteLine("Bloqueaste la puerta");
                                                            cuarto.bloquear(0);
                                                            break;
                                                            case 4:
                                                            
                                                            Console.WriteLine("Desbloqueaste la puera");
                                                            cuarto.desbloquear(0);
                                                            break;
                                                        }
                                                    }while(opcion7 != 0);
                                                break;
                                                case 2:
                                                    do
                                                    {
                                                        Console.WriteLine("Cuarto 2: ");
                                                        Console.WriteLine("1) Para abrir");
                                                        Console.WriteLine("2) Para cerrar");
                                                        Console.WriteLine("3) Para bloquear");
                                                        Console.WriteLine("4) Para desbloquear");
                                                        Console.WriteLine("0) Para volver atras");
                                                        opcion7 = int.Parse(Console.ReadLine());
                                                        switch(opcion7)
                                                        {
                                                            case 1:
                                                            
                                                            Console.WriteLine("Abriste la puerta");
                                                            cuarto1.Abrir(0);
                                                            break;
                                                            case 2:
                                                            
                                                            Console.WriteLine("Cerraste la puerta");
                                                            cuarto1.Cerrar(0);
                                                            break;
                                                            case 3:
                                                            
                                                            Console.WriteLine("Bloqueaste la puerta");
                                                            cuarto1.bloquear(0);
                                                            break;
                                                            case 4:
                                                            
                                                            Console.WriteLine("Desbloqueaste la puera");
                                                            cuarto1.desbloquear(0);
                                                            break;
                                                        }
                                                    }while(opcion7 != 0);
                                                break;
                                                case 3:
                                                    do
                                                    {
                                                        Console.WriteLine("Cuarto 3: ");
                                                        Console.WriteLine("1) Para abrir");
                                                        Console.WriteLine("2) Para cerrar");
                                                        Console.WriteLine("3) Para bloquear");
                                                        Console.WriteLine("4) Para desbloquear");
                                                        Console.WriteLine("0) Para volver atras");
                                                        opcion7 = int.Parse(Console.ReadLine());
                                                        switch(opcion7)
                                                        {
                                                            case 1:
                                                            
                                                            Console.WriteLine("Abriste la puerta");
                                                            cuarto2.Abrir(0);
                                                            break;
                                                            case 2:
                                                            
                                                            Console.WriteLine("Cerraste la puerta");
                                                            cuarto2.Cerrar(0);
                                                            break;
                                                            case 3:
                                                            
                                                            Console.WriteLine("Bloqueaste la puerta");
                                                            cuarto2.bloquear(0);
                                                            break;
                                                            case 4:
                                                            
                                                            Console.WriteLine("Desbloqueaste la puera");
                                                            cuarto2.desbloquear(0);
                                                            break;
                                                        }
                                                    }while(opcion7 != 0);
                                                break;
                                                case 4:
                                                    do
                                                    {
                                                        Console.WriteLine("Cuarto 4: ");
                                                        Console.WriteLine("1) Para abrir");
                                                        Console.WriteLine("2) Para cerrar");
                                                        Console.WriteLine("3) Para bloquear");
                                                        Console.WriteLine("4) Para desbloquear");
                                                        Console.WriteLine("0) Para volver atras");
                                                        opcion7 = int.Parse(Console.ReadLine());
                                                        switch(opcion7)
                                                        {
                                                            case 1:
                                                            
                                                            Console.WriteLine("Abriste la puerta");
                                                            cuarto3.Abrir(0);
                                                            break;
                                                            case 2:
                                                            
                                                            Console.WriteLine("Cerraste la puerta");
                                                            cuarto3.Cerrar(0);
                                                            break;
                                                            case 3:
                                                            
                                                            Console.WriteLine("Bloqueaste la puerta");
                                                            cuarto3.bloquear(0);
                                                            break;
                                                            case 4:
                                                            
                                                            Console.WriteLine("Desbloqueaste la puera");
                                                            cuarto3.desbloquear(0);
                                                            break;
                                                        }
                                                    }while(opcion7 != 0);
                                                break;
                                            }
                                        }while(opcion6!=0);
                                    break;
                                    case 2:
                                        Console.WriteLine("-------Cocina-------");
                                        Console.WriteLine("1) Para abrir");
                                        Console.WriteLine("2) Para cerrar");
                                        Console.WriteLine("3) Para bloquear");
                                        Console.WriteLine("4) Para desbloquear");
                                        Console.WriteLine("0) Para volver atras");
                                        opcion8 = int.Parse(Console.ReadLine());
                                        switch(opcion8)
                                        {
                                            case 1:
                                            Console.WriteLine("------Puertas------");
                                            Console.WriteLine("Que puerta queres abir?: ");
                                            Console.WriteLine("Hay 5 puertas elegi una opcion del 0-4");
                                            Console.WriteLine("0) Para la primer puerta ");
                                            Console.WriteLine("1) Para la segunda puerta");
                                            Console.WriteLine("2) Para la tercer puerta");
                                            Console.WriteLine("3) Para la cuarta puerta");
                                            Console.WriteLine("4) Para la quinta puerta");
                                            cocina.Abrir(int.Parse(Console.ReadLine()));
                                            break;
                                            case 2:
                                            Console.WriteLine("------Puertas------");
                                            Console.WriteLine("Que puerta queres cerrar?: ");
                                            Console.WriteLine("Hay 5 puertas elegi una opcion del 0-4");
                                            Console.WriteLine("0) Para la primer puerta ");
                                            Console.WriteLine("1) Para la segunda puerta");
                                            Console.WriteLine("2) Para la tercer puerta");
                                            Console.WriteLine("3) Para la cuarta puerta");
                                            Console.WriteLine("4) Para la quinta puerta");
                                            cocina.Cerrar(int.Parse(Console.ReadLine()));
                                            Console.WriteLine("Cerraste la puerta");
                                            break;
                                            case 3:
                                            Console.WriteLine("------Puertas------");
                                            Console.WriteLine("Que puerta queres cerrar?: ");
                                            Console.WriteLine("Hay 5 puertas elegi una opcion del 0-4");
                                            Console.WriteLine("0) Para la primer puerta ");
                                            Console.WriteLine("1) Para la segunda puerta");
                                            Console.WriteLine("2) Para la tercer puerta");
                                            Console.WriteLine("3) Para la cuarta puerta");
                                            Console.WriteLine("4) Para la quinta puerta");
                                            cocina.Cerrar(int.Parse(Console.ReadLine()));
                                            Console.WriteLine("Bloqueaste la puerta");
                                            break;
                                            case 4:
                                            Console.WriteLine("------Puertas------");
                                            Console.WriteLine("Que puerta queres cerrar?: ");
                                            Console.WriteLine("Hay 5 puertas elegi una opcion del 0-4");
                                            Console.WriteLine("0) Para la primer puerta ");
                                            Console.WriteLine("1) Para la segunda puerta");
                                            Console.WriteLine("2) Para la tercer puerta");
                                            Console.WriteLine("3) Para la cuarta puerta");
                                            Console.WriteLine("4) Para la quinta puerta");
                                            cocina.Cerrar(int.Parse(Console.ReadLine()));
                                            Console.WriteLine("Desbloqueaste la puerta");
                                            break;
                                        }
                                    break;
                                }
                            }while(opcion5 != 0);
                        break;
                }
            }while(opcion != 0);
        }
    }
}
