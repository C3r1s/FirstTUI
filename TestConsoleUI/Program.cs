using TestConsoleUI;
using tui_netcore;

Tui startWindow = new Tui();
startWindow.Title = " Приветствие ";
startWindow.Body = "Добро пожаловать в поиск";
startWindow.DrawOk();
Tui choiceWindow = new Tui();
choiceWindow.Title  = "Меню";
choiceWindow.Body  =  "Выберите что вы хотите сделать";

string choice = choiceWindow.DrawList(new List<string>()
{
    "1. Поиск рецепта по названию",
    "2. Поиск рецепта по ингредиентам",
    "3. Выход"
});
while (choice != "3. Выход")
{


    switch (choice)
    {
        case "1. Поиск рецепта по названию":
            Tui titleSearchWindow = new Tui();
            titleSearchWindow.Title = "Поиск по названию";
            titleSearchWindow.Body = "Введите название рецепта";
            string userRecipeName = titleSearchWindow.DrawInput();
            
            break;
        case "2. Поиск рецепта по ингредиентам":
            Tui ingridientsSearchWindow = new Tui();
            ingridientsSearchWindow.Title = "Поиск по ингредиентам";
            ingridientsSearchWindow.Body = "Введите ингредиент";
            List<string> userIngridientsList = ingridientsSearchWindow.DrawInput().Split(',').ToList();
            Tui ingWindow = new Tui();
            ingWindow.Title = "Проверка ингридиентов";
            ingWindow.Body = $"Введённые ингредиенты: {Cli.ListPrint(userIngridientsList)}";
            ingWindow.DrawOk();
            break;
        default:
            break;
    }
    
    choice = choiceWindow.DrawList(new List<string>()
    {
        "1. Поиск рецепта по названию",
        "2. Поиск рецепта по ингредиентам",
        "3. Выход"
    });
}