using System;

namespace ConsoleApp3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;

            int [] array = new int[0];
            
            Console.WriteLine(" добавить число, sum - сложить, exit - выход");

            while (isWorking)
            {               
                var userInput = Console.ReadLine();

                if (userInput == "exit")
                {
                    isWorking = false;
                    break;
                }
                else if (userInput == "sum")
                {
                    int sum = 0;

                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += array[i];
                    }

                    Console.WriteLine("Сумма всех чисел в массиве : " + sum);

                    break;
                }
                else
                {
                    int[] tempArray = new int[array.Length + 1];
                    int number = Convert.ToInt32(userInput);
                    

                    for (int i = 0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                    }
                    tempArray[tempArray.Length - 1] = number;
                    array = tempArray;

                    for(int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i]+ " ");                        
                    }                    
                }
            }                
        }
    }
}
