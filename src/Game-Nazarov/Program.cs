using System;

class Program
{
    static void Main()
    {
        string playerName;
        bool hasKey = false, hasLockpick = false;
        bool artifact1Found = false, artifact2Found = false, artifact3Found = false;

        
        Console.WriteLine("Вы просыпаетесь в комнате. Как вас зовут?");
        playerName = Console.ReadLine();

        while (true)
        {
           //осмотр комнаты?
            Console.WriteLine($"\n{playerName}, что вы хотите сделать?");
            Console.WriteLine("1. Открыть дверь");
            Console.WriteLine("2. Заглянуть под кровать");
            Console.WriteLine("3. Открыть ящик в углу комнаты");
            Console.WriteLine("4. Открыть вентиляцию");
            Console.WriteLine("5. Взглянуть на тумбочку");
            Console.WriteLine("6. Взглянуть на статую рядом с дверью");
            Console.WriteLine("Введите номер действия:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    if (hasLockpick)
                    {
                        Console.WriteLine($"{playerName}, вы успешно сбежали!");
                        return; //завершение игры
                    }
                    else
                    {
                        Console.WriteLine("Дверь закрыта. Вам, судя по всему, нужна отмычка.");
                    }
                    break;

                case "2":
                    if (!artifact1Found) //предмет под кроватью
                    {
                        artifact1Found = true;
                        Console.WriteLine($"{playerName}, вы нашли пыльный таинственный предмет под кроватью.");
                    }
                    else
                    {
                        Console.WriteLine($"{playerName}, под кроватью пусто..");
                    }
                    break;

                case "3":
                    if (hasKey) //ящик
                    {
                        hasLockpick = true;
                        Console.WriteLine($"{playerName}, вы открыли ящик и нашли отмычку!");
                    }
                    else
                    {
                        Console.WriteLine("Ящик закрыт. Вы видете замок и понимаете, что вам нужен ключ. Может быть, у статуии есть что-то для вас?");
                    }
                    break;

                case "4":
                    if (!artifact2Found)
                    {
                        for (int i = 0; i < 3; i++) //вентиляция
                        {
                            Console.WriteLine("Вы пытаетесь открыть вентиляцию...");
                        }
                        artifact2Found = true;
                        Console.WriteLine($"{playerName}, вы нашли непонтяный предмет в вентиляции. Может, его стоит преподнести к стутати вместе с другими предметами?");
                    }
                    else
                    {
                        Console.WriteLine($"{playerName}, в вентиляции остались только комки пыли.");
                    }
                    break;

                case "5":
                    if (!artifact3Found) //тумбочка
                    {
                        artifact3Found = true;
                        Console.WriteLine($"{playerName}, вы нашли невиданный предмет на тумбочке.");
                    }
                    else
                    {
                        Console.WriteLine($"{playerName}, на тумбочке больше ничего нет.");
                    }
                    break;

                case "6":
                    if (artifact1Found && artifact2Found && artifact3Found) //статуя
                    {
                        hasKey = true;
                        Console.WriteLine($"{playerName}, вы активировали статую и получили ключ. Может быть от ящика, а может нет.");
                    }
                    else
                    {
                        Console.WriteLine("Статуя не реагирует. Возмонжо, ей нужно 3 предмета, которые разбросанны по комнате?");
                    }
                    break;

                default:
                    Console.WriteLine("Так не получится.."); //ошибка ввода.
                    break;
            }
        }
    }
}


