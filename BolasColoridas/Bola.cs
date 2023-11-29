using System;

namespace BolasColoridas
{
    class Bola
    {   
        //Estado representado pelos valores de cor, raio e o nº de vezes que a bola foi atirada
        private Cor cor;
        private double raio;
        private int nr;

        //Construtores apropriados
        public Bola(Cor cor, double raio){
            this.cor = cor;
            this.raio = raio;
            nr = 0;
        }
        //Método Pop() que fura a bola (coloca o seu raio a zero)
        public void Pop(){
            raio = 0;
        }
        //Método Atirar() que incrementa o nº de vezes que a bola foi atirada (apenas se a bola não estiver furada)
        public void Atirar(){
            if(raio > 0){
                nr++;
            }
        }


        //Métodos Getter
        public Cor GetCor(){
            return cor;
        }

        public double GetRaio(){
            return raio;
        }
        //Método que retorna o nº de vezes que a bola foi atirada
        public int Vezes(){
            return nr;
        }


    }

}