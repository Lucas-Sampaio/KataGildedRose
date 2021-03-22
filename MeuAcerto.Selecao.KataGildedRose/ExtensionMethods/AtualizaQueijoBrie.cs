namespace MeuAcerto.Selecao.KataGildedRose.ExtensionMethods
{
    public static class AtualizaQueijoBrie
    {
        public static void AtualizarQueijoBrie(this Item item)
        {
            item.PrazoParaVenda -= 1;
            var incremento = item.PrazoParaVenda < 0 ? 2 : 1;
            item.Qualidade += incremento;
        }
    }
}
