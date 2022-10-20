// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число >");
string а = Console.ReadLine();
int n = Convert.ToInt32(а);

int izi = 2;

while(izi < n){
 if(izi < n)
 {
 Console.Write(izi + ",");
 
 izi = izi +2;
 }
}
Console.Write(n);