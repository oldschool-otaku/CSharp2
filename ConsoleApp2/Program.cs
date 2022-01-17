using System;

namespace ConsoleApp2
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какое задание вы изволите проверить");
            
            int choise = Convert.ToInt32(Console.ReadLine());
            
            switch(choise)
            {
                case 1:
                    int dub = Convert.ToInt32(Console.ReadLine());

                    // Ежели число номеръ Одинъ имеет значение цифре пять ежели числу десять то выводитъ строку ниже
                    Console.WriteLine(dub is 10 or 5 ? "Число либо равно 5, либо равно 10" 
                        : "Неизвестное число");

                    break;

                
                case 2:
                    // TODO: ежик смешнявкин
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    // Ежели число номеръ Одинъ является большимъ чемъ число номеръ Два то выводитъ результатъ
                    if (num1 > num2)
                    {
                        Console.WriteLine("Число {0} больше числа {1}", num1, num2);
                    }
            
                    // Ежели число номеръ Два является большимъ чемъ число номеръ Одинъ то выводитъ результатъ
                    if (num1 < num2)
                    {
                        Console.WriteLine("Число {0} больше числа {1}", num2, num1);
                    }
            
                    // Ежели число номеръ Одинъ является темъ же числом номеръ Два то выводитъ результатъ
                    if (num1 == num2)
                    {
                        Console.WriteLine("Число {0} равно числу {1}", num1, num2);
                    }

                    break;
                
                
                case 3:
                    // TODO: ежик смешнявкин2
                    int num = Convert.ToInt32(Console.ReadLine());

                    // Ежели число номеръ Одинъ имеет значение цифре пять ежели числу десять то выводитъ строку ниже
                    Console.WriteLine(num is 10 or 5 ? "Число либо равно 5, либо равно 10" 
                        : "Неизвестное число");

                    break;
                
                
                case 4:
                    // переменная егоръ принимаетъ число
                    double egor = Convert.ToDouble(Console.ReadLine());
            
                    // продвинутый ифъ
                    switch (egor)
                    {
                        // ежели вкладъ меньше чем сто русскихъ рублей то тогда выводитъ Пять процентовъ
                        case <= 100:
                            Console.WriteLine("5%");
                            Console.WriteLine(egor + (egor / 100 * 5));
                            break;
                
                        // ежели вкладъ больше чем сто русскихъ рублей но меньше двуста русскихъ рублей
                        // то тогда выводитъ Пять процентовъ
                        case < 200 and > 100:
                            Console.WriteLine("7%");
                            Console.WriteLine(egor + (egor / 100 * 7));
                            break;
                
                        //иначе в любомъ другомъ случае
                        default:
                            Console.WriteLine("10%");
                            Console.WriteLine(egor + (egor / 10));
                            break;
                    }

                    break;
                
                
                case 5:
                    // переменная егоръ принимаетъ число
                    double egor2 = Convert.ToDouble(Console.ReadLine());
            
                    // продвинутый ифъ
                    switch (egor2)
                    {
                        // ежели вкладъ меньше чем сто русскихъ рублей то тогда выводитъ Пять процентовъ
                        case <= 100:
                            Console.WriteLine("5% + 15p");
                            Console.WriteLine(egor2 + (egor2 / 100 * 5) + 15);
                            break;
                
                        // ежели вкладъ больше чем сто русскихъ рублей но меньше двуста русскихъ рублей
                        // то тогда выводитъ Пять процентовъ
                        case < 200 and > 100:
                            Console.WriteLine("7%");
                            Console.WriteLine(egor2 + (egor2 / 100 * 7) + 15);
                            break;
                
                        //иначе в любомъ другомъ случае
                        default:
                            Console.WriteLine("10%");
                            Console.WriteLine(egor2 + (egor2 / 10) + 15);
                            break;
                    }
                    
                    break;
                
                case 6:
                    Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
                    
                    int sign = Convert.ToInt32(Console.ReadLine());


                    switch (sign)
                    {
                        case 1:
                            Console.WriteLine("Сложение");
                            break;
                        
                        case 2:
                            Console.WriteLine("Вычитание");
                            break;
                        
                        case 3: 
                            Console.WriteLine("Умножение");
                            break;
                        
                        default:
                            Console.WriteLine("Не знаю такого");
                            break;
                    }
                    
                    break;
                
                case 7:
                    Console.WriteLine("Введите два числа и номер операции: 1.Сложение 2.Вычитание 3.Умножение");
                    
                    int first = Convert.ToInt32(Console.ReadLine());
                    int second = Convert.ToInt32(Console.ReadLine());
                    int sigm = Convert.ToInt32(Console.ReadLine());
                

                    switch (sigm)
                    {
                        case 1:
                            Console.WriteLine("Сложение");
                            Console.WriteLine(first + second);
                            break;
                        
                        case 2:
                            Console.WriteLine("Вычитание");
                            Console.WriteLine(first - second);
                            break;
                        
                        case 3: 
                            Console.WriteLine("Умножение");
                            Console.WriteLine(first * second);
                            break;
                        
                        default:
                            Console.WriteLine("Не знаю такого");
                            break;
                    }

                    break;
            }
        }
    }
}
