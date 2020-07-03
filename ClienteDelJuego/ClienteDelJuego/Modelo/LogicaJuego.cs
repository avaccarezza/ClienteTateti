using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteDelJuego.Modelo
{
   public class LogicaJuego
    {

        public int[] tablero = new int[9];
        static bool player = true;
       
        public LogicaJuego() { 

        }
   
        
        public void tableroDefault()
        {
            for(int i = 0;i <= 8; i++)
            {
                tablero[i] = 0 ;
                Console.WriteLine(" " + tablero[i]);
                
            }
        }
       /* public void tableroDefault()
        {
            for (int f=0;f < 3;f++)
            {
                for( int c=0; c < 3; c++)
                {
                    tablero[f,c] = '-';
                    Console.Write(" "+tablero[f,c]);
                }
                    Console.WriteLine("");
            }
        }*/


        public void terminaPartida()
        {

        }
        public String ponerFicha()
        {
            
            if (player)
            {
                player = false;
                return "X";
            }
            else
            {
               // tablero[i] = 'O';
                player = true;
                return "O";
            }
            

        }
    }
}
