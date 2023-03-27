// See https://aka.ms/new-console-template for more information
using basiclianxi;
using System;
namespace basiclianxi {
    class Box {
        public int length;
        public int breadth;
        public int heigth;


    }
    class Boxtester {
        static void Main(string[] args) {
            Box B1 = new Box();
            Box B2 = new Box();

            B1.breadth = 10;
            B1.length = 11;
            B1.heigth = 20;

            B2.breadth = 10;
            B2.heigth = 20;
            B2.length = 30;

            int volume = B1.breadth * B1.length * B1.heigth;
            Console.WriteLine(volume);

            int volume2 = B2.breadth * B2.length * B2.heigth;
            Console.WriteLine(volume2);

        }
    }

}


//Boxtester()