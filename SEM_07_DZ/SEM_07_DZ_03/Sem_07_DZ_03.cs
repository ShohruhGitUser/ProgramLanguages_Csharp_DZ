 Console.OutputEncoding = System.Text.Encoding.UTF8;   // Синтаксис для отображения кирилического текста *у меня проблема с выводом

void PrintArrayInReverse(int[] array, int index)
    {
        if (index < 0) return; 
        
        Console.Write($"{array[index]} "); 
        
        PrintArrayInReverse(array, index - 1);  // уменьшаем индекс, и вызываем сам метод еще раз
    }

        int[] array = {1, 2, 5, 0, 10, 34};
        
        PrintArrayInReverse(array, array.Length - 1);
    
