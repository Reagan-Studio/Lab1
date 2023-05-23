

//------------------------------------------------------(инд1)----------------------------------------------------------------


////ЗАДАЧА НОМЕР 3

////метод для выявления есть ли в столбце ноль
//int Zero_Found(int[,] arr, int row_number, int work_column)
//{
//    int result = 0;
//    for (int i = 0; i < row_number; i++)
//    {
//        if (arr[i, work_column] == 0)
//        {
//            result++;
//        }
//    }
//    if (result == 0)
//    {
//        return 0;
//    }
//    else
//    {
//        return 1;
//    }
//}

////создание матрицы
//Console.WriteLine("Введите кол-во строк в матрице: ");
//int row = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите кол-во столбцов: ");
//int column = Convert.ToInt32(Console.ReadLine());
//int[,] matrix = new int[row, column];
//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < column; j++)
//    {
//        Console.WriteLine("Введите элемент матрицы: ");
//        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
//    }
//}

////количество столбцов, содержащих хотя бы один нулевой элемент
//int counter = 0;
//for (int i = 0; i < column; i++)
//{
//    counter += Zero_Found(matrix, row, i);
//}
//Console.WriteLine($"Kоличество столбцов, содержащих хотя бы один нулевой элемент = {counter}");

////строка, где самая длинная серия одинаковых элементов
//int max_i = -1;
//int max = 0;
//int same_counter = 0;
//bool signal = false;
//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < column - 1; j++)
//    {
//        if (matrix[i, j] == matrix[i, j + 1])
//        {
//            if (signal)
//            {
//                same_counter++;
//            }
//            else
//            {
//                signal = true;
//                same_counter++;
//            }
//            if (j == column - 2)
//            {
//                max = same_counter;
//                max_i = i;
//            }
//        }
//        else
//        {
//            if (signal)
//            {
//                if (same_counter > max)
//                {
//                    max = same_counter;
//                    max_i = i;
//                }
//            }
//            same_counter = 0;
//            signal = false;
//        }
//    }
//}
//if (max_i != -1)
//{
//    Console.WriteLine($"Номер строки, в которой находится самая длинная серия одинаковых элементов = {max_i + 1}");
//}
//else
//{
//    Console.WriteLine("В строках не было серий повторяющихся символов");
//}




////ЗАДАЧА НОМЕР 2

////метод для для ввода стороны и высоты
//void Data_read(out double side, out double height)
//{
//    Console.WriteLine("Введите сторону ромба: ");
//    side = Convert.ToDouble(Console.ReadLine());
//    Console.WriteLine("Введите высоту ромба: ");
//    height = Convert.ToDouble(Console.ReadLine());
//}

////метод для вычисления площади и периметра
//void S_P_Counter(double side, double height, out double S, out double P)
//{
//    S = side * height;
//    P = 4 * side;
//}

////ввод и считывание 3х ромбов в массивы
//int n = 3;
//double[,] rhomb_base = new double[2, n];
//for (int i = 0; i < n; i++)
//{
//    Data_read(out rhomb_base[0, i], out rhomb_base[1, i]);
//}
//double[,] rhomb_staff = new double[2, n];
//for (int i = 0; i < n; i++)
//{
//    S_P_Counter(rhomb_base[0, i], rhomb_base[1, i], out rhomb_staff[0, i], out rhomb_staff[1, i]);
//}

////сумма площадей < 10
//double result = 0;
//for (int i = 0; i < n; i++)
//{
//    if (rhomb_staff[0, i] < 10)
//    {
//        result += rhomb_staff[0, i];
//    }
//}
//Console.WriteLine($"Сумма площадей, котрые меньше 10 = {result}");

////наибольший периметр
//double max_P = rhomb_staff[1, 0];
//for (int i = 0; i < n; i++)
//{
//    if (max_P < rhomb_staff[1, i])
//    {
//        max_P = rhomb_staff[1, i];
//    }
//}
//Console.WriteLine($"Наибольший из периметров = {max_P}");

//Console.WriteLine($"Произведение площади и перимет-ра 2-го ромба = {rhomb_staff[0, 1] * rhomb_staff[1, 1]}");




////ЗАДАЧА НОМЕР 1

////метод вычисления кусочной функции по известному х

//double Function_Counnt(double x)
//{
//    if (x == -1 || x == (-2 - Math.Sqrt(6)) / 2 || x == (-2 + Math.Sqrt(6)) / 2)
//    {
//        return 0;
//    }
//    else if (x < -1)
//    {
//        return Math.Cos(x) * Math.Cos(x) * (x * x + 2);
//    }
//    else if (x > -1 & x < 3 * Math.PI)
//    {
//        return (x * x * x + 3) / (2 * x - (1 / (x + 2))) * (x / (1 + x));
//    }
//    else
//    {
//        return (68.0 / 9);
//    }
//}

////метод опредение принадлежности точки области по ее координатам
//int Area_Include(double x, double y)
//{
//    if (y >= 0 && y <= 6 && x >= -3 && x <= 0)
//    {
//        if (y <= 2 * x + 6)
//        {
//            return 1;
//        }
//        else { return 0; }
//    }
//    else if (y >= 0 && y <= 6 && x >= 0 && x <= 6)
//    {
//        if (x * x + y * y <= 36)
//        {
//            return 1;
//        }
//        else { return 0; }
//    }
//    else if (y <= 0 && y >= -6 && x <= 0 && x >= -3)
//    {
//        return 1;
//    }
//    else if (y <= 0 && y >= -6 && x >= 0 && x <= 6)
//    {
//        if (y >= x - 6)
//        {
//            return 1;
//        }
//        else { return 0; }
//    }
//    else { return 0; }
//}

////заполнение двумерного массива значениями х и у и вывод пар
//int n = 15;
//double[,] points = new double[2, n];
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine("Введите значение х:");
//    points[0, i] = Convert.ToInt32(Console.ReadLine());
//}
//for (int i = 0; i < n; i++)
//{
//    points[1, i] = Function_Counnt(points[0, i]);
//}
//Console.WriteLine("Пары значений:\n");
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine($"x={points[0, i]}\ty={points[1, i]}");
//}

////кол-во у лежащих в заданном диапазоне
//Console.WriteLine("Введите крайную левую границу функции: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите крайную правую границу функции: ");
//int b = Convert.ToInt32(Console.ReadLine());
//int counter1 = 0;
//for (int i = 0; i < n; i++)
//{
//    if (points[1, i] >= a & points[1, i] <= b)
//    {
//        counter1++;
//    }
//}
//Console.WriteLine($"{counter1} значений функции входят в диапазон");

////кол-во точек в заштрихованнрй области
//int counter2 = 0;
//for (int i = 0; i < n; i++)
//{
//    counter2 += Area_Include(points[0, i], points[1, i]);
//}
//Console.WriteLine($"{counter2} точек входит в заштрихованную область");




//------------------------------------------------------(лаба1)------------------------------------------------------------



////ЗАДАНИЕ НОМЕР 8

////сортировка выбором
//void Arr_Sort(ref int[] arr)
//{
//    for (int i = 0; i < arr.Length; i+=2)
//    {
//        int min_index = i;
//        for (int j = i; j < arr.Length; j+=2)
//        {
//            if (arr[j] < arr[min_index])
//            {
//                min_index = j;
//            }
//        }
//        int buffer = arr[min_index];
//        arr[min_index] = arr[i];
//        arr[i] = buffer;
//    }
//}

////создание массива и сортировка
//int[] arr = new int[70];
//Random rnd = new Random();
//for (int i = 0; i < 70; i++)
//{
//    arr[i] = rnd.Next(0, 100);
//}

//Arr_Sort(ref arr);

//Console.WriteLine("Отсортированный массив: ");
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write($"{arr[i]} ");
//}





////ЗАДАНИЕ НОМЕР 7

//Console.WriteLine("Введите кл-во элепентов в массиве");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[size];
//for (int i = 0; i < size; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("Введите число");
//int number = Convert.ToInt32(Console.ReadLine());

//int new_size = 0;
//for (int i = 0; i < size; i++)
//{
//    if (arr[i] == number)
//    {
//        new_size++;
//    }
//}

//int[] new_arr = new int[arr.Length - new_size];
//int j = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] != number)
//    {
//        new_arr[j] = arr[i];
//        j++;
//    }
//}

//Console.WriteLine("Hовый массив");
//for (int i = 0; i < size - new_size; i++)
//{
//    Console.WriteLine(new_arr[i]);
//}





////ЗАДАНИЕ НОМЕР 6

////высчитывать функцию
//double FunRes(double x)
//{
//    return Math.Log10(x*x-3*x+2);
//}

////работа
//double e = 0.001;
//Console.WriteLine("Введите левый край интервала: ");
//double a= Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите правый край интервала: ");
//double b= Convert.ToInt32(Console.ReadLine());
//double t=0;
//while (b - a >= e)
//{
//    t = (a + b) / 2;
//    if (FunRes(a) * FunRes(t) < 0)
//    {
//        b = t;
//    }
//    else
//    {
//        a = t;
//    }
//}
//Console.WriteLine($"Корень в заданном интервале = {(a+b)/2}");




////ЗАДАНИЕ НОМЕР 5
//Console.WriteLine("Введите целое число больше 2: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int a = 2;
//if (n >= 2)
//{
//    Console.Write("Простые числа: ");
//    while (a <= n)
//    {
//        Console.WriteLine(a);
//        a++;
//    }
//}
//else
//{
//    Console.WriteLine("Ошибка ввода!");
//}




////ЗАДАНИЕ НОМЕР 4

////метод вычисления кусочной функции по известному х
//double Function_Counnt(double x)
//{
//    if (x == 0)
//    {
//        return 0;
//    }
//    else if (x < -3)
//    {
//        return (1 + x * x) / (2 * x);
//    }
//    else if (x >= -3 & x < Math.PI / 4)
//    {
//        return (x * x - 3) * Math.Sin(x);
//    }
//    else
//    {
//        return (7.0 / 3);
//    }
//}

////метод опредение принадлежности точки области по ее координатам
//int Area_Include(double x, double y)
//{
//    if (y >= 0 && y <= 4 && x >= -4 && x <= 0)
//    {
//        if (x * x + y * y <= 16)
//        {
//            return 1;
//        }
//        else { return 0; }
//    }
//    else if (y >= 0 && y <= 4 && x >= 0 && x <= 2)
//    {
//        if (y <= -2 * x + 4)
//        {
//            return 1;
//        }
//        else { return 0; }
//    }
//    else if (y <= 0 && y >= -4 && x <= 0 && x >= -4)
//    {
//        if (y >= -1 * x - 4)
//        {
//            return 1;
//        }
//        else { return 0; }
//    }
//    else if (y <= 0 && y >= -4 && x >= 0 && x <= 2)
//    {
//        return 1;
//    }
//    else { return 0; }
//}

////метод для ввода массива вещественных чисел
//void Arr_Fill(ref int[] arr, int size)
//{
//    for (int i = 0; i < size; i++)
//    {
//        Console.WriteLine("Введите значениe:");
//        arr[i] = Convert.ToInt32(Console.ReadLine());
//    }
//}

////заполнение 2х одномерных массива значениями х и у и вывод пар
//Console.WriteLine("Введите кол-во элементов: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] points_x = new int[n];
//double[] points_y = new double[n];
//Arr_Fill(ref points_x, n);
//for (int i = 0; i < n; i++)
//{
//    points_y[i] = Function_Counnt(points_x[i]);
//}
//Console.WriteLine("Пары значений:\n");
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine($"x={points_x[i]}\ty={points_y[i]}");
//}

////кол-во точек в заштрихованнрй области
//int counter = 0;
//for (int i = 0; i < n; i++)
//{
//    counter += Area_Include(points_x[i], points_y[i]);
//}
//Console.WriteLine($"{counter} точек входит в заштрихованную область");




////ЗАДАНИЕ НОМЕР 3

//Console.WriteLine("Введите вашу дату рождения в формате дд.мм.гг: ");
//DateTime BthDate = Convert.ToDateTime(Console.ReadLine());
//DateTime NowDate = DateTime.Now;
//int age = 0;
//if (BthDate.Month > NowDate.Month)
//{
//    age = NowDate.Year - BthDate.Year - 1;
//}
//else if (BthDate.Month < NowDate.Month)
//{
//    age = NowDate.Year - BthDate.Year;
//}
//else if (BthDate.Month == NowDate.Month)
//{
//    if (BthDate.Day > NowDate.Day)
//    {
//        age = NowDate.Year - BthDate.Year - 1;
//    }
//    else if (BthDate.Day <= NowDate.Day)
//    {
//        age = NowDate.Year - BthDate.Year;
//    }
//}
//Console.Write($"\nВам {age} ");

//if (age >= 10 & age <= 19)
//{
//    Console.Write("лет");
//}
//else if (age % 10 == 2 | age % 10 == 3 | age % 10 == 4)
//{
//    Console.Write("годa");
//}
//else if (age % 10 == 0 | age % 10 == 5 | age % 10 == 6 | age % 10 == 7 | age % 10 == 8 | age % 10 == 9)
//{
//    Console.Write("лет");
//}
//else if (age % 10 == 1)
//{
//    Console.Write("год");
//}




////ЗАДАНИЕ НОМЕР 2

////метод ввода персонажа
//using System.Text.RegularExpressions;
//using System.Xml.Serialization;

//void PersIn(out string name, out double chark, out double shkal)
//{
//    Console.WriteLine("Введите имя персонажа: ");
//    name = Console.ReadLine();
//    Console.WriteLine("Введите кол-во выпитых чарок: ");
//    chark = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Введите кол-во выпитых шкаликов: ");
//    shkal = Convert.ToInt32(Console.ReadLine());
//}

////вычисление выпитого в литрах
//double ResDrink(double ch = 0, double sh = 0)
//{
//    const double Chark = 0.123;
//    const double Shark = 0.06;
//    return Chark * ch + Shark * sh;
//}

////проверка попадания в диапазон
//bool D_Test(double x)
//{
//    if (x >= 0.5 & x <= 1)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

////метод максимума трех
//double Max_in_three(double a, double b, double c)
//{
//    return Math.Max(a, Math.Max(b, c));
//}

//double helper;
//string name1;
//double x;
//PersIn(out name1, out x, out helper);
//string name2;
//double y;
//PersIn(out name2, out helper, out y);
//string name3;
//double z, w;
//PersIn(out name3, out z, out w);

//Console.WriteLine($"{name1} выпил в литрах: {ResDrink(x)} л");
//Console.WriteLine($"{name2} выпил в литрах: {ResDrink(0, z)} л");
//Console.WriteLine($"{name3} выпил в литрах: {ResDrink(z, w)} л");

//Console.WriteLine("Те, кто выпили более 0б5 л и менее 1л:");
//if (D_Test(ResDrink(x)))
//{
//    Console.WriteLine(name1);
//}
//if (D_Test(ResDrink(0, z)))
//{
//    Console.WriteLine(name2);
//}
//if (D_Test(ResDrink(z, w)))
//{
//    Console.WriteLine(name3);
//}

//Console.WriteLine($"Всего выпито {ResDrink(z, w) + ResDrink(0, z) + ResDrink(x)} л");

//Console.WriteLine($"Наибольший из выпитых объемов: {Max_in_three(ResDrink(x), ResDrink(0, z),ResDrink(z, w))}");




//ЗАДАНИЕ НОМЕР 1

//Console.WriteLine("Hello World!");
//Console.WriteLine("Введите ваше имя: ");
//string? name = Console.ReadLine();
//Console.WriteLine("Введите ваш возрвст: ");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Здравствуй, {name}! В следующем году тебе будет {age + 1}");