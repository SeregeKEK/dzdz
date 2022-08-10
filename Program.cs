void zadacha1(){  
    // Пользователь вводит с клавиатуры M чисел. 
    // Посчитайте, сколько чисел больше 0 ввёл пользователь.
    Console.Write("Введите кол-во чисел: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int res = 0;
    for(int i = 1; i <= size; i++){
        Console.Write("Введите " + i +"-е " + "число: ");
        int count = Convert.ToInt32(Console.ReadLine());
        if(count > 0){
            res++;
        }
    }
    Console.Write($"{res} - кол-во чисел больше 0");
}

void zadacha2(){
    // Напишите программу, которая найдёт точку пересечения двух прямых, 
    // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
    // значения b1, k1, b2 и k2 задаются пользователем.
    Console.Write("Введите число b1: ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число b2: ");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число k1: ");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число k2: ");
    int k2 = Convert.ToInt32(Console.ReadLine());
    if(k1 == k2){
        Console.WriteLine("Введены неверные значения");
        Console.Write("Введите число k1: ");
        k1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число k2: ");
        k2 = Convert.ToInt32(Console.ReadLine());
    }

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"X {Math.Round(x, 2)};  Y {Math.Round(y, 2)}");
}   

// zadacha1();
zadacha2();