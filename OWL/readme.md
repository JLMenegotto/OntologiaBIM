
## Arquivos OWL com as ontologias em sintaxe Manchester

O aluno pode abrir o arquivo OWL num editor de texto ou no Editor Protégé e fazer a leitura do conteúdo que está em sintaxe Manchester.

## Exemplo de filtro SPARQL que pode ser aplicado

Retorna uma lista de materiais n1 = 20 
                               n2 = 10 
ordenada com as colunas n1, n2, descrição do material
   
        1.    SELECT ?obj ?y ?p ?q
        2.    WHERE
        3.    {   ?obj abnt:código-n1 "20" .
        4.        ?obj abnt:código-n2 "10" .
        5.        ?obj abnt:código-n1 ?y .
        6.        ?obj abnt:código-n2 ?p .
        7.        ?obj abnt:descrição ?q .
        8.    }

