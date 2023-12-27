<h1 align="center">Sistema de Estacionamento</h1>

## Preparação

Será necessario ter instalado o [.Net versão 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).

Além disto você precisara de uma IDE, como por exemplo o [Visual Studio](https://visualstudio.microsoft.com/pt-br/), [Visual Studio Code](https://visualstudio.microsoft.com/pt-br/) ou [Rider](https://www.jetbrains.com/rider/download/#section=windows).

##  Tecnologias

Foram utilizadas as seguintes tecnologias:

- <b>C#</b>.
- <b>.Net versão 8.0</b>.

##  Desafio Proposto
Criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone, de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

O código base para a resolução deste desafio pode ser encontrado no seguinte repositorio: [Código base](https://github.com/digitalinnovationone/trilha-net-poo-desafio) 