﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    internal class GerenciaPersistenciaFatura
    {
        private IPersistenciaDaFatura persistenciaDaFatura;

        public GerenciaPersistenciaFatura(IPersistenciaDaFatura persistenciaDaFatura)
        {
            this.persistenciaDaFatura = persistenciaDaFatura;
        }

        public void Executar(Fatura fatura)
        {
            persistenciaDaFatura.Salvar(fatura);
        }
    }
}
