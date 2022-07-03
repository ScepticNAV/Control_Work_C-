**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

# Решение задачи
### Блок ввода массива из строк:
Реализовано решение ввода размерности и элементов массива пользователем.

Также введена переменная **limit**, которая ограничивает количество символов в элементах нового формируемого массива. Согласно условию задачи она должная быть равна 3.

### Для решения поставленной задачи программа использует три метода:
1. **InputArray** - Метод формирования пользователем массива строк вводом размерности массива и его элементов с консоли.
* На выходе метода получается заполненный массив строк **InputArray**, удовлетворяющий условию, _что является решением задачи_.

2. **OutputArray** - Метод подсчёта количества элементов, размер которых меньше переменной **limit**, которую пользователь вводит с консоли. Для решения конкретной задачи, необходимо ввести значение переменной **limit**, равное 3.
* Пройдя первым циклом по всем элементам массива **inputArray** программа считает количество символов в элементах исходного массива, меньшее или равное "limit", результат записывается в переменную **newLen**, значение которой будет равно размерности нового массива **outputArray**, состоящего из элементов исходного массива количество символов в элементах которого, будет меньше или равно **limit**.
* Далее, после подсчета длины нового массива, проходя вторым циклом по исходному массиву перебором осуществляется поиск необходимых элементов количество символов в которых <= **limit**.
* Результат в виде нового массива выводится в переменную **outputArray**.

3. **PrintArray** - метод печати массива.
