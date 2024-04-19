namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interargirci per testare tutti i metodi che avete previsto.

            //BONUS:
            //- create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri(ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
            //- Usando un array, dichiarate un elenco dei prodotti di un negozio e inseriteci al suo interno qualche prodotto che vi aspettate di trovare nel negozio.
            //Stampate poi l’elenco dei vostri prodotti che avete previsto nel negozio.d


            //Product cellulare = new Product("Cellulare", "standard", 769.99, 22);
            //Console.WriteLine($"Codice - {cellulare.ExtendedName()} - Prezzo: senza iva {cellulare.Price} con iva {cellulare.PriceAddIva()} Euro ");
            
            //bONUS
            //lista prodotti shop
            Product[] listProducts = new Product[5];

            listProducts[0] = new Product("Computer", "Computer portatile", 784.99, 22);
            listProducts[1] = new Product("Smartphone", "Smartphone di ultimaA generazione", 399.99, 22);
            listProducts[2] = new Product("TV", "TV 4K", 999.99, 22);
            listProducts[3] = new Product("Caramelle", "Gomose", 5.54, 4);
            listProducts[4] = new Product("Miele", "dolce", 30.6, 14);

            //stampare dettagli prodotti in console
            foreach (Product product in listProducts)
            {
                Console.WriteLine($"{product.ExtendedName()} - Prezzo: senza iva {product.Price} con iva {product.PriceAddIva()} Euro ");
            }


        }
    }
}
