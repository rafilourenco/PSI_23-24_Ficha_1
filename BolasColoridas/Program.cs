using System;

namespace BolasColoridas
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Criar instancias de cor
            Cor cor01 = new Cor(255, 0, 0);
            Cor cor02 = new Cor(0, 255, 0);
            Cor cor03 = new Cor(0, 0, 255);
            Cor cor04 = new Cor(255, 255, 0);

            //Criar algumas bolas
            Bola bola01 = new Bola(cor01, 5);
            Bola bola02 = new Bola(cor02, 10);
            Bola bola03 = new Bola(cor03, 15);
            Bola bola04 = new Bola(cor04, 20);


            //Atirar as bolas várias vezes

            bola01.Atirar();
            bola01.Atirar();
            bola02.Atirar();
            bola02.Atirar();
            bola02.Atirar();
            bola02.Atirar();
            bola02.Atirar();
            bola03.Atirar();
            bola04.Atirar();
            bola04.Atirar();
            bola04.Atirar();
            bola04.Atirar();
            
            //Rebentar algumas das bolas

            bola01.Pop();
            bola03.Pop();

            //Imprimir no ecrã o estado de cada uma (incluindo cor)

            Console.WriteLine("Dados das bolas: \n");
            //Imprimir Bola 1
            Console.WriteLine("Bola 1:");
            Console.WriteLine($"Cor: {cor01.GetRed()}, {cor01.GetGreen()}, {cor01.GetBlue()}");
            Console.WriteLine($"Vezes atirada: {bola01.Vezes()}");
            if(bola01.GetRaio() == 0){
                Console.WriteLine("Foi arrebentada?Sim");
            }else{
                Console.WriteLine("Foi arrebentada?Não");
            }
            Console.WriteLine("\n");
            //Imprimir Bola 2
            Console.WriteLine("Bola 2:");
            Console.WriteLine($"Cor: {cor02.GetRed()}, {cor02.GetGreen()}, {cor02.GetBlue()}");
            Console.WriteLine($"Vezes atirada: {bola02.Vezes()}");
            if(bola02.GetRaio() == 0){
                Console.WriteLine("Foi arrebentada?Sim");
            }else{
                Console.WriteLine("Foi arrebentada?Não");
            }
            Console.WriteLine("\n");
            //Imprimir Bola 3
            Console.WriteLine("Bola 3:");
            Console.WriteLine($"Cor: {cor03.GetRed()}, {cor03.GetGreen()}, {cor03.GetBlue()}");
            Console.WriteLine($"Vezes atirada: {bola03.Vezes()}");
            if(bola03.GetRaio() == 0){
                Console.WriteLine("Foi arrebentada?Sim");
            }else{
                Console.WriteLine("Foi arrebentada?Não");
            }
            Console.WriteLine("\n");
            //Imprimir Bola 4
            Console.WriteLine("Bola 4:");
            Console.WriteLine($"Cor: {cor04.GetRed()}, {cor04.GetGreen()}, {cor04.GetBlue()}");
            Console.WriteLine($"Vezes atirada: {bola04.Vezes()}");
            if(bola04.GetRaio() == 0){
                Console.WriteLine("Foi arrebentada?Sim");
            }else{
                Console.WriteLine("Foi arrebentada?Não");
            }
            Console.WriteLine("\n");

            
        
        }


    }
}
