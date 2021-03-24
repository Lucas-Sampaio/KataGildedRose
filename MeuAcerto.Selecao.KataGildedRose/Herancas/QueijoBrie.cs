using System;
using System.Collections.Generic;
using System.Text;

namespace MeuAcerto.Selecao.KataGildedRose.Herancas
{
    class QueijoBrie : IItem
    {
        private Item _item;

        public QueijoBrie(Item item)
        {
            _item = item;
        }

        public void AtualizarItem()
        {
            _item.PrazoParaVenda -= 1;
            var incremento = _item.PrazoParaVenda < 0 ? 2 : 1;
            _item.Qualidade += incremento;
        }
    }
}
