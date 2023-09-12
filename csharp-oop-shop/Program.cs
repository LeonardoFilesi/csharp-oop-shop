using csharp_oop_shop;

Prodotto actionFigure = new Prodotto("", "action figure", "Stormtrooper", 143, 22);

Console.WriteLine($"La nuovissima {actionFigure.nome}, codice {actionFigure.codiceNome} rappresenta uno {actionFigure.descrizione} nella sua tipica posa. " +
    $"Il prezzo è {actionFigure.prezzoConIva}$ di cui iva {actionFigure.iva}. Venendo al nostro punto vendita a San Marino, potrete avere questa fantastica {actionFigure.nome} " +
    $"al prezzo di costo di {actionFigure.prezzo}");

