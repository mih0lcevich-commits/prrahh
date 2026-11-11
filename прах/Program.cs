using System;

namespace CyberpunkRpg
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MaxBioShield = 100;         
            const int SecurityDroneDamage = 25;   

            string netrunnerAlias = "Ghost_Prakh"; 
            int currentShield = MaxBioShield;     
            int netbax = 250;                     

            Console.WriteLine("##################################################");
            Console.WriteLine("       ОБХОД СИСТЕМЫ // КИБЕР-ДЕКА АКТИВИРОВАНА   ");
            Console.WriteLine("##################################################");
            Console.WriteLine($" [Юзер: {netrunnerAlias}] | [Щит: {currentShield}/{MaxBioShield} HP] | [Баланс: {netbax} баксиков]");
            Console.WriteLine("##################################################");
            Console.WriteLine("Взлом терминала Арасаки обнаружен!");
            Console.WriteLine("Из вентиляции вылетел Дрон-охотник.");
            Console.WriteLine("1 — Перегрузить процессор дрона вирусом (Атака)");
            Console.WriteLine("2 — Включить маскировку и разорвать связь (Побег)");
            Console.Write("\nВыберите протокол (введите цифру): ");

            string? playerInput = Console.ReadLine();
            int selectedProtocol;
            bool isProtocolValid = int.TryParse(playerInput, out selectedProtocol);

            Console.WriteLine("\n##################################################");

            if (isProtocolValid && selectedProtocol == 1)
            {
                currentShield = currentShield - SecurityDroneDamage;

                Console.WriteLine("Протокол 'Вирус' запущен! Дрон взорвался.");
                Console.WriteLine($"Но перед отключением он успел нанести вам {SecurityDroneDamage} урона.");
                Console.WriteLine($"Статус био-щита: {currentShield} HP");
            }
            else if (isProtocolValid && selectedProtocol == 2)
            {
                Console.WriteLine("Маскировка активна. Сессия успешно закрыта в даркнете.");
            }
            else
            {
                Console.WriteLine("Ошибка ввода! Система зависла из-за некорректной команды.");
                Console.WriteLine("Дрон воспользовался этим и ударил вас током на 10 HP.");
                
                currentShield = currentShield - 10;
                Console.WriteLine($"Статус био-щита: {currentShield} HP");
            }

            Console.WriteLine("##################################################");
            Console.WriteLine("Сессия завершена. Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
