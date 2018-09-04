﻿using System;
using System.Collections.Generic;

using CursoCSharpCod3r.Fundamentos;

namespace CursoCSharpCod3r {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentário - Fundamentos", Comentarios.Executar},
                {"Variáveis e constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando numeros - Fundamentos", FormantandoNumero.Executar},
            });

            central.SelecionarEExecutar();
            Console.ReadKey();
        }
    }
}