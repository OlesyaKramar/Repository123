
# **Итоговая контрольная работа по основному блоку**

## ***Описание работы проекта***

### **Краткое описание проекта**

При запуске программы будет задан исходный массив, а затем выведена его версия, отфильтрованная по принципу: если _n_-ый  элемент массива имеет длину, **не** превосходящую 3 символа, тогда он попадёт в выборку. Подробная блок-схема алгоритма представлена в файле ***"Блок-схема алгоритма.drawio"***.
________________________________________________________
### **Описание алгоритма**

**Первый этап: создание переменных**
##### Дла начала создаются переменные len (индекс последнего элемента массива array), i (счётчик) и count (используется для подсчёта элементов, которые будут в массиве new_array). Также на этом этапе задается сам массив array.
**Второй этап: первый цикл**
##### Цикл while, работающий, пока не проверит все элементы массива array, увеличивает count в случае нахождения элемента длиной не больше 3.
**Третий этап: наполнение массива new_array**
##### На этом этапе сначала сбрасываются значения переменных i и count, а потом создается массив new_array, который будет наполнен элементами в следующем этапе. После этого цикл while проверяет все элементы на соответствие условию для попадания в new_array и добавляет их туда при соблюдении условия.
**Четвёртый этап: вывод массива new_array**
##### Просто выводится массив new_array
___
___
# ***И на этом ВСЁ!***
