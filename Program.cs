// Программа принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
/*

void Pal(){
    Console.WriteLine("Введите пятизначное число ");        
    int num = Convert.ToInt32(Console.ReadLine());    
    int dec1 = num / 10000;                             
    int dec2 = (num / 1000) % 10 ;
    int dec4 = (num % 100) / 10;
    int dec5 = num % 10;
    if (dec1 == dec5 && dec2 == dec4){
        Console.WriteLine("Палиндром ");
    }
    else{
        Console.WriteLine("Не палиндром");
    }
}
    Pal();

*/





//Программа принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
/*

double Func(double x1, double y1, double z1, double x2, double y2, double z2){

 double way = 0;
 way = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
 Console.WriteLine("Расстояние в 3D:   "  + way);
 return way;
 }     

 Console.Write("Ввод координат x1: ");
 double x1 = Convert.ToDouble(Console.ReadLine());

 Console.Write("Ввод координат y1: ");
 double y1 = Convert.ToDouble(Console.ReadLine());

 Console.Write("Ввод координат z1: ");
 double z1 = Convert.ToDouble(Console.ReadLine());

 Console.Write("Ввод координат x2: ");
 double x2 = Convert.ToDouble(Console.ReadLine());

 Console.Write("Ввод координат y2: ");
 double y2 = Convert.ToDouble(Console.ReadLine());

 Console.Write("Ввод координат z2: ");
 double z2 = Convert.ToDouble(Console.ReadLine());


 Func(x1, y1, z1, x2, y2, z2);

*/


/*
////Программа принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.


void Cube(int n){
    
    int side = 1;
    while(side <= n){
    Console.Write(side * side * side + " ");
    side++;
     }
    }
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Cube(num);


    */
