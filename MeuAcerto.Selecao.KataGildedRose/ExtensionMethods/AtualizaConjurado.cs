namespace MeuAcerto.Selecao.KataGildedRose.ExtensionMethods
{
    public static class AtualizaConjurado
    {
        public static void AtualizarConjurado(this Item item)
        {
            item.Qualidade -= 2;
            item.PrazoParaVenda -= 1;
        }
    }
}
