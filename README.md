# API Grimorium

Como um grande fã de Magic The Gathering resolvi criar uma API que irá realizar o cadastro de jogadores e seus decks.
Para fins de estudo resolvi complicar um pouco mais a criação, levando em conta alguns detalhes como FORMATOS

*Pauper -> Somente cartas Comuns ou que já foram printadas como Comuns 
*Commander -> Decks costumam ter no mínimo 60 cartas... porém no Commander temos 99 + Comandante, dessas 99 nenhuma pode ser repetida 


## Cadastros 
### Jogador
- O jogador possui: Nome, Idade, Sexo, estado, 
- O jogador poderá ser cadastrado sem nenhum deck.

### Deck
- Os decks DEVEM possuir 1 Jogador
- Os decks são únicos, mesmo possuindo as mesmas cartas e com mesmas quantidades


## A API irá consumir outra API 
- https://api.magicthegathering.io/v1/



## Stack utilizada

**Back-end:** .NET 6, EFCore
**Cloud:** Azure
