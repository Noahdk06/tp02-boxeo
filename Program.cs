﻿
           
   

    
  
        Boxeador boxeador1= null;
        Boxeador boxeador2 =null;
            
           int opcion = menu();
            while (opcion != 4)
            {

                switch (opcion)
                {

                    case 1:
                           boxeador1 =  ingresarBoxeador();
                           
                        break;
                    case 2:
                          boxeador2 =  ingresarBoxeador();
                       
                        break;
                    case 3:
                       
                         if (boxeador1 !=null && boxeador2 != null)
                         {
                            pelea(boxeador1,boxeador2);
                         }
                          
                        break;
                    
                }







                opcion = menu();

            
            }















            Boxeador ingresarBoxeador()
            {   
                
                string nom;
            string pais;
             int peso; 
             int potencia;
              int velocidad;
             Console.WriteLine("Ingrese el nombre del boxeador");
             nom = Console.ReadLine();
             
             System.Console.WriteLine("ingrese la nacionalidad del boxeador");
             pais = Console.ReadLine();
             System.Console.WriteLine("ingrese el peso del boxeador");
             peso = int.Parse(Console.ReadLine());
             System.Console.WriteLine("ingrese la potencia del golpeo del boxeador");
             potencia = int.Parse(Console.ReadLine());
             System.Console.WriteLine("ingrese la velocidad de las piernas del boxeador");
             velocidad = int.Parse(Console.ReadLine());

             Boxeador unBoxeador = new Boxeador(nom, pais, peso, potencia, velocidad);
         
             return unBoxeador;

            }


         void pelea(Boxeador box1, Boxeador box2)
         {
           double skl1= box1.obtenerSkill();
           double skl2= box2.obtenerSkill();
            string mensaje="";
           
            Boxeador boxeadorGanador;
          System.Console.WriteLine("el boxeador1 tiene " + skl1 + " y se enfrentara al boxeador numero 2, que tiene " + skl2 );
           
           if (skl1>skl2)
           {
            boxeadorGanador=box1;
           }
           else
           {
            boxeadorGanador=box2;
           }
           if(skl1 -skl2 >= 30 || skl1 - skl2 >= -30)
           {
             mensaje=", se gano por ko";
           }
           if(skl1 - skl2 >= 10 && skl1 - skl2 < 30 || skl1 - skl2 >= -10 && skl1 - skl2 < -30){
            mensaje = "Por puntos en fallo unanime";
           }
           if(skl1 - skl2 <= 10  || skl1 - skl2 <= -10){
            mensaje = "Por puntos en fallo dividido";
           }
            Console.WriteLine("el ganador es  " + boxeadorGanador.Nombre + mensaje);
            
        
        
         }








        


            
                
               int menu()
               {
                int opElegida;
                Console.Clear();
                System.Console.WriteLine("///////////////////menu/////////////////////");
                System.Console.WriteLine("i-Cargar Datos Boxeador 1");
                System.Console.WriteLine("ii-Cargar Datos Boxeador 2");
                System.Console.WriteLine("iii-Pelear!");
                System.Console.WriteLine("iv-Salir");
                opElegida = int.Parse(System.Console.ReadLine());

                while (opElegida < 0 || opElegida > 4)
                {
                    System.Console.WriteLine("Opcion invalida, intente ingresar un numero entre 1 y 4");
                    opElegida = int.Parse(System.Console.ReadLine());
                }



                return opElegida;
               } 
                
            







    


