
## Arquivos OWL com as ontologias em sintaxe Manchester

O aluno pode abrir o arquivo OWL num editor de texto ou no Editor Protégé e fazer a leitura do conteúdo que está em sintaxe Manchester.

## Exemplo de filtro SPARQL que pode ser aplicado
  
        1.    Retorna uma lista de materiais n1= 20 , n2= 10 e ordenada com as colunas n1, n2, descrição do material
        2.
        3.    SELECT ?obj ?y ?p ?q
        4.    WHERE
        5.    {   ?obj abnt:código-n1 "20" .
        6.        ?obj abnt:código-n2 "10" .
        7.        ?obj abnt:código-n1 ?y .
        8.        ?obj abnt:código-n2 ?p .
        9.        ?obj abnt:descrição ?q .
        10.    }

