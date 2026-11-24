# Repetir ações com loop em C#

## Jogo de adivinhar o número

Exercício de C# em que o jogador tenta adivinhar um número sorteado entre 1 e 20. O jogo oferece cinco tentativas e informa se cada palpite está acima ou abaixo do número secreto.

Com o SDK do .NET 10 instalado, execute no terminal desta pasta:

```bash
dotnet run --project JogoDeAdivinhacao
```

## Explorações com IA

- `int.TryParse` verifica se a entrada é um número inteiro. Se não for, o jogo pede outra entrada sem consumir outra tentativa.
- `Math.Abs` calcula a distância entre o palpite e o número secreto. Quando o jogador erra por até 2, o jogo informa que ele está muito perto, além de dizer se o palpite foi alto ou baixo.

A versão anterior está preservada em `versao-inicial.cs.txt`.
