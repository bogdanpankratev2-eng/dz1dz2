//// 1 ДЗ \\\\\\\\

//Выводим название блюда

Console.WriteLine("Рецепт: Бургер с плавленным сыром!");

// Выводим заголовок и список ингредиентов
Console.WriteLine("\nИнгредиенты:");
Console.WriteLine("- Булочка — 2 ломтика");
Console.WriteLine("- Сыр — 3 ломтика");
Console.WriteLine("- Горячая котлетка");

// Выводим заголовок и шаги приготовления
Console.WriteLine("\nПриготовление:");
Console.WriteLine("1. Намажьте сливочное масло на один ломтик булочки.");
Console.WriteLine("2. Положите ломтики сыра на булочку с мясом.");
Console.WriteLine("3. Накройте вторым ломтиком булочки.");
Console.WriteLine("4. При желании слегка поджарьте бургер на масленной сковородке.");

////////////     2 ДЗ    \\\\\\\\\\\\\\\\\

/// заголовок \\\\

{
    Console.WriteLine("-- Калькулятор Индекса Массы Тела (ИМТ)--");

    /// запросы\\\

    Console.WriteLine("Введите ваш вес в килограммах : ");
    double ves = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите ваш рост в метрах  (например, 1.75) : ");
    double rost = double.Parse(Console.ReadLine());

    double IMT = ves / (rost * rost);

    Console.WriteLine($"\n- Ваш результат -\nПри весе{ves} кг и росте {rost} м, ваш ИМТ состовляет : {IMT}");

