namespace MeuAcerto.Selecao.KataGildedRose.Herancas
{
    class Conjurado : IItem
    {
        private Item _item;
        public Conjurado(Item item)
        {
            _item = item;
        }
        public void AtualizarItem()
        {
            _item.Qualidade -= 2;
            _item.PrazoParaVenda -= 1;
        }
    }
}
