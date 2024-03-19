
## Arquivos OWL com as ontologias em sintaxe Manchester

O aluno pode abrir o arquivo OWL num editor de texto ou no Editor Protégé e fazer a leitura do conteúdo que está em sintaxe Manchester.
No editor Protégé, pode aplicar filtros com a linguagem SPARQL, que permite realizar consultas em estruturas RDF (Resource Description Framework).
Antes de efetuar a consulta deve ativar o Reasoner HermiT.
Consulte em: https://www.w3.org/TR/sparql11-query/

## Antes de cada filtro devem ser declarados os recursos usados.

        1. Prefix owl:  <http://www.w3.org/2002/07/owl#>
        2. Prefix rdfs: <http://www.w3.org/2000/01/rdf-schema#>
        3. Prefix foaf: <http://xmlns.com/foaf/0.1/#>
        4. Prefix rdf:  <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
        5. Prefix xsd:  <http://www.w3.org/2001/XMLSchema#>
        6. Prefix skos: <http://www.w3.org/2004/02/skos/core#>
        7. Prefix dc:   <http://purl.org/dc/elements/1.1/>
        8. Prefix tem:  <http://www.w3.org/2006/time#>
        9. Prefix abnt: <https://jlmenegotto.wixsite.com/jlmenegotto-bim#>

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

        1.    Retorna só as instâncias que tenham códigos do SomaSUS com a sua descrição
        2.
        3.    SELECT ?ind ?d
        4.    WHERE
        5.    {   
        6.            ?ind rdf:type abnt:CódigoSUS .
        7.            ?ind abnt:descrição ?d .
        8.    }

## Exemplo 3: filtro SPARQL 

        1.    Retorna as subpropriedades de dados usadas em BIM.Data
        2.
        3.    SELECT ?d
        4.    WHERE
        5.    {   
        6.            ?d rdfs:subPropertyOf abnt:BIM.Data .
        7.    }
