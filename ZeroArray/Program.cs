int[] a; // описание массива
a = new int[10]; // создали массив

// Первый способ
int j = 0;
while (j < 10)
{
    a[j] = 0;
    ++j;
}

// Второй способ
for (int i = 0; i < 10; ++i)
{
    a[i] = 0;
}

// Ввод массива с клавы
for (int i = 0; i < 10; ++i)
{
    string s = Console.ReadLine();
    a[i] = Convert.ToInt32(s);
}

for (int i = 0; i < 10; ++i)
{
    Console.Write(a[i] + " ");
}