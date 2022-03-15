using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPEvents
{
    // Объявим тип делегата для обработчика событий
    delegate void MyEventHandler();    
    class MyEvent
    {
        // Объявляем событие
        public event MyEventHandler SomeEvent;

        // Этот метод вызывается для запуска события
        public void OnSomeEvent()
        {
            // Если событие не пустое
            if (SomeEvent != null)
                // Вызывается обработчик(и) с помощью делегата
                SomeEvent();
        }      


    }
}
