# Construtor de Ontologias BIM GIS. Versão 5.00.
>**Prof. José Luis Menegotto**<br>
>**jlmenegotto@poli.ufrj.br**<br>
>Escola Politécnica da UFRJ - Departamento de Expressão Gráfica.<br>
>PEU Programa de Pós-graduação em Engenharia Urbana<br>
>PPE Programa de Pós-graduação em Estruturas<br>

### Pasta URBA: Ontologia com os bairros da cidade de Rio de Janeiro - Prefixo rio:

<p align="justify">Foi alocada a ontologia com os conceitos urbanos e com fatos relacionados com a cidade de Rio de Janeiro. O arquivo Excel de esta pasta contêm o campo ontológico dos bairros de Rio de Janeiro, com os códigos das Areas de Planejamento e Regiões Administrativas. Antes de executar filtros SPARQL em Protégé deve-se inicializar um Reasoner como HermiT.<br></b></p>

![Urba_01](https://github.com/user-attachments/assets/dfb8546b-2683-4715-a6f5-4653078b23d0)

Consulte em: https://www.w3.org/TR/sparql11-query/

#### Exemplo 1 de filtro SPARQL 

            A variável de sujeito ?s retorna o predicado de subpropriedades de dados usadas em BIMData
            SELECT ?s
            WHERE
            {   
                    ?s rdfs:subPropertyOf rio:BIMData .
            }

#### Exemplo 2 de filtro SPARQL 

            A variável do objeto ?o retorna o predicado descrição, filtrando "Copa"
            SELECT ?s ?o
            WHERE
            {   
                    ?s rio:descrição ?o .
                    filter (contains (str (?o) , "Copa"))
            }
        
#### Exemplo 2 de filtro SPARQL 

            A variável do objeto ?o retorna o predicado descrição, filtrando "Copa"
            SELECT ?s  ?d  ?e
            WHERE
            {   
                   ?s  rio:é_dentro_de ?d . 
                   ?s  rio:descrição   ?e .
                   filter (contains (str (?d) , "Rio"))
           }

#### Exemplo 3 de filtro SPARQL

![Sparql_01](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/0a1df997-bb93-4b06-ac53-9c87c1e9d790)
