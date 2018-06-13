using System.Collections.Generic;
using System.Web;

namespace ResiliationPacifica.App_Start
{
    public class MenuConfig
    {
        public class Rub
        {
            public string label { get; set; }
            public string icon { get; set; }
            public string controller { get; set; }
            public string action { get; set; }          // La page où on sera redirigé, au clic
            public string parameter { get; set; }
            public List<Rub> srub { get; set; }
        }

        public static List<Rub> menu
        {
            get { return HttpContext.Current.Application["Menu"] as List<Rub>; }
            set { HttpContext.Current.Application["Menu"] = value; }
        }

        /// <summary>
        /// 
        /// Menu de Gauche
        /// 
        /// </summary>
        public static void RegisterMenu()
        {
            /* Représentation du menu sous forme de dictionnaires */
            menu = new List<Rub>();

            // Rubrique PokerStats
            Rub rub1 = new Rub();
            rub1.label = "PokerStats";
            rub1.icon = "fa fa-home";
            rub1.controller = "Home";
            rub1.action = "Index";
            rub1.srub = new List<Rub>();

            // Rubrique Règles
            Rub rub2 = new Rub();
            rub2.label = "Les Règles";
            rub2.icon = "fa fa-file-text";
            rub2.controller = "Regles";
            rub2.srub = new List<Rub>();

            // Rubrique Vocabulaire
            Rub rub3 = new Rub();
            rub3.label = "Le Vocabulaire";
            rub3.icon = "fa fa-table";
            rub3.controller = "Vocabulaire";
            rub3.srub = new List<Rub>();

            // Rubrique Stratégies
            Rub rub4 = new Rub();
            rub4.label = "Les Stratégies";
            rub4.icon = "fa fa-gear";
            rub4.controller = "Strategies";
            rub4.srub = new List<Rub>();

            // Rubrique Statistiques
            Rub rub5 = new Rub();
            rub4.label = "Les Statistiques";
            rub4.icon = "fa fa-gear";
            rub4.controller = "Statistiques";
            rub4.srub = new List<Rub>();

            // Rubrique Trackeurs
            Rub rub6 = new Rub();
            rub4.label = "Les Trackeurs";
            rub4.icon = "fa fa-gear";
            rub4.controller = "Trackeurs";
            rub4.srub = new List<Rub>();

            // Rubrique Tournois réels de l'années
            Rub rub7 = new Rub();
            rub4.label = "Tournois de l'année";
            rub4.icon = "fa fa-gear";
            rub4.controller = "Tournois";
            rub4.srub = new List<Rub>();

            /* Défini l'affichage des menus en fonction du rôle l'utilisateur connecté */
            switch (HttpContext.Current.Session["role"].ToString())
            {
                default:
                case "Admin":

                    // RUB 1
                    menu.Add(rub1);

                    // RUB 2
                    menu.Add(rub2);

                    // RUB 3
                    menu.Add(rub3);
                    break;

                case "User":

                    // RUB 4
                    menu.Add(rub4);

                    // RUB 5
                    menu.Add(rub5);

                    // RUB 6
                    menu.Add(rub6);

                    // RUB 7
                    menu.Add(rub7);
                    break;


            }
        }
    }
}