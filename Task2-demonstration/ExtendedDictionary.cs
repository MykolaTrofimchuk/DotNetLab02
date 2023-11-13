using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_demonstration
{
    // ExtendedDictionary - узагальнений клас для зберігання “розширеного словника”
    public class ExtendedDictionary<T, U, V> : IEnumerable<ExtendedDictionaryElement<T, U, V>>
    {
        private List<ExtendedDictionaryElement<T, U, V>> elements = new List<ExtendedDictionaryElement<T, U, V>>();

        // додавання нового елементу у словник
        public void Add(T key, U value1, V value2)
        {
            elements.Add(new ExtendedDictionaryElement<T, U, V>(key, value1, value2));
        }

        // видалення елемента із словника (за його ключем)
        public bool Remove(T key)
        {
            var element = elements.Find(e => e.Key.Equals(key));
            if (element != null)
            {
                elements.Remove(element);
                return true;
            }
            return false;
        }

        // перевірка наявності елемента (за його ключем)
        public bool ContainsKey(T key)
        {
            return elements.Exists(e => e.Key.Equals(key));
        }

        // перевірка наявності елемента (за його значеннями)
        public bool ContainsValue(U value1, V value2)
        {
            return elements.Exists(e => e.Value1.Equals(value1) && e.Value2.Equals(value2));
        }

        // повертає елемент за заданим ключем (якщо він присутній у словнику)
        public ExtendedDictionaryElement<T, U, V> this[T key]
        {
            get
            {
                return elements.Find(e => e.Key.Equals(key));
            }
        }

        // повертає к-сть елементів у словнику
        public int Count
        {
            get { return elements.Count; }
        }

        // методи інтерфейсу IEnumerator, щоб дозволити використання в циклах foreach.
        public IEnumerator<ExtendedDictionaryElement<T, U, V>> GetEnumerator()
        {
            return elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    // ExtendedDictionaryElement - представлення окремого елемента словника
    public class ExtendedDictionaryElement<T, U, V>
    {
        public T Key { get; }
        public U Value1 { get; }
        public V Value2 { get; }

        public ExtendedDictionaryElement(T key, U value1, V value2)
        {
            Key = key;
            Value1 = value1;
            Value2 = value2;
        }
    }
}
