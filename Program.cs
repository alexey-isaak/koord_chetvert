using System;
 
namespace koord_chetvert
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер координатной четверти (от 1 до 4): ");
            int nomer = int.Parse(Console.ReadLine());

            switch ( nomer ) {
        
        case 1 :
            Console.WriteLine( "Диапазон координат оси X: (0, +Ꚙ" );
            Console.WriteLine( "Диапазон координат оси Y: (0, +Ꚙ" );
            break;
        case 2 :
            Console.WriteLine( "Диапазон координат оси X: (-Ꚙ, 0)" );
            Console.WriteLine( "Диапазон координат оси Y: (0, +Ꚙ)" );
            break;
        case 3 :
            Console.WriteLine( "Диапазон координат оси X: (-Ꚙ, 0)" );
            Console.WriteLine( "Диапазон координат оси Y: (-Ꚙ, 0)" );
            break;
        case 4 :
            Console.WriteLine( "Диапазон координат оси X: (0, +Ꚙ)" );
            Console.WriteLine( "Диапазон координат оси Y: (-Ꚙ, 0)" );
            break;
        default :
            Console.WriteLine( "Неожиданный номер" );
            break;
            }
        }
    }
}
