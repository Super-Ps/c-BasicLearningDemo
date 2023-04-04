// See https://aka.ms/new-console-template for more information
using basiclianxi;
using System;
namespace basiclianxi {


    struct TestStruct {
        public string title;
        public string author;
        public string subject;
        public int book_id;
    }



    class Box {
        public int length;
        public int breadth;
        public int heigth;
        public void Test() {
            int a = 10;
            int b = 0;
            TestStruct ts;

            try {
                if (a == 10) {
                    //var c = a / b;
                    ts.author = "jonnypeng";
                    Console.WriteLine(ts.author);
                    Console.WriteLine($"当前this:{this}");
                    Console.WriteLine(string.Format("{0}", ts.author));
                    //Console.WriteLine("this. is  ", a / b);
                }
            }
            catch (Exception e) {

                Console.WriteLine("报错了，提示是：",e.ToString());
                //Console.WriteLine("this. ", this);
                //throw;
            }
        }
    }

    class subBox : Box {

        public void geetAre() {
            int a = length * breadth * heigth;
            Console.WriteLine($"子类集成父类的属性{a}");  // 子类集成父类的属性，直接用
        }
    }
}
    class Boxtester {

        enum MyEnum {
            typeA, typeB, typeC, typeD,
        }

            
        static void Main(string[] args) {
            Box B1 = new Box();
            Box B2 = new Box();

            B1.breadth = 10;
            B1.length = 11;
            B1.heigth = 20;

            B2.breadth = 10;
            B2.heigth = 20;
            B2.length = 30;


            subBox sbox = new subBox();
            sbox.breadth = 122;
            sbox.length = 222;
            sbox.heigth = 444;
            sbox.geetAre(); 
            
            //int volume = b1.breadth * b1.length * b1.heigth;
            //console.writeline(volume);

            //int volume2 = b2.breadth * b2.length * b2.heigth;
            //console.writeline(volume2);
            B1.Test();
            Console.WriteLine($"ENUM:{MyEnum.typeA}");
            Console.ReadLine();
    }


}


//Boxtester()