int Max(int a1, int a2, int a3)
{
     int result = a1;
     if(a2 > result) result = a2;
     if(a3 > result) result = a3;
     return result;
}



int[] array = {1, 23, 3, 14, 5, 46, 72, 18, 9};

int max = Max(Max(array[0], array[1], array[2])
, Max(array[3], array[4], array[5]),
 Max(array[6], array[7], array[8]));

Console.Write (max);