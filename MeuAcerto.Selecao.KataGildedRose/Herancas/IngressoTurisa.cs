namespace MeuAcerto.Selecao.KataGildedRose.Herancas
{
    class IngressoTurisa : IItem
    {
        private Item _item;

        public IngressoTurisa(Item item)
        {
            _item = item;
        }

        public void AtualizarItem()
        {
            if (_item.PrazoParaVenda <= 5) _item.Qualidade += 3;
            else if (_item.PrazoParaVenda <= 10) _item.Qualidade += 2;
            else _item.Qualidade += 1;

            _item.PrazoParaVenda -= 1;

            if (_item.PrazoParaVenda < 0) _item.Qualidade = 0;
        }
    }
}
