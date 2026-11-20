# Adicionar lógica de decisão ao código em C#

## Jogo de dados

Exercício de C# que simula o lançamento de três dados e concede um prêmio de acordo com a pontuação, incluindo bônus para dados iguais.

Atividade: [Jogo de dados — Microsoft Learn](https://microsoftlearning.github.io/mslearn-csharp-programming/Instructions/Exercises/04a-create-dice-game.html).

Com o SDK do .NET 10 instalado, execute no terminal desta pasta:

```bash
dotnet run --project JogoDeDados
```

## Explorações com IA

Após concluir a versão inicial, explorei as sugestões da atividade com ajuda de IA:

- `Random.Next(1, 21)` simula um dado de 20 lados: o limite inferior é incluído e o superior é excluído.
- O jogador escolhe um número inteiro positivo de rodadas. Um laço `for` executa cada rodada, e um contador registra quantas delas tiveram uma dupla ou uma trinca, contando apenas uma vez por rodada.
- Os bônus e os limites dos prêmios permanecem iguais aos da versão inicial. Como os dados agora têm 20 lados, totais maiores e o prêmio de carro se tornam mais frequentes.

O programa mostra o total após o bônus e, ao final, a quantidade de rodadas com bônus. A versão anterior está preservada em `versao-inicial.cs.txt`.

## Renovação de assinatura

Projeto para o desafio de exibir uma mensagem de renovação de assinatura. O programa informa o prazo de vencimento e, quando aplicável, exibe o desconto disponível conforme os dias restantes. No desafio bônus, assinaturas expiradas recebem 30% de desconto. A condição para 2 a 5 dias usa o operador lógico `&&` para explicitar os dois limites.

```bash
dotnet run --project RenovacaoDeAssinatura
```
