using System;

    class Boxeador
    {

        public string Nombre { get; set; }
        public int Peso { get; private set; }
        public int PotGolpes { get; set; }
        public int VelPiernas { get; set; }
        public string Pais { get; set; }

        public Boxeador()
        {
         Nombre ="";
         Pais = "";
         Peso=0;
         PotGolpes=0;
         VelPiernas=0;
        }
        public Boxeador(string nom, string pais, int peso, int potencia, int velocidad)
        {
            Nombre = nom;
            Peso = peso;
            PotGolpes = potencia;
            VelPiernas = velocidad;
            Pais = pais;
        }
        

        public double obtenerSkill()
        {
           double skill=0;
           int min = 1;
           int max = 10;
           
        Random azar = new Random();
        int num =azar.Next(min, max + 1);
        
        skill= (VelPiernas*0.6)+(PotGolpes*0.8)+num;


        return skill;
        }

        
        
    }
