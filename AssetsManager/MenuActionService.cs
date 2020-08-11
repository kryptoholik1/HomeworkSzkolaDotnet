using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace AssetsManager
{
    class MenuActionService
    {
        private List<MenuAction> menuActions;// lista typuMenuAction do tej listy dodaj akcje menu

        public MenuActionService()
        {
            menuActions = new List<MenuAction>(); //inicjalizacja listy menuActions
        }

        
        //tworzenie , menu i dodawanie do listy  , menuName jest niejako przyszłym filtrem do znajdwyania 
        public void AddNewAction (int id , string name, string menuName)
        {

            MenuAction menuAction = new MenuAction() { Id = id, Name = name, MenuName = menuName };
            menuActions.Add(menuAction);

        }

        // wyszukiwanie menu po nazwie
        public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        {

            List<MenuAction> result = new List<MenuAction>();

            foreach (var menuAction in menuActions)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }

    }
}
