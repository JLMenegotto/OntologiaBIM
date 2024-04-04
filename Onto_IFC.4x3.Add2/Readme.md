## Ontologia de Classes IFC 4x3 Add 2 - Prefixo ifc:

Os arquivos Excel de esta pasta contêm o campo ontológico de conceitos para Classes IFC 4x3 Addendo 2 para serem utilizados em projetos BIM. 
Antes de executar filtros SPARQL em Protégé deve-se inicializar um Reasoner como HermiT.

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

![Grafo02](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/067846d7-6f47-407b-b5d2-2e34a57d8c69)

![Grafo01](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/42e0c5c1-7df8-445b-b510-36b57410b569)

![Grafo_02](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/02770766-8c73-4b16-bd3c-24ce56db1acd)

![Grafo_03](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/4f8e9b55-605f-45c7-970a-8da4fe1bfb38)

![Grafo_01](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/52c18d82-04a0-4de6-b48b-a7fee3906e9d)

