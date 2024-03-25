## Ontologia de conceitos de projeto HidroSanitário

Os arquivos Excel de esta pasta contêm o campo ontológico de conceitos para instalações hidrosanitárias para serem utilizados em projetos BIM.
Antes de executar filtros SPARQL em Protégé deve-se inicializar um Reasoner como HermiT.

## Exemplo 1 de filtro SPARQL 

                1.    A variável de sujeito ?s retorna o predicado de subpropriedades de dados usadas em BIM.Data
                2.
                3.    SELECT ?s
                4.    WHERE
                5.    {   
                6.            ?s rdfs:subPropertyOf rioj:BIM.Data .
                7.    }

## Exemplo 2 de filtro SPARQL 

                1.    A variável do objeto ?o retorna o predicado descrição, filtrando "AguaFria"
                2.
                3.    SELECT ?s ?o
                4.    WHERE 
                5.    {   
                6.            ?s hidsan:descrição ?o .
                7.            filter (contains (str (?o) , "AguaFria"))
                8.    }
