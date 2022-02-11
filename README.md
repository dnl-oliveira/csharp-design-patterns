# csharp-design-patterns
Projeto com exemplo de implementações de padrões de projetos com C#. O Projeto foi reaproveitado e evoluido com o uso de cada padrão, seguindo a ordem abaixo.

## 1. Strategy
Um dos pré-requisitos para o Strategy é uma estrutura de herança onde cada subclasse específica contém uma variação do algoritmo. Assim, o padrão Strategy possui diversos benefícios como clarificar algoritmos ao diminuir ou remover lógica condicional, simplificar uma classe ao mover variações de um algoritmo para uma hierarquia

## 2. Chain of Responsibility
O padrão Chain of Responsibility cai como uma luva quando temos uma lista de comandos a serem executados de acordo com algum cenário em específico, e sabemos também qual o próximo cenário que deve ser validado, caso o anterior não satisfaça a condição.

## 3. Template Method
Quando temos diferentes algoritmos que possuem estruturas parecidas, o Template Method é uma boa solução. Com ele, conseguimos definir, em um nível mais macro, a estrutura do algoritmo e deixar "buracos", que serão implementados de maneira diferente por cada uma das implementações específicas.

## 4. Decorator
Sempre que percebemos que temos comportamentos que podem ser compostos por comportamentos de outras classes envolvidas em uma mesma hierarquia, o Decorator introduz a flexibilidade na composição desses comportamentos, bastando escolher no momento da instanciação, quais instancias serão utilizadas para realizar o trabalho.

## 4. State
A principal situação que faz emergir o Design Pattern State é a necessidade de implementação de uma máquina de estados. Geralmente, o controle das possíveis transições são vários e complexos, fazendo com que a implementação não seja simples. O State auxilia a manter o controle dos estados simples e organizados através da criação de classes que representem cada estado e saiba controlar as transições.