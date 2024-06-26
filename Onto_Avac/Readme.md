## Ontologia de projeto Aquecimento, ventilação e Ar condicionado - Prefixo avac:

Os arquivos Excel de esta pasta contêm o campo ontológico de conceitos para projeto de instalações de Aquecimento, ventilação e 
Ar condicionado para serem utilizados em projetos BIM. Antes de executar filtros SPARQL em Protégé deve-se inicializar um Reasoner como HermiT.

Consulte em: https://www.w3.org/TR/sparql11-query/

### Arquivos
    1. Ontologia_V1_Projeto_Avac.dyn   (Função em Designscript para Revit 2024 que gera o arquivo OWL)
    2. Ontologia_V1_Projeto_Avac.owl   (Ontologia owl escrita em sintaxe Manchester)
    3. Ontologia_V1_Projeto_Avac.xlsx  (Campo ontológico de Instâncias de teste)
    4. Ontologia_V1_Projeto_Avac_Classes_Propriedades.xlsx (Campo ontológico com Classes e Propriedades e disjunções) 

### Observações

As instâncias da ontologia (Individual) têm a finalidade de testar a consistência das classes e propriedades. 
Os indivíduos e os fatos associados devem ser criados a partir da leitura de um modelo BIM.

### Grafos de exemplo
![GrafoAvac_ost](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/41346e2f-c1d1-44ad-b049-0b983d04c4c0)

![GrafoAvac_ifc](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/911b80c2-b60b-42dc-9ec8-a3b5c30d81ae)

