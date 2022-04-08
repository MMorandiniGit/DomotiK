using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using static System.Console;

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
                
                WriteLine("-------OPCIONES-------");
                WriteLine("1) Ver puertas y ventanas");
                WriteLine("2) Abrir, cerrar, bloquear y desbloquear las puertas y ventanas");
                WriteLine("0) Salir");
                opcion = int.Parse(ReadLine());
                switch(opcion)
                {
                    case 1:
                        do
                        {
                            WriteLine("-------OPCIONES-------");
                            WriteLine("1) Ver puertas y ventanas de la cocina");
                            WriteLine("2) Ver puertas y ventanas de las habitaciones");
                            WriteLine("3) Ver puertas y ventanas del playroom");
                            WriteLine("4) Ver puertas y ventanas del living");
                            WriteLine("5) Ver porton del garage");
                            WriteLine("0) Para volver atras");
                            opcion2 = int.Parse(ReadLine());
                            switch(opcion2)
                            {
                                case 1:
                                WriteLine("Puertas: ");
                                cocina.Mostrar();
                                WriteLine("Ventanas: ");
                                cocina.MostrarV();
                                break;
                                case 2:
                                WriteLine("Elegi el cuarto: ");
                                    do
                                    {
                                        WriteLine("1) Para el cuarto 1");
                                        WriteLine("2) Para el cuarto 2");
                                        WriteLine("3) Para el cuarto 3");
                                        WriteLine("4) Para el cuarto 4");
                                        WriteLine("0) Para volver");
                                        opcion3 = int.Parse(ReadLine());
                                        switch(opcion3)
                                        {
                                            case 1:
                                            WriteLine("Puerta: ");
                                            cuarto.Mostrar();
                                            WriteLine("Ventanas: ");
                                            cuarto.MostrarV();
                                            break;
                                            case 2:
                                            WriteLine("Puerta: ");
                                            cuarto1.Mostrar();
                                            WriteLine("Ventanas: ");
                                            cuarto1.MostrarV();
                                            break;
                                            case 3:
                                            WriteLine("Puerta: ");
                                            cuarto2.Mostrar();
                                            WriteLine("Ventanas: ");
                                            cuarto2.MostrarV();
                                            break;
                                            case 4:
                                            WriteLine("Puerta: ");
                                            cuarto3.Mostrar();
                                            WriteLine("Ventanas: ");
                                            cuarto3.MostrarV();
                                            break;
                                        }
                                    }while(opcion3 != 0);
                                break;
                                case 3:
                                WriteLine("Puertas: ");
                                playroom.Mostrar();
                                WriteLine("Ventanas: ");
                                playroom.MostrarV();
                                break;
                                case 4:
                                WriteLine("Pueras: ");
                                living.Mostrar();
                                WriteLine("Ventanas: ");
                                living.MostrarV();
                                break;
                                case 5:
                                WriteLine("Elegi el garage: ");
                                    do
                                    {
                                        WriteLine("1) Para ver el garage 1");
                                        WriteLine("2) Para ver el garage 2");
                                        WriteLine("0) para volver");
                                        opcion4 = int.Parse(ReadLine());
                                        switch(opcion4)
                                        {
                                            case 1:
                                            
                                            WriteLine("Garage: ");
                                            garage.Mostrar();
                                            break;
                                            case 2:
                                            
                                            WriteLine("Garage: ");
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
                            
                            WriteLine("-------OPCIONES-------");
                            WriteLine("1) Cuartos");
                            WriteLine("2) Cocina");
                            WriteLine("3) Living");
                            WriteLine("4) Playroom");
                            WriteLine("5) Garage");
                            WriteLine("6) Sensores");
                            WriteLine("0) Para volver atras");
                            opcion5 = int.Parse(ReadLine());
                                switch(opcion5)
                                {
                                    case 1:
                                        do
                                        {
                                            WriteLine("-------Cuartos-------");
                                            WriteLine("1) 1er cuarto");
                                            WriteLine("2) 2do cuarto");
                                            WriteLine("3) 3er cuarto");
                                            WriteLine("4) 4to cuarto");
                                            WriteLine("0) Para volver");
                                            opcion6 = int.Parse(ReadLine());
                                            switch(opcion6)
                                            {
                                                case 1:
                                                    do
                                                    {
                                                        WriteLine("Cuarto 1: ");
                                                        WriteLine("1) Para abrir");
                                                        WriteLine("2) Para cerrar");
                                                        WriteLine("3) Para bloquear");
                                                        WriteLine("4) Para desbloquear");
                                                        WriteLine("0) Para volver atras");
                                                        opcion7 = int.Parse(ReadLine());
                                                        switch(opcion7)
                                                        {
                                                            case 1:
                                                            
                                                            WriteLine("Abriste la puerta");
                                                            cuarto.Abrir(0);
                                                            break;
                                                            case 2:
                                                            
                                                            WriteLine("Cerraste la puerta");
                                                            cuarto.Cerrar(0);
                                                            break;
                                                            case 3:
                                                            
                                                            WriteLine("Bloqueaste la puerta");
                                                            cuarto.bloquear(0);
                                                            break;
                                                            case 4:
                                                            
                                                            WriteLine("Desbloqueaste la puera");
                                                            cuarto.desbloquear(0);
                                                            break;
                                                        }
                                                    }while(opcion7 != 0);
                                                break;
                                                case 2:
                                                    do
                                                    {
                                                        WriteLine("Cuarto 2: ");
                                                        WriteLine("1) Para abrir");
                                                        WriteLine("2) Para cerrar");
                                                        WriteLine("3) Para bloquear");
                                                        WriteLine("4) Para desbloquear");
                                                        WriteLine("0) Para volver atras");
                                                        opcion7 = int.Parse(ReadLine());
                                                        switch(opcion7)
                                                        {
                                                            case 1:
                                                            
                                                            WriteLine("Abriste la puerta");
                                                            cuarto1.Abrir(0);
                                                            break;
                                                            case 2:
                                                            
                                                            WriteLine("Cerraste la puerta");
                                                            cuarto1.Cerrar(0);
                                                            break;
                                                            case 3:
                                                            
                                                            WriteLine("Bloqueaste la puerta");
                                                            cuarto1.bloquear(0);
                                                            break;
                                                            case 4:
                                                            
                                                            WriteLine("Desbloqueaste la puera");
                                                            cuarto1.desbloquear(0);
                                                            break;
                                                        }
                                                    }while(opcion7 != 0);
                                                break;
                                                case 3:
                                                    do
                                                    {
                                                        WriteLine("Cuarto 3: ");
                                                        WriteLine("1) Para abrir");
                                                        WriteLine("2) Para cerrar");
                                                        WriteLine("3) Para bloquear");
                                                        WriteLine("4) Para desbloquear");
                                                        WriteLine("0) Para volver atras");
                                                        opcion7 = int.Parse(ReadLine());
                                                        switch(opcion7)
                                                        {
                                                            case 1:
                                                            
                                                            WriteLine("Abriste la puerta");
                                                            cuarto2.Abrir(0);
                                                            break;
                                                            case 2:
                                                            
                                                            WriteLine("Cerraste la puerta");
                                                            cuarto2.Cerrar(0);
                                                            break;
                                                            case 3:
                                                            
                                                            WriteLine("Bloqueaste la puerta");
                                                            cuarto2.bloquear(0);
                                                            break;
                                                            case 4:
                                                            
                                                            WriteLine("Desbloqueaste la puera");
                                                            cuarto2.desbloquear(0);
                                                            break;
                                                        }
                                                    }while(opcion7 != 0);
                                                break;
                                                case 4:
                                                    do
                                                    {
                                                        WriteLine("Cuarto 4: ");
                                                        WriteLine("1) Para abrir");
                                                        WriteLine("2) Para cerrar");
                                                        WriteLine("3) Para bloquear");
                                                        WriteLine("4) Para desbloquear");
                                                        WriteLine("0) Para volver atras");
                                                        opcion7 = int.Parse(ReadLine());
                                                        switch(opcion7)
                                                        {
                                                            case 1:
                                                            
                                                            WriteLine("Abriste la puerta");
                                                            cuarto3.Abrir(0);
                                                            break;
                                                            case 2:
                                                            
                                                            WriteLine("Cerraste la puerta");
                                                            cuarto3.Cerrar(0);
                                                            break;
                                                            case 3:
                                                            
                                                            WriteLine("Bloqueaste la puerta");
                                                            cuarto3.bloquear(0);
                                                            break;
                                                            case 4:
                                                            
                                                            WriteLine("Desbloqueaste la puera");
                                                            cuarto3.desbloquear(0);
                                                            break;
                                                        }
                                                    }while(opcion7 != 0);
                                                break;
                                            }
                                        }while(opcion6!=0);
                                    break;
                                    case 2:
                                        WriteLine("-------Cocina-------");
                                        WriteLine("1) Para abrir");
                                        WriteLine("2) Para cerrar");
                                        WriteLine("3) Para bloquear");
                                        WriteLine("4) Para desbloquear");
                                        WriteLine("0) Para volver atras");
                                        opcion8 = int.Parse(ReadLine());
                                        switch(opcion8)
                                        {
                                            case 1:
                                            WriteLine("------Puertas------");
                                            WriteLine("Que puerta queres abir?: ");
                                            WriteLine("Hay 5 puertas elegi una opcion del 0-4");
                                            WriteLine("0) Para la primer puerta ");
                                            WriteLine("1) Para la segunda puerta");
                                            WriteLine("2) Para la tercer puerta");
                                            WriteLine("3) Para la cuarta puerta");
                                            WriteLine("4) Para la quinta puerta");
                                            cocina.Abrir(int.Parse(ReadLine()));
                                            break;
                                            case 2:
                                            WriteLine("------Puertas------");
                                            WriteLine("Que puerta queres cerrar?: ");
                                            WriteLine("Hay 5 puertas elegi una opcion del 0-4");
                                            WriteLine("0) Para la primer puerta ");
                                            WriteLine("1) Para la segunda puerta");
                                            WriteLine("2) Para la tercer puerta");
                                            WriteLine("3) Para la cuarta puerta");
                                            WriteLine("4) Para la quinta puerta");
                                            cocina.Cerrar(int.Parse(ReadLine()));
                                            WriteLine("Cerraste la puerta");
                                            break;
                                            case 3:
                                            WriteLine("------Puertas------");
                                            WriteLine("Que puerta queres cerrar?: ");
                                            WriteLine("Hay 5 puertas elegi una opcion del 0-4");
                                            WriteLine("0) Para la primer puerta ");
                                            WriteLine("1) Para la segunda puerta");
                                            WriteLine("2) Para la tercer puerta");
                                            WriteLine("3) Para la cuarta puerta");
                                            WriteLine("4) Para la quinta puerta");
                                            cocina.Cerrar(int.Parse(ReadLine()));
                                            WriteLine("Bloqueaste la puerta");
                                            break;
                                            case 4:
                                            WriteLine("------Puertas------");
                                            WriteLine("Que puerta queres cerrar?: ");
                                            WriteLine("Hay 5 puertas elegi una opcion del 0-4");
                                            WriteLine("0) Para la primer puerta ");
                                            WriteLine("1) Para la segunda puerta");
                                            WriteLine("2) Para la tercer puerta");
                                            WriteLine("3) Para la cuarta puerta");
                                            WriteLine("4) Para la quinta puerta");
                                            cocina.Cerrar(int.Parse(ReadLine()));
                                            WriteLine("Desbloqueaste la puerta");
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
