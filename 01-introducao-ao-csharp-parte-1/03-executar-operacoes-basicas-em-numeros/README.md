# Executar operações básicas em números em C#

## Calculadora de gorjeta

Exercício de C# para calcular a gorjeta e o total de uma conta.

Atividade: [Calculadora de gorjeta — Microsoft Learn](https://microsoftlearning.github.io/mslearn-csharp-programming/Instructions/Exercises/03a-create-a-tip-calculator.html).

Com o SDK do .NET 10 instalado, execute no terminal desta pasta:

```bash
dotnet run --project OperacoesBasicas
```

## Explorações com IA

Após concluir a versão inicial, explorei as sugestões da atividade com ajuda de IA:

- `ToString("C", cultura)` apresenta os valores em dólares, com duas casas decimais, usando a cultura `en-US`.
- `Math.Round(..., 2)` arredonda a gorjeta para centavos antes de somá-la à conta. Em valores exatamente entre dois centavos, usa o arredondamento para o número par padrão do .NET.
- `Math.Max` compara o total calculado com uma conta anterior de exemplo, fixada em $40.00.

A entrada numérica usa a cultura do computador: por exemplo, em português do Brasil, digite `45,50` para a conta e `18` para a porcentagem. O resultado será uma gorjeta de $8.19 e um total de $53.69. Digite apenas números válidos.
