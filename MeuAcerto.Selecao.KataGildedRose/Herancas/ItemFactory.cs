namespace MeuAcerto.Selecao.KataGildedRose.Herancas
{
    class ItemFactory
    {
        public IItem CriarItem(Item item)
        {
            IItem itemFactory;

            if (item.Nome == "Queijo Brie Envelhecido") itemFactory = new QueijoBrie(item);
            else if (item.Nome == "Dente do Tarrasque") itemFactory = new DenteTarrasque(item);
            else if (item.Nome == "Ingressos para o concerto do Turisas") itemFactory = new IngressoTurisa(item);
            else if (item.Nome.Contains("Conjurado")) itemFactory = new Conjurado(item);
            else itemFactory = new ItemPadrao(item);

            return itemFactory;
        }
    }
}
