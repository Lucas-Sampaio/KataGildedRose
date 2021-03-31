using MeuAcerto.Selecao.KataGildedRose.ExtensionMethods;
using MeuAcerto.Selecao.KataGildedRose.Herancas;
using System.Collections.Generic;

namespace MeuAcerto.Selecao.KataGildedRose
{
    class GildedRose
    {

        IList<Item> Itens;
        public GildedRose(IList<Item> Itens)
        {
            this.Itens = Itens;
        }

        private bool EhQualidadeNegativa(Item item)
        {
            return item.Qualidade < 0;
        }
        private bool UltrapassouQualidadeMaxima(Item item)
        {
            var qualidadeMaxima = 50;
            if (item.Nome != "Dente do Tarrasque" && item.Qualidade > qualidadeMaxima)
                return true;

            return false;
        }

        //solucao extensions methods
        public void AtualizarQualidade()
        {

            foreach (var item in Itens)
            {
                if (item.Nome == "Queijo Brie Envelhecido") item.AtualizarQueijoBrie();
                else if (item.Nome == "Dente do Tarrasque") item.AtualizarDenteTarrasque();
                else if (item.Nome == "Ingressos para o concerto do Turisas") item.AtualizarIngressoTurisas();
                else if (item.Nome.Contains("Conjurado")) item.AtualizarConjurado();
                else item.AtualizarItem();

                if (EhQualidadeNegativa(item)) item.Qualidade = 0;
                if (UltrapassouQualidadeMaxima(item)) item.Qualidade = 50;
            }

        }
        //solucao factory
        public void AtualizarQualidadeFactory()
        {

            foreach (var item in Itens)
            {
                new ItemFactory().CriarItem(item).AtualizarItem();

                if (EhQualidadeNegativa(item)) item.Qualidade = 0;
                if (UltrapassouQualidadeMaxima(item)) item.Qualidade = 50;
            }

        }
    }
}

