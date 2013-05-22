﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Dojo1.Tests
{
    [TestFixture]
    public class MoneyWriterTests
    {
        [TestCase(1, "Um real")]
        [TestCase(2, "Dois reais")]
        [TestCase(3, "Três reais")]
        [TestCase(4, "Quatro reais")]
        [TestCase(5, "Cinco reais")]
        [TestCase(6, "Seis reais")]
        [TestCase(7, "Sete reais")]
        [TestCase(8, "Oito reais")]
        [TestCase(9, "Nove reais")]
        public void Para_Numeros_Inteiros_Deve_Retornar_Por_Extenso(int valor, string extenso)
        {
            MoneyWriter writer = new MoneyWriter();
            string porextenso = writer.RetornaValorPorExtenso(valor);

            Assert.That(porextenso, Is.EqualTo(extenso));
        }

        //Control + U + U Roda Tudo os Testes
    }
}
