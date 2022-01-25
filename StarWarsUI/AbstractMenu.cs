//
namespace StarWarsUI{
    internal interface AbstractMenu{
        /// <summary>
        /// Display the menu and user choices
        /// </summary>
        void Display();

        /// <summary> 
        /// Record user choice and change menu based on choice
        /// </summary>
        /// <returns>Return the new menu</returns>
        string UserChoice();
    }
}