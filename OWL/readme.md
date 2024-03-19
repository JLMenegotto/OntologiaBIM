
## Arquivos OWL com as ontologias em sintaxe Manchester

O aluno pode abrir o arquivo OWL num editor de texto ou no Editor Protégé e fazer a leitura do conteúdo que está em sintaxe Manchester.
No editor Protégé, pode aplicar filtros com a linguagem SPARQL, que permite realizar consultas em estruturas RDF (Resource Description Framework).
Antes de efetuar a consulta deve ativar o Reasoner HermiT.
Consulte em: https://www.w3.org/TR/sparql11-query/

## Exemplo 1: filtro SPARQL
  
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

## Exemplo 2: filtro SPARQL 

        1.    Retorna só as instâncias que tenham códigos do SomaSUS
        2.
        3.    SELECT ?ind
        4.    WHERE
        5.    {   
        6.            ?ind rdf:type abnt:CódigoSUS .
        7.    }
      
