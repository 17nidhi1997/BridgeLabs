using System;

namespace Functiona
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    Replace aclass = new Replace();
                    aclass.replace();
                    break;

                case 2:
                    coinToss bclass = new coinToss();
                    bclass.coins();
                    break;
                case 3:
                    leapYear cclass = new leapYear();
                    cclass.leap();
                    break;
                case 4:
                    powerTwo dclass = new powerTwo();
                    dclass.power();
                    break;
                case 5:
                    factor eclass = new factor();
                    eclass.primes();
                    break;
                case 6:
                    Harmonic fclass = new Harmonic();
                    fclass.harnum();
                    break;
                case 7:
                    Distance gclass = new Distance();
                    gclass.dist();
                    break;
                case 8:
                    windchill hclass = new windchill();
                    hclass.wind();
                    break;
                case 9:
                    quadricEquation iclass = new quadricEquation();
                    iclass.equation();
                    break;
                case 10:
                     sumOfThree jclass = new sumOfThree();
                     jclass.integer();
                    break;
                case 11:
                    Gambler kclass = new Gambler();
                    kclass.Game();
                    break;
                case 12:
                    swatch lclass = new swatch();
                    lclass.watch();
                    break;
                case 13:
                    coupon mclass = new coupon();
                    mclass.number();
                    break;
                case 14:
                    TwoDArray nclass = new TwoDArray();
                    nclass.array2D();
                    break;
                case 15:
                    TIC_TAC_TOE  oclass = new  TIC_TAC_TOE();
                    oclass.tok();
                    break;
                  
            }
        }
    }
}
