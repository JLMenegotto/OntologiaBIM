
## Arquivos OWL com as ontologias em sintaxe Manchester

O aluno pode abrir o arquivo OWL num editor de texto ou no Editor Protégé e fazer a leitura do conteúdo que está em sintaxe Manchester.

## Exemplo de filtro SPARQL que pode ser aplicado

Retorna uma lista de materiais n1 = 20 
                               n2 = 10 
ordenada com as colunas n1, n2, descrição do material

1.  SELECT ?obj ?y ?p ?q
    WHERE
     {   ?obj abnt:código-n1 "20" .
         ?obj abnt:código-n2 "10" .
         ?obj abnt:código-n1 ?y .
         ?obj abnt:código-n2 ?p .
         ?obj abnt:descrição ?q .
     }
