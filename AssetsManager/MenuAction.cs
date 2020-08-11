using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsManager
{
    // Klasa odpowiedzialna za zarządzanie Menu
    class MenuAction
    {
        public int Id { get; set; }  // Odpowiedzialne za kolejność wyświetlania akcji na ekranie
        public string Name { get; set;} // Nazwa akcji
        public string MenuName { get; set;} // Nazwa menu by odróżnić menu jedno od drugiego


    }
}
