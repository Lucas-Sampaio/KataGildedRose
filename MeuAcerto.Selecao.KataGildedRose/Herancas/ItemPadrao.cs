namespace MeuAcerto.Selecao.KataGildedRose.Herancas
{
    class ItemPadrao : IItem
    {
        private Item _item;

        public ItemPadrao(Item item)
        {
            _item = item;
        }

        public void AtualizarItem()
        {
            _item.PrazoParaVenda -= 1;
            var decremento = _item.PrazoParaVenda < 0 ? 2 : 1;
            _item.Qualidade -= decremento;
        }
    }
}
