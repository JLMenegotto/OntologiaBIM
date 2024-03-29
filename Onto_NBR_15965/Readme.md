## Ontologias da Norma Brasileira NBR_15965 - Prefixo abnt:
Os arquivos Excel de esta pasta contêm o campo ontológico de cada parte da norma NBR 15965. 
As partes da norma NBR 15965 são: 0M, 0P, 1D, 1F, 1S, 2C, 2N, 2Q, 3E, 3R, 4A, 4U e 5I. 
Os arquivos 2Q, 4A, 4U e 5I também contêm os códigos dos Cadernos do SomaSUS.
O arquivo de classes e propriedades centraliza os conceitos utilizados em cada parte.

O aluno pode abrir o arquivo OWL num editor de texto ou no Editor Protégé e fazer a leitura do conteúdo que está em sintaxe Manchester.
No editor Protégé, pode aplicar filtros com a linguagem SPARQL, que permite realizar consultas em estruturas RDF (Resource Description Framework).
Antes de efetuar a consulta deve ativar o Reasoner HermiT.
Consulte em: https://www.w3.org/TR/sparql11-query/

## Exemplos de aplicação de filtros SPARQL para consultar conteúdos no OWL

    Neste caso são filtradas as descrições (variável ?d) que contenham a "ospit" e ordenadas pelo código (veriável ?x). 

![Sparql_01](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/fa7fc77b-3c65-4f24-84ff-c08f921ddc24)

    Neste caso são filtradas as instâncias (variável ?x) que contenham a "4U.02.10" e ordenadas pelo código (variável ?x). 

![Sparql_02](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/a3942060-e061-4d88-92a9-eabd24f6694e)

## Outros exemplos.
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
  
        1.    A variável ?obj retorna uma lista de materiais n1= 20 , n2= 10 nas colunas n1, n2 com 
        2.    a descrição do material (variáveis ?y ?p ?q)
        3.
        4.    SELECT ?obj ?y ?p ?q
        5.    WHERE
        6.    {   ?obj abnt:código-n1 "20" .
        7.        ?obj abnt:código-n2 "10" .
        8.        ?obj abnt:código-n1 ?y .
        9.        ?obj abnt:código-n2 ?p .
        10.        ?obj abnt:descrição ?q .
        11.    }

## Exemplo 2: filtro SPARQL 

        1.    A variável ?ind retorna só as instâncias que tenham códigos do SomaSUS e descrição da variável ?d contendo "Sala" 
        2.
        3.    SELECT ?ind ?d
        4.    WHERE
        5.    {   
        6.            ?ind rdf:type abnt:CódigoSUS .
        7.            ?ind abnt:descrição ?d .
        8.            FILTER (REGEX (STR (?ind) , "Sala"))
        9.    }

## Exemplo 3: filtro SPARQL 

        1.    A variável ?d retorna as subpropriedades de dados usadas em BIM.Data
        2.
        3.    SELECT ?d
        4.    WHERE
        5.    {   
        6.            ?d rdfs:subPropertyOf abnt:BIM.Data .
        7.    }

## Exemplo 4: filtro SPARQL 

        1.    A variável ?x retorna as instancias das Unidades funcionais 04 do SUS com a sua descrição (variável ?d) e as ordena
        2.
        3.    SELECT ?x ?d
        4.    WHERE
        5.    {   
        6.            ?x rdf:type abnt:CódigoSUS .
        7.            ?x abnt:descrição ?d .
        8.            FILTER (REGEX (STR (?x) , "UFU.04"))
        9.    }
       10.    ORDER BY ?x

