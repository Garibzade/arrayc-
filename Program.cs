//int number = 7481; 
//int compareNum = 0;
//int maxNumber = 0;
//while (number > 0)
//{
//    compareNum = number % 10;
//    if (compareNum > maxNumber)
//    {
//        maxNumber = compareNum;
//    }
//    number = number / 10;
//}
//Console.WriteLine(maxNumber);



//int num =64 ;
//while (num % 2 == 0)
//{
//    num /= 2;
//}
//if (num ==1)
//{
//    Console.WriteLine("2-nin quvvetidir");
//}
//else
//{
//    Console.WriteLine("2nin quvveti deyil");
//}






//int[] arr = { -5,2,3,4 };
//int minNum = arr[0];
//int maxNum = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < minNum)
//        minNum = arr[i];

//    if (arr[i] > maxNum)
//        maxNum = arr[i] ;

//}
//Console.WriteLine(maxNum+minNum);



//int[] arr = { 12, 15, 17, 19, 21 };
//int caunt = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 != 0 && arr[i] % 3 == 0)
//    {
//        caunt++;
//    }

//}
//Console.WriteLine(caunt);   



int[] arr = { 12, 25, 18, 32, 13, 64 };
int count=0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 3) {
        for (int j = 1; j < arr.Length; j++)
        {
            if (arr[i] % j == 0) { 
            count++;
                break;
            }
        }
        }
}
Console.WriteLine(count);

