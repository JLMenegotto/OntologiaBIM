## Ontologia de conceitos de projeto HidroSanitário

Os arquivos Excel de esta pasta contêm o campo ontológico de conceitos para instalações hidrosanitárias para serem utilizados em projetos BIM.
Antes de executar filtros SPARQL em Protégé deve-se inicializar um Reasoner como HermiT.

### Arquivos
    1. Ontologia_V1_Projeto_HidroSanitário.dyn   (Função em Designscript para Revit 2024 que gera o arquivo OWL)
    2. Ontologia_V1_Projeto_HidroSanitário.owl   (Ontologia owl escrita em sintaxe Manchester)
    3. Ontologia_V1_Projeto_HidroSanitário.xlsx  (Campo ontológico de Instâncias de teste)
    4. Ontologia_V1_Projeto_HidroSanitário_Classes_Propriedades.xlsx (Campo ontológico com Classes e Propriedades e disjunções) 
    
![Grafo_ifc01](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/c2c42707-2733-46b4-9f89-fe624be9aa5d)

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

## Exemplo 3 de filtro SPARQL 

               1.    A variável do objeto ?o retorna o predicado descrição, filtrando "Equip"
               2.
               3.    SELECT ?s ?o
               4.    WHERE 
               5.    {   
               6.            ?s hidsan:descrição ?o .
               7.            filter (contains (str (?o) , "Equip"))
               8.    }
