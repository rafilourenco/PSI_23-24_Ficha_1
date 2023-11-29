using System;


namespace BolasColoridas
{
    class Cor
    {
        //Estado representado pelos valores red, green, blue, alpha
        private int red;
        private int green;
        private int blue;
        private int alpha;

        //Estado cinzento
        private int cinzento;

        //Construtor que aceita todos os parâmetros necessários para inicializar o estado de uma cor
        public Cor(int red, int green, int blue, int alpha){
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        //Construtor que aceita red, green, blue, e coloca alpha a 255
        public Cor(int red, int green, int blue){
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
        }

        //Métodos getter e setter para os componentes red, green, blue e alpha
        public int GetRed(){
            return red;
        }
        public void SetRed(int setcorred){
            red = setcorred;
        }

        public int GetGreen(){
            return green;
        }
        public void SetGreen(int setcorgreen){
            green = setcorgreen;
        }

        public int GetBlue(){
            return blue;
        }
        public void SetBlue(int setcorblue){
            blue = setcorblue;
        }

        public int GetAlpha(){
            return alpha;
        }
        public void SetAlpha(int setcoralpha){
            alpha = setcoralpha;
        }

        //Método getter para obter o grau de cinzento da cor, igual à média dos valores red, green e blue
        public int GetCinzento(){
            cinzento = (red + green + blue) / 3;
            return cinzento;
        }



    }



}