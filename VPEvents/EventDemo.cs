using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPEvents
{
    public class EventDemo
    {
        // Пример 1
        // Обработчик события
        static void FirstHandler()
        {
            Console.WriteLine("Произошло событие");
        }

        public void FirstDemo()
        {
            // Создаем объект класса события
            MyEvent evt = new MyEvent();

            // Добавим метод Handler() в список обработчиков события
            evt.SomeEvent += FirstHandler;

            // Запустим событие
            // Здесь вызываются все методы, являющиеся обработчиками
            evt.OnSomeEvent();
        }


        // Пример 2
        // Обработчик события
        static void SecondHandler()
        {
            Console.WriteLine("Событие получил объект класса EventDemo");
        }

        public void SecondDemo()
        {
            // Создаем объект класса события
            MyEvent evt = new MyEvent();

            // Создаем котёнка и щенка
            Cat kitty = new Cat();
            Dog puppy = new Dog();

            // Добавим обработчики
            evt.SomeEvent += SecondHandler;
            evt.SomeEvent += kitty.CatHandler;
            evt.SomeEvent += puppy.DogHandler;

            // Запустим событие
            // Здесь вызываются все методы, являющиеся обработчиками            
            evt.OnSomeEvent();
        }

        // Пример 3
        public void ThirdDemo()
        {
            // Создаем объект класса события
            MyEvent evt = new MyEvent();

            // Создаем лисичек
            Fox f1 = new Fox("Рыжуля");
            Fox f2 = new Fox("Пушистик");
            Fox f3 = new Fox("Ушастик");

            // Добавим обработчики
            evt.SomeEvent += f1.FoxHandler;
            evt.SomeEvent += f2.FoxHandler;
            evt.SomeEvent += f3.FoxHandler;

            // Запустим событие           
            evt.OnSomeEvent();
        }


        // Пример 4
        public void FourthDemo()
        {
            // Создаем объект класса события
            MyEvent evt = new MyEvent();

            // Добавим обработчик
            evt.SomeEvent += Bird.BirdHandler;

            // Запустим событие           
            evt.OnSomeEvent();
        }

    }
}
