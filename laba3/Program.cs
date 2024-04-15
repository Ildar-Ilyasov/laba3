using System;

struct Student
{
    public string Name;
    public string Group;
    public int[] Grades;

    public double GetAverageGrade()
    {
        double sum = 0;
        foreach (var grade in Grades)
        {
            sum += grade;
        }
        return sum / Grades.Length;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[7];
        students[0] = new Student { Name = "Ильясов И.Р.", Group = "Группа 1", Grades = new int[] { 4, 5, 4, 4, 5 } };
        students[1] = new Student { Name = "Амитров А.Д.", Group = "Группа 2", Grades = new int[] { 3, 4, 5, 4, 4 } };
        students[2] = new Student { Name = "Вапилин Д.М.", Group = "Группа 3", Grades = new int[] { 5, 5, 5, 5, 5 } };
        students[3] = new Student { Name = "Баландин К.Е.", Group = "Группа 1", Grades = new int[] { 5, 4, 5, 3, 4 } };
        students[4] = new Student { Name = "Шагина В.А", Group = "Группа 2", Grades = new int[] { 5, 5, 4, 5, 5 } };
        students[5] = new Student { Name = "Кудимов В.А.", Group = "Группа 3", Grades = new int[] { 3, 3, 3, 4, 3 } };
        students[6] = new Student { Name = "Чекушин Н.С.", Group = "Группа 1", Grades = new int[] { 4, 5, 5, 4, 5 } };

        for (int i = 0; i < students.Length - 1; i++)
        {
            for (int j = 0; j < students.Length - 1 - i; j++)
            {
                if (students[j].GetAverageGrade() > students[j + 1].GetAverageGrade())
                {
                    Student temp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Студенты, упорядоченные по возрастанию среднего балла:");
        foreach (var student in students)
        {
            Console.WriteLine($"Студент: {student.Name}, Группа: {student.Group}, Средний балл: {student.GetAverageGrade()}");
        }
    }
}
