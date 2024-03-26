## Ontologia de conceitos de projeto de Ambientes

### Arquivos
    1. Ontologia_V1_Projeto_Ambientes.dyn
    2. Ontologia_V1_Projeto_Ambientes.owl
    3. Ontologia_V1_Projeto_Ambientes.xlsx
    4. Ontologia_V1_Projeto_Ambientes_Classes_Propriedades.xlsx

Os arquivos Excel de esta pasta contêm o campo ontológico de conceitos de Ambientes internos, externos e Mep para serem utilizados em projetos BIM.
Antes de executar filtros SPARQL em Protégé deve-se inicializar um Reasoner como HermiT.

Os ambientes foram divididos: 

    1. Ambientes Internos (Objetos OST_Rooms ou ifcSpace)
    2. Espaços Internos Mep (Objetos OST_MEPSpaces ou ifcSpatialZone)
    3. Áreas exteriores (Objetos de categoria OST_Areas ou ifcSpatialZone)
    4. Zonas (Objetos OST_HVAC_Zones ou ifcZone)
    
![Grafo_04](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/9b139e35-4c91-4480-a790-298d8c7d6b7c)

## Exemplo de filtro SPARQL 
A variável do objeto ?s retorna o predicado ?p com a descrição, filtrando os banheiros "Ban"

    1. Prefix owl:  <http://www.w3.org/2002/07/owl#>
    2. Prefix rdfs: <http://www.w3.org/2000/01/rdf-schema#>
    3. Prefix foaf: <http://xmlns.com/foaf/0.1/#>
    4. Prefix rdf:  <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
    5. Prefix xsd:  <http://www.w3.org/2001/XMLSchema#>
    6. Prefix skos: <http://www.w3.org/2004/02/skos/core#>
    7. Prefix dc:   <http://purl.org/dc/elements/1.1/>
    8. Prefix tem:  <http://www.w3.org/2006/time#>
    9. Prefix espa: <https://jlmenegotto.wixsite.com/jlmenegotto-bim#>
    
    10. Select *
    11. Where
    12. {
    13.       ?s espa:descrição ?p .
    14.       filter (contains (str (?p), "Ban"))
    15. }
    
