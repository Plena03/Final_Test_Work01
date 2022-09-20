# Итоговая проверочная работа.

1. Создать репозиторий на GitHub.
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

## Задача: 

*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

## Примеры:

[“hello”, “2”, “world”, ‘’;-)”] -> [“2”, ‘’;-)”]
[‘’1234”, “1567”, “-2”, “computer science”] -> [“-2”]
[“Russia”, “Denmark”, “Kazan”] -> []

## Описание решения задачи.

*Объявляем два массива из строк. Задаем размер массива, который при желании можно всегда поменять. В методе в новом массиве внутри цикла задаем условие, при котором длина строк массива должна быть меньше либо равна 3. Если это условие выполняется, то элемент первого массива присваивается новому массиву. Делаем шаг. Возвращаемся к циклу, проверяем условие. Если условие не выполняется, возвращаемся к циклу и проверяем следующий элемент массива. Проверяем до тех пор, пока не пройдем все элементы массива. Выводим на экран.*

## Блок схема к данной задаче: 

![находится здесь](Block_Diagram.JPG)

## Решение Задачи лежит в папке: 

Final_Task01/Program.cs