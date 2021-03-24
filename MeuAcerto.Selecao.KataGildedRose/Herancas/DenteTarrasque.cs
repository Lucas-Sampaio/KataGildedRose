using System;
using System.Collections.Generic;
using System.Text;

namespace MeuAcerto.Selecao.KataGildedRose.Herancas
{
    class DenteTarrasque : IItem
    {
        private Item _item;

        public DenteTarrasque(Item item)
        {
            _item = item;
        }

        public void AtualizarItem()
        {
            _item.Qualidade = 80;
        }
    }
}
