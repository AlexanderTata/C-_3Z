//Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру
Console.WriteLine("Чтобы отобразить день недели, напишите n-дня недели от 1-7");
int number = Convert.ToInt32(Console.ReadLine()); 
 // Первое решение. Сравнение проводится в фигурных скобках "()"
//if (number == 1)
    //{ 
    //Console.WriteLine("Monday");
    //}
//if (number == 2)
    //{ 
    //Console.WriteLine("Tuesday"); 
    //}
//if (number == 3) 
    //{ 
    //Console.WriteLine("Wednesday"); 
    //}
//if (number == 4) 
    //{ 
    //Console.WriteLine("Sateday"); 
    //}
//if (number == 5) 
    //{ 
    //Console.WriteLine("Friday"); 
    //}
//if (number == 6) 
    //{ 
    //Console.WriteLine("Saturday"); 
    //}
//if (number == 7) 
    //{ 
    //Console.WriteLine("Sunday"); 
    //}
// Второе решение более лаконичное (Так как после if одно действие скобки не требуются. В данном решение по условиям программы при выборе number == 1, number присваивается число 1, что не човсем корректно соостветсвенно более правильно будет указать следующем образом см. Решение №3)
//if (number == 1) Console.WriteLine("Monday");
//if (number == 2) Console.WriteLine("Tuesday"); 
//if (number == 3) Console.WriteLine("Wednesday"); 
//if (number == 4) Console.WriteLine("Sateday"); 
//if (number == 5) Console.WriteLine("Friday"); 
//if (number == 6) Console.WriteLine("Saturday"); 
//if (number == 7) Console.WriteLine("Sunday"); 
// Третье решение более лаконичное (в данном решение мы добавляем условие else и ставится оно после первого значения, а именно после сравнения с 1)
if (number == 1) Console.WriteLine("Monday");
else if (number == 2) Console.WriteLine("Tuesday"); 
else if (number == 3) Console.WriteLine("Wednesday"); 
else if (number == 4) Console.WriteLine("Sateday"); 
else if (number == 5) Console.WriteLine("Friday"); 
else if (number == 6) Console.WriteLine("Saturday"); 
else if (number == 7) Console.WriteLine("Sunday"); 
else Console.WriteLine ("Error, incorrect value");