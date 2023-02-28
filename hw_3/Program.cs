// Задача №29: Напишите метод, котрый задает массив из N элементов и выводит их на экран

void PrintArray()
{
    Console.WriteLine("Введите количество элементов: "); 
    int N = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[N]; 
    int i;  	
   
    for(i = 0; i < N; i++)  
    {  
	    Console.Write("{0}-элемент: ",i);
	    array[i] = Convert.ToInt32(Console.ReadLine());  		
    }  

    Console.Write("Массив: ");  
    for (i = 0; i < N; i++)
        {
            Console.Write(array[i] + ", ");
        }
}

PrintArray();