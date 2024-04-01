## Ontologia dos bairros da cidade de Rio de Janeiro - Prefixo rioj:

Os arquivos Excel de esta pasta contêm o campo ontológico dos bairros de Rio de Janeiro. Tem os códigos das Areas de Planejamento e Regiões Administrativas.
Antes de executar filtros SPARQL em Protégé deve-se inicializar um Reasoner como HermiT.

Consulte em: https://www.w3.org/TR/sparql11-query/
### Arquivos
    1. Ontologia_V1_Projeto_Rio_de_Janeiro.dyn   (Função em Designscript para Revit 2024 que gera o arquivo OWL)
    2. Ontologia_V1_Projeto_Rio_de_Janeiro.owl   (Ontologia owl escrita em sintaxe Manchester)
    3. Ontologia_V1_Projeto_Rio_de_Janeiro.xlsx  (Campo ontológico de Instâncias de teste)
    4. Ontologia_V1_Projeto_Rio_de_Janeiro_Classes_Propriedades.xlsx (Campo ontológico com Classes e Propriedades e disjunções) 

## Exemplo 1 de filtro SPARQL 

        1.    A variável de sujeito ?s retorna o predicado de subpropriedades de dados usadas em BIM.Data
        2.
        3.    SELECT ?s
        4.    WHERE
        5.    {   
        6.            ?s rdfs:subPropertyOf rioj:BIM.Data .
        7.    }

## Exemplo 2 de filtro SPARQL 

        1.    A variável do objeto ?o retorna o predicado descrição, filtrando "Copa"
        2.
        3.    SELECT ?s ?o
        4.    WHERE
        5.    {   
        6.            ?s rioj:descrição ?o .
        7.            filter (contains (str (?o) , "Copa"))
        7.    }
        
## Exemplo 2 de filtro SPARQL 

        1.    A variável do objeto ?o retorna o predicado descrição, filtrando "Copa"
        2.
        3.    SELECT ?s ?d ?e
        4.    WHERE
        5.    {   
        6.            ?s rioj:é.dentro.de ?d . 
        6.            ?s rioj:descrição ?e .
        7.            filter (contains (str (?d) , "Rio"))
        8.    }

## Exemplo 3 de filtro SPARQL

![Sparql_01](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/0a1df997-bb93-4b06-ac53-9c87c1e9d790)
     
