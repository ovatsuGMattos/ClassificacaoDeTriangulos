# 📐 Classificação de Triângulos

![](https://i.imgur.com/osbpWrL.gif)


## Funcionalidades
- Validação se os lados formam um triângulo
- Classificação do triângulo:
- Equilátero: três lados iguais
- Isósceles: dois lados iguais
- Escaleno: todos os lados diferentes
- Mensagem de erro para entradas inválidas ou impossíveis de formar um triângulo

## Regra usada

Para formar um triângulo, é necessário que:

```
lado1 + lado2 > lado3
lado1 + lado3 > lado2
lado2 + lado3 > lado1
```

## Como Utilizar

1.Clone o repositório ou baixe o código fonte.
2.Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3.Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4.Em seguida, compile a solucao utilizando o comando

```
dotnet build --configuration Release
```
5.Para executar o projeto compilado em tempo real

```
dotnet run --project ClassificacaoDeTriangulos
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.







