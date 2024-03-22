## Arquivos com a Ontologia dos bairros da cidade de Rio de Janeiro

    Os arquivos Excel de esta pasta contêm o campo ontológico dos bairros de Rio de Janeiro
    Tem os códigos das Areas de Planejamento e Regiões Administrativas.

## Exemplo 1 de filtro SPARQL 

        1.    A variável de sujeito ?s retorna o predicado de subpropriedades de dados usadas em BIM.Data
        2.
        3.    SELECT ?s
        4.    WHERE
        5.    {   
        6.            ?s rdfs:subPropertyOf rioj:BIM.Data .
        7.    }

## Exemplo 2 de filtro SPARQL 

        1.    A variável do objeto ?o retorna o predicado descriçao, filtrando "Copa"
        2.
        3.    SELECT ?s ?o
        4.    WHERE
        5.    {   
        6.            ?s rioj:descrição ?o .
        7.            filter (contains (str (?o) , "Copa"))
        7.    }
