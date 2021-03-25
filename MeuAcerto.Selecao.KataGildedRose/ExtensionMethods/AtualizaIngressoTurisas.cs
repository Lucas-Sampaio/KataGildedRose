namespace MeuAcerto.Selecao.KataGildedRose.ExtensionMethods
{
    public static class AtualizaIngressoTurisas
    {
        public static void AtualizarIngressoTurisas(this Item item)
        {
            if (item.PrazoParaVenda <= 5) item.Qualidade += 3;
            else if (item.PrazoParaVenda <= 10) item.Qualidade += 2;
            else item.Qualidade += 1;

            item.PrazoParaVenda -= 1;

            if (item.PrazoParaVenda < 0) item.Qualidade = 0;
        }
    }
}
