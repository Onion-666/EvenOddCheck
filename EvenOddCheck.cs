using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;


class EvenOddCheck
{
    static void Main()
    {
        int number, remainder;
        number = Int32.Parse(Interaction.InputBox("Введите целое число",
            "Проверка четности/нечетности"));
        remainder = number % 2;
        MessageBox.Show("Вы ввели " + (remainder == 0 ? "четное число" : "нечетное число"),
            "Проверка четности/нечетности");
    }
}