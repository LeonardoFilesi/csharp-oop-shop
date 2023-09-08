using csharp_oop_shop;
internal class Program
{
    private static void Main(string[] args)
    {
        {
            Prodotto actionFigure = new Prodotto("action figure", "Stormtrooper", 143, 22);

            Console.WriteLine($"La nuovissima {actionFigure.nome} rappresenta uno {actionFigure.descrizione} nella sua tipica posa. Il prezzo è {actionFigure.prezzoConIva}$ di cui iva {actionFigure.iva}");
        }
    }
}