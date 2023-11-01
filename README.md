# Ontologias BIM GIS
<sub> **_Prof. José Luis Menegotto._**</sub> 
+ <sub> **_DEG/POLI/UFRJ. Escola Politécnica da UFRJ._**</sub>
+ <sub> _PEU Programa de Pós-graduação em Engenharia Urbana_</sub>
+ <sub> _PPE Programa de Pós-graduação em Estruturas_</sub>
## 

### **Versão 2.00 Para Revit 2024**
![OntoBIM_Manchester_2024](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/945e437f-32db-44be-b04e-ec7d19a2a3c3)

Ontologias modeladas em OWL permitem que tanto seres humanos e como agentes algorítmicos possam ler e interpretar dados, portanto conformar um ambiente integrado de processos. No projeto Ontologia BIM-GIS é implementado um construtor de módulos ontológicos com saida em formato OWL. O objetivo é integrar conhecimento em sistemas de dados abertos e conectados (Open Linked Data) dentro de contextos de informação da construção ou geográficos. Os módulos descrevem conceitualmente elementos de projetos arquitetônicos e urbanos. Podem ser aproveitados em todas as etapas de projetos, da concepão à operação. Procura-se integrar categorias e enumerações de esquemas de dados diferentes como IFC, Revit, CityGML, KML, OSM, etc. 

O projeto parte da hipótese de que as tecnologias CAD-BIM-GIS poderão ser melhor integradas se o conhecimento projetual, que vai sendo acumulado ao longo dos anos, for expresso e ordenado em redes de dados abertos e conectados, segundo conceitualizou Tim Berners-Lee. Esse conceito permite montar uma infraestrutura digital compartilhada de conhecimentos. Portanto, se Normas Técnicas expressam o conhecimento industrial acumulado ao longo dos anos, por que não o estruturá-las em ontologias de domínio específico e colocá-las a disposição de modo irrestrito? Os fluxos de dados, informaçoes e conhecimentos seriam beneficiados. Não seria esse um retorno do conhecimento às suas fontes? O construtor visa aportar uma contribuição para este empreendimento.

+ **Fontes**     https://github.com/JLMenegotto/OntologiaBIM/tree/main/Dynamo
+ **Grafos**     https://github.com/JLMenegotto/OntologiaBIM/tree/main/OWL 

É altamente recomendável que ontologias OWL sejam desenvolvidas e publicadas de modo aberto por :

* Organizações normativas como a ABNT; 
* Fabricantes, que conhecem melhor os seus produtos e processos;
* Códigos de Edificações e Regulamentos
* Cada projeto construído.

Estruturas axiomáticas ontológicas devem ser publicadas para melhorar os fluxos de verificação e validação de projetos num processo aberto que poderia acontecer sistematicamente de modo contínuo e permanente durante o projeto.

Os arquivos OWL, escritos em sintaxe Manchester, são criados modularmente a partir de planilhas Excel e uma macro programada a medida em Designscript. As ontologias podem ser abertas no editor Protégé para visualizar, gerenciar ou depurar a sua estruturação. Os módulos desenvolvidos tem prefixo fofu: (significando forma e função). Estão divididos em domínios específicos (ambiente, esquadria, SUS, normas, etc). As determinações ontológicas procuram fazer o alinhamento dos módulos para que possam ser importados evitando-se ou minimizando as sobreposições e ambiguidades conceituais. Ontologias direcionadas ao GIS poderão ter prefixos como urba: rede: hid: que caracterizem o Namespace do domínio modelado.

### **Leitura e análise dos arquivos OWL em Protegé**

![Tela_Inicial](https://user-images.githubusercontent.com/9437020/226172682-0c1a09aa-7069-428d-a8b8-fe8abb9ea39c.PNG)
