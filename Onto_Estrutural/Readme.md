## Ontologia de projeto Estrutural - Prefixo est:

Os arquivos Excel de esta pasta contêm o campo ontológico de conceitos para projeto estrutural para serem utilizados em projetos BIM.
Antes de executar filtros SPARQL em Protégé deve-se inicializar um Reasoner como HermiT.

Consulte em: https://www.w3.org/TR/sparql11-query/
### Arquivos
    1. Ontologia_V1_Projeto_Estrutural.dyn   (Função em Designscript para Revit 2024 que gera o arquivo OWL)
    2. Ontologia_V1_Projeto_Estrutural.owl   (Ontologia owl escrita em sintaxe Manchester)
    3. Ontologia_V1_Projeto_Estrutural.xlsx  (Campo ontológico de Instâncias de teste)
    4. Ontologia_V1_Projeto_Estrutural_Classes_Propriedades.xlsx (Campo ontológico com Classes e Propriedades e disjunções) 
    
### Observações
As instâncias da ontologia (Individual) têm a finalidade de testar a consistência das classes e propriedades. 
Os indivíduos e os fatos associados devem ser criados a partir da leitura de um modelo BIM.

### Grafos de exemplo 

![Grafo_Fundação](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/cfae505e-4043-4795-b4ae-ada78c02faed)

![Grafo_Coluna](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/45ac6635-7893-4f6e-a5cf-dca1c89c3357)

![Grafo_Viga](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/4d1368d1-5715-45f2-9970-3c61267cbbe4)

![Grafo_Laje](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/c8782d54-057e-4382-947d-933d19b400cd)
