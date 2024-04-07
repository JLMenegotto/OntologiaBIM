## Ontologia de Classes IFC 4x3 Add 2 - Prefixo ifc:

Os arquivos Excel de esta pasta contêm o campo ontológico de conceitos para Classes IFC 4x3 Addendo 2 para serem utilizados em projetos BIM. 
Antes de executar filtros SPARQL em Protégé deve-se inicializar um Reasoner como HermiT. Os termos dos tipos enumerados em IFC foram traduzidos ao português
e colocados no DataProperty "tradução".

Consulte em: https://www.w3.org/TR/sparql11-query/

### Arquivos
    1. Ontologia_V1_Projeto_IFC.4x3.Add2.dyn   (Função em Designscript para Revit 2024 que gera o arquivo OWL)
    2. Ontologia_V1_Projeto_IFC.4x3.Add2.owl   (Ontologia owl escrita em sintaxe Manchester)
    3. Ontologia_V1_Projeto_IFC.4x3.Add2.xlsx  (Campo ontológico de Instâncias de teste)
    4. Ontologia_V1_Projeto_IFC.4x3.Add2_Classes_Propriedades.xlsx (Campo ontológico com Classes e Propriedades e disjunções) 

### Observações

As instâncias da ontologia (Individual) têm a finalidade de testar a consistência das classes e propriedades. 
Os indivíduos e os fatos associados devem ser criados a partir da leitura de um modelo BIM.

## Exemplo de filtro SPARQL 
A variável do objeto ?s retorna o predicado ?p com as subclasses e filtrando as portas "Door"

    1. Prefix owl:  <http://www.w3.org/2002/07/owl#>
    2. Prefix rdfs: <http://www.w3.org/2000/01/rdf-schema#>
    3. Prefix foaf: <http://xmlns.com/foaf/0.1/#>
    4. Prefix rdf:  <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
    5. Prefix xsd:  <http://www.w3.org/2001/XMLSchema#>
    6. Prefix skos: <http://www.w3.org/2004/02/skos/core#>
    7. Prefix dc:   <http://purl.org/dc/elements/1.1/>
    8. Prefix tem:  <http://www.w3.org/2006/time#>
    9. Prefix ifc:  <https://jlmenegotto.wixsite.com/jlmenegotto-bim#>
    
    10. Select *
    11. Where
    12. {
    13.       ?p rdfs:subClassOf ?s .
    14.       filter (contains (str (?s), "Door"))
    15. }
    
### Grafos de exemplo
![Grafo_00](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/92861f76-811c-41e2-8f3e-d736ef23b317)

![Grafo_05](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/ef8e0938-dba5-4c92-82a7-8e9a801a058d)
![Grafo_04](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/49f6d511-d42d-434b-983a-a13ce7ca2075)
![Grafo_03](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/6a92bb0b-b6b1-4c14-af31-5374f7645f41)
![Grafo_02](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/4cec6e03-98b6-447e-a3e0-b91b90517440)
![Grafo_01](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/c97d5c89-7e59-4813-8614-33a55e88da1c)



