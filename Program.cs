//Задание 1
//namespace Pipiska
//{
//     (Обобщенный класс с параметром типа T)
//    class MyClass<T>
//    {
//        (Закрытое поле обобщенного типа T)
//        private T _field;

//       (Свойство обобщенного типа T)
//        public T Value
//        {
//           (Геттер: возвращает значение закрытого поля)
//            get { return _field; }
//             (Сеттер: присваивает значение закрытому полю)
//            set { _field = value; }
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//             (Создаем объект с типом int)
//            MyClass<int> obj1 = new MyClass<int>();
//            obj1.Value = 42;  (Присваиваем через свойство)
//            Console.WriteLine("obj1.Value = " + obj1.Value);  (Читаем через свойство)

//             (Создаем объект с типом string)
//            MyClass<string> obj2 = new MyClass<string>();
//            obj2.Value = "Привет";
//            Console.WriteLine("obj2.Value = " + obj2.Value);

//            Console.ReadLine();
//        }
//    }
//}

//Задание 2
//namespace Task2
//{
//class Program
//{
// Статический обобщенный метод с ограничением: T должен реализовывать IComparable
//        static T GetMax<T>(T[] array) where T : IComparable
//        {
//            // Берем первый элемент как начальный максимум
//            T max = array[0];

//            // Проходим по всем элементам массива
//            for (int i = 1; i < array.Length; i++)
//            {
//                // Если текущий элемент больше максимума (CompareTo > 0),
//                // то обновляем максимум
//                if (array[i].CompareTo(max) > 0)
//                {
//                    max = array[i];
//                }
//            }

//            // Возвращаем наибольший элемент
//            return max;
//        }

//        static void Main()
//        {
//            // Массив целых чисел
//            int[] numbers = { 3, 7, 2, 9, 5 };
//            Console.WriteLine("Максимум (int): " + GetMax(numbers));

//            // Массив строк (строки тоже реализуют IComparable)
//            string[] words = { "яблоко", "банан", "апельсин", "груша" };
//            Console.WriteLine("Максимум (string): " + GetMax(words));

//            Console.ReadLine();
//        }
//    }
//}



//Задание 3

//namespace Task3
//{
//    // Обобщенный класс, хранящий ссылку на массив элементов типа T
//    class MyArray<T>
//    {
//        // Поле — ссылка на массив элементов обобщенного типа
//        public T[] Data;

//        // Конструктор: принимает массив и сохраняет ссылку на него
//        public MyArray(T[] data)
//        {
//            Data = data;
//        }

//        // Операторный метод для оператора +, позволяющий складывать два объекта класса
//        public static MyArray<T> operator +(MyArray<T> a, MyArray<T> b)
//        {
//            // Создаем новый массив длиной = сумма длин двух массивов
//            T[] result = new T[a.Data.Length + b.Data.Length];

//            // Копируем элементы первого массива в начало результата
//            for (int i = 0; i < a.Data.Length; i++)
//                result[i] = a.Data[i];

//            // Копируем элементы второго массива после первого
//            for (int i = 0; i < b.Data.Length; i++)
//                result[a.Data.Length + i] = b.Data[i];

//            // Возвращаем новый объект с объединенным массивом
//            return new MyArray<T>(result);
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Первый объект с массивом {1, 2, 3}
//            MyArray<int> obj1 = new MyArray<int>(new int[] { 1, 2, 3 });
//            // Второй объект с массивом {4, 5}
//            MyArray<int> obj2 = new MyArray<int>(new int[] { 4, 5 });

//            // Складываем два объекта
//            MyArray<int> sum = obj1 + obj2;

//            // Выводим результат
//            Console.WriteLine("Результат сложения: " + string.Join(", ", sum.Data));

//            Console.ReadLine();
//        }
//    }
//}



//Задание 4
//namespace Task4
//{
//    // Обобщенный класс, который хранит массив объектов любого типа
//    class MyList<T>
//    {
//        // Внутренний массив для хранения данных
//        private T[] _items = new T[0];

//        // Метод для добавления элемента в массив
//        public void Add(T item)
//        {
//            // Создаем новый массив на 1 элемент больше
//            T[] newItems = new T[_items.Length + 1];

//            // Копируем старые элементы
//            for (int i = 0; i < _items.Length; i++)
//                newItems[i] = _items[i];

//            // Записываем новый элемент в конец
//            newItems[_items.Length] = item;

//            // Заменяем старый массив новым
//            _items = newItems;
//        }

//        // Метод для удаления элемента по индексу
//        public void RemoveAt(int index)
//        {
//            // Проверка на корректность индекса
//            if (index < 0 || index >= _items.Length)
//                throw new IndexOutOfRangeException("Неверный индекс");

//            // Создаем новый массив на 1 элемент меньше
//            T[] newItems = new T[_items.Length - 1];

//            // Копируем элементы до удаляемого индекса
//            for (int i = 0; i < index; i++)
//                newItems[i] = _items[i];

//            // Копируем элементы после удаляемого индекса
//            for (int i = index + 1; i < _items.Length; i++)
//                newItems[i - 1] = _items[i];

//            // Заменяем старый массив новым
//            _items = newItems;
//        }

//        // Метод для получения элемента по индексу
//        public T Get(int index)
//        {
//            // Проверка на корректность индекса
//            if (index < 0 || index >= _items.Length)
//                throw new IndexOutOfRangeException("Неверный индекс");

//            return _items[index];
//        }

//        // Метод, возвращающий длину массива
//        public int Length
//        {
//            get { return _items.Length; }
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Создаем список строк
//            MyList<string> list = new MyList<string>();

//            // Добавляем элементы
//            list.Add("Первый");
//            list.Add("Второй");
//            list.Add("Третий");

//            Console.WriteLine("Длина: " + list.Length);
//            Console.WriteLine("Элемент [1]: " + list.Get(1));

//            // Удаляем элемент с индексом 0
//            list.RemoveAt(0);

//            Console.WriteLine("После удаления длина: " + list.Length);
//            Console.WriteLine("Элемент [0]: " + list.Get(0));

//            Console.ReadLine();
//        }
//    }
//}