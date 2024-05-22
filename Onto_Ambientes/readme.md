## Ontologia de projeto Espacial - Prefixo espa:
Os arquivos Excel de esta pasta contêm o campo ontológico de conceitos de Ambientes internos, externos e Mep para serem utilizados em projetos BIM.
Antes de executar filtros SPARQL em Protégé deve-se inicializar um Reasoner como HermiT. 

Consulte em: https://www.w3.org/TR/sparql11-query/

### Arquivos
    1. Ontologia_V1_Projeto_Ambientes.dyn   (Função em Designscript para Revit 2024 que gera o arquivo OWL)
    2. Ontologia_V1_Projeto_Ambientes.owl   (Ontologia owl escrita em sintaxe Manchester)
    3. Ontologia_V1_Projeto_Ambientes.xlsx  (Campo ontológico de Instâncias de teste)
    4. Ontologia_V1_Projeto_Ambientes_Classes_Propriedades.xlsx (Campo ontológico com Classes e Propriedades e disjunções) 

Os elementos de ambientes foram divididos: 

    1. Ambientes Internos (Objetos OST_Rooms ou ifcSpace)
    2. Espaços Internos Mep (Objetos OST_MEPSpaces ou ifcSpatialZone)
    3. Áreas exteriores (Objetos de categoria OST_Areas ou ifcSpatialZone)
    4. Zonas (Objetos OST_HVAC_Zones ou ifcZone)

### Observações
As instâncias da ontologia (Individual) têm a finalidade de testar a consistência das classes e propriedades. 
Os indivíduos e os fatos associados devem ser criados a partir da leitura de um modelo BIM.

### Grafo de exemplo 
![Grafo_04](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/9b139e35-4c91-4480-a790-298d8c7d6b7c)

### Exemplo de filtro SPARQL 
A variável do sujeito ?suj retorna os objetos ?obj usando o predicado espa:descrição e filtrando os quartos "Quarto"

    1. Prefix owl:  <http://www.w3.org/2002/07/owl#>
    2. Prefix rdfs: <http://www.w3.org/2000/01/rdf-schema#>
    3. Prefix foaf: <http://xmlns.com/foaf/0.1/#>
    4. Prefix rdf:  <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
    5. Prefix xsd:  <http://www.w3.org/2001/XMLSchema#>
    6. Prefix skos: <http://www.w3.org/2004/02/skos/core#>
    7. Prefix dc:   <http://purl.org/dc/elements/1.1/>
    8. Prefix tem:  <http://www.w3.org/2006/time#>
    9. Prefix espa: <https://jlmenegotto.wixsite.com/jlmenegotto-bim#>
    
    10. Select ?suj ?obj 
    11. Where
    12. {
    13.       ?suj espa:descrição ?obj .
    14.       filter (contains (str (?obj), "Quarto"))
    15. }

- [Veja os filtros em AllegroGraph ](https://ag132vl3gqf5dw9c.allegrograph.cloud/webview/repositories/OBIM/exec-query/anonymous/sa6FJP-X4BPF_g530CfyR/results?text=Select+%3Fs+%3Fo+%0A++++Where%0A++++%7B%0A+++++++++++%3Fs++arq%3Adescri%C3%A7%C3%A3o+%3Fo+.%0A+++++++++++filter+%28contains+%28str+%28%3Fo%29%2C+%22Quarto%22%29%29+%0A++++%7D&language=SPARQL)

 
