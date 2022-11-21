        // Напишите программу, которая принимает на вход  число и выдает сумму цифр в числе
        void fun(int A)
        {
            int b = 0;
            if (A > 0)
                for (int i = 1; i >= A; i++)
                {
                    b += i;
                }
             else
                  for (int i =1; i >= A; i--)
                  {
                    b += i;
                  }
                  Console.WriteLine(b);
        }
        Console.WriteLine("Введите число: ");

        fun(Convert.ToInt32(Console.ReadLine()));
