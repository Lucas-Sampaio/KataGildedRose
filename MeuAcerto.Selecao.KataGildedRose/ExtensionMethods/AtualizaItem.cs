namespace MeuAcerto.Selecao.KataGildedRose.ExtensionMethods
{
    public static class AtualizaItem
    {
        public static void AtualizarItem(this Item item)
        {
            item.PrazoParaVenda -= 1;
            var decremento = item.PrazoParaVenda < 0 ? 2 : 1;
            item.Qualidade -= decremento;
          
        }
    }
}
