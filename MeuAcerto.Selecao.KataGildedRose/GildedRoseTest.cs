using System.Collections.Generic;
using Xunit;

namespace MeuAcerto.Selecao.KataGildedRose
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Nome = "foo", PrazoParaVenda = 0, Qualidade = 0 } };
            GildedRose app = new GildedRose(Items);
            app.AtualizarQualidade();
            Assert.Equal("foo", Items[0].Nome);
            Assert.Equal(0, Items[0].Qualidade);
            Assert.Equal(-1, Items[0].PrazoParaVenda);

            Items.Add(new Item { Nome = "Queijo Brie Envelhecido", PrazoParaVenda = 2, Qualidade = 0 });

            for (int i = 0; i < 30; i++)
            {
                app.AtualizarQualidade();
            }

            Assert.Equal(50, Items[1].Qualidade);
            Assert.Equal(-28, Items[1].PrazoParaVenda);
        }
    }
}
