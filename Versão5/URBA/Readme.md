# Construtor de Ontologias BIM GIS. Versão 5.00.
>**Prof. José Luis Menegotto**<br>
>**jlmenegotto@poli.ufrj.br**<br>
>Escola Politécnica da UFRJ - Departamento de Expressão Gráfica.<br>
>PEU Programa de Pós-graduação em Engenharia Urbana<br>
>PPE Programa de Pós-graduação em Estruturas<br>

### Pasta URBA: Ontologia com os bairros da cidade de Rio de Janeiro.

<p align="justify">Foi alocada a ontologia com os conceitos urbanos e com fatos relacionados com a cidade de Rio de Janeiro. O arquivo Excel de esta pasta contêm o campo ontológico dos bairros de Rio de Janeiro, com os códigos das Areas de Planejamento e Regiões Administrativas. Antes de executar filtros SPARQL em Protégé deve-se inicializar um Reasoner como HermiT.<br></b></p>

<img width="1047" height="1472" alt="urba" src="https://github.com/user-attachments/assets/8a74239c-d7f7-46f7-90e4-6605a55ebcd2" />

Consulte em: https://www.w3.org/TR/sparql11-query/

#### Exemplo 1 de filtro SPARQL 

            A variável de sujeito ?s retorna o predicado de subpropriedades de dados usadas em BIMData

            Prefix owl:  <http://www.w3.org/2002/07/owl#>
            Prefix rdfs: <http://www.w3.org/2000/01/rdf-schema#>
            Prefix foaf: <http://xmlns.com/foaf/0.1/#>
            Prefix rdf:  <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
            Prefix xsd:  <http://www.w3.org/2001/XMLSchema#>
            Prefix skos: <http://www.w3.org/2004/02/skos/core#>
            Prefix dc:   <http://purl.org/dc/elements/1.1/>
            Prefix tem:  <http://www.w3.org/2006/time#>
            Prefix bim:  <https://github.com/JLMenegotto/RepoOnto#>

            SELECT ?s
            WHERE
            {   
                    ?s rdfs:subPropertyOf bim:BIMData .
            }

#### Exemplo 2 de filtro SPARQL 

            A variável do objeto ?o retorna o predicado descrição, filtrando "Copa"
            
            Prefix owl:  <http://www.w3.org/2002/07/owl#>
            Prefix rdfs: <http://www.w3.org/2000/01/rdf-schema#>
            Prefix foaf: <http://xmlns.com/foaf/0.1/#>
            Prefix rdf:  <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
            Prefix xsd:  <http://www.w3.org/2001/XMLSchema#>
            Prefix skos: <http://www.w3.org/2004/02/skos/core#>
            Prefix dc:   <http://purl.org/dc/elements/1.1/>
            Prefix tem:  <http://www.w3.org/2006/time#>
            Prefix bim:  <https://github.com/JLMenegotto/RepoOnto#>
            
            SELECT ?s ?o
            WHERE
            {   
                    ?s bim:descrição ?o .
                    filter (contains (str (?o) , "Copa"))
            }
        
#### Exemplo 2 de filtro SPARQL 

            A variável do objeto ?o retorna o predicado descrição, filtrando "Copa"
            
            Prefix owl:  <http://www.w3.org/2002/07/owl#>
            Prefix rdfs: <http://www.w3.org/2000/01/rdf-schema#>
            Prefix foaf: <http://xmlns.com/foaf/0.1/#>
            Prefix rdf:  <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
            Prefix xsd:  <http://www.w3.org/2001/XMLSchema#>
            Prefix skos: <http://www.w3.org/2004/02/skos/core#>
            Prefix dc:   <http://purl.org/dc/elements/1.1/>
            Prefix tem:  <http://www.w3.org/2006/time#>
            Prefix bim:  <https://github.com/JLMenegotto/RepoOnto#>
            
            SELECT ?s  ?d  ?e
            WHERE
            {   
                   ?s  bim:é_dentro_de ?d . 
                   ?s  bim:descrição   ?e .
                   filter (contains (str (?d) , "Rio"))
           }

#### Exemplo 3 de filtro SPARQL

![Sparql_01](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/0a1df997-bb93-4b06-ac53-9c87c1e9d790)
