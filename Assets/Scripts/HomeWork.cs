using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HomeWork : MonoBehaviour
{
    #region First
    public void OnSumEvenNumbersInRange()
    {
        int min = 7;
        int max = 21;
        var want = 98;
        int got = SumEvenNumbersInRange(min, max);
        string message = want == got ? "Результат верный" : $"Результат неверный, ожидается {want}";
        Debug.Log($"Сумма четных чисел в диапазоне от {min} до {max} включительно: {got} - {message}");
    }

    private int SumEvenNumbersInRange(int min, int max)
    {
        int even = 0;
        for (int i = min; i <= max; i++)
        {
            if (i % 2 == 0)
                even += i;
        }
        return even;
    }
    #endregion First
    #region Second
    public void OnSumEvenNumbersInArray()
    {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int want = 214;
        int got = SumEvenNumbersInArray(array);
        string message = want == got ? "Результат верный" : $"Результат неверный, ожидается {want}";
        Debug.Log($"Сумма четных чисел в заданном массиве: {got} - {message}");
    }

    private int SumEvenNumbersInArray(int[] array)
    {
        int even = 0;
        foreach (int arr in array)
        {
            if (arr % 2 == 0)
            {
                even += arr;
            }
        }
        return even;
    }
    #endregion Second
    #region Third
    public void OnFirstOccurrence()
    {
        // Первый тест, число присутствует в массиве
        int[] array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int value = 34;
        int want = 3;
        int got = FirstOccurrence(array, value);
        string message = want == got ? "Результат верный" : $"Результат неверный, ожидается {want}";
        Debug.Log($"Индекс первого вхождения числа {value} в массив: {got} - {message}");

        // Второй тест, число не присутствует в массиве
        array = new int[] { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        value = 55;
        want = -1;
        got = FirstOccurrence(array, value);
        message = want == got ? "Результат верный" : $"Результат неверный, ожидается {want}";
        Debug.Log($"Индекс первого вхождения числа {value} в массив: {got} - {message}");
    }

    private int FirstOccurrence(int[] array, int value)
    {
        int count = 0;
        foreach (int number in array)
        {
            if (number == value)
            {
                return count;
            }
            count++;
        }
        return -1;
    }
    #endregion Third
    #region Fourth
    public void OnSelectionSort()
    {
        int[] originalArray = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        Debug.LogFormat("Исходный массив {0}", "[" + string.Join(",", originalArray) + "]");

        int[] sortedArray = SelectionSort((int[])originalArray.Clone());
        Debug.LogFormat("Результат сортировки {0}", "[" + string.Join(",", sortedArray) + "]");

        int[] expectedArray = { 10, 13, 15, 22, 26, 34, 34, 68, 71, 81 };
        Debug.Log(sortedArray.SequenceEqual(expectedArray) ? "Результат верный" : "Результат не верный");
    }

    private int[] SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j].CompareTo(array[min]) < 0)
                    min = j;
            }
            int number = array[i];
            array[i] = array[min];
            array[min] = number;
        }
        return array;
    }
    #endregion Fourth
}

