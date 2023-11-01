# Ontologias BIM GIS
<sub> **_Prof. José Luis Menegotto._**</sub> 
+ <sub> **_DEG/POLI/UFRJ. Escola Politécnica da UFRJ._**</sub>
+ <sub> _PEU Programa de Pós-graduação em Engenharia Urbana_</sub>
+ <sub> _PPE Programa de Pós-graduação em Estruturas_</sub>
## 

### **Versão 2.00 Para Revit 2024**

![OntoBIM_Manchester_2024](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/945e437f-32db-44be-b04e-ec7d19a2a3c3)

Ontologias modeladas em OWL permitem que tanto seres humanos e como agentes algorítmicos possam ler e interpretar dados, favorecendo a conformação de um ambiente integrado de processos. 

No projeto Ontologia BIM-GIS vem sendo implementado um construtor de ontologias com saida em formato OWL (Ontology Web Language). O objetivo é integrar conhecimento em sistemas de dados abertos e conectados (Open Linked Data) em contextos de informação BIM-GIS. As ontologias descrevem conceitualmente elementos de projetos arquitetônicos e urbanos e podem ser aproveitadas em todo o ciclo de vida dos empreendimentos. Ajudam a integrar modelos de informação diferentes como IFC, Revit, CityGML, KML, OSM, etc.

O projeto parte da hipótese de que as tecnologias CAD-BIM-GIS somente serão integradas se o conhecimento projetual, acumulado ao longo dos anos, for expresso e ordenado em redes de dados abertos e conectados, segundo conceitualizou Tim Berners-Lee. Esse conceito permite montar uma infraestrutura digital compartilhada de conhecimentos. Portanto, se Normas Técnicas expressam o conhecimento industrial acumulado, deveriam ser estruturadas em ontologias de domínio específico e disponibilizadas de modo aberto. Os fluxos de dados, informaçoes e conhecimentos seriam beneficiados. Não seria esse um retorno do conhecimento às suas fontes? O construtor pretende ser uma contribuição para realizar este empreendimento.

O projeto sustenta que é altamente recomendável que ontologias OWL sejam desenvolvidas e publicadas de modo aberto por:

* _Organizações normativas como a ABNT que acumulam o conhecimento industrial._
* _Fabricantes que conhecem os seus produtos e processos._
* _Códigos de Edificações e Regulamentos._
* _Cada projeto novo construído._

Estruturas axiomáticas ontológicas deveriam ser publicadas para melhorar os fluxos de verificação e validação de projetos num processo aberto que poderia acontecer sistematicamente de modo contínuo e permanente durante o projeto. 

+ **Fontes**     https://github.com/JLMenegotto/OntologiaBIM/tree/main/Dynamo
+ **Grafos**     https://github.com/JLMenegotto/OntologiaBIM/tree/main/OWL 

Os arquivos OWL em sintaxe Manchester são criados a partir de uma conjunto estrururado de planilhas Excel e uma macro programada a medida em Designscript. As ontologias podem ser abertas no editor Protégé para visualizar, testar a axiomática e depurar a sua estruturação. Os módulos desenvolvidos devem ter um prefixo único (fofu: urba: rede: hid:) caracterizando Namespace do domínio específico axiomatizado (ambientes, esquadrias, SUSs, normas, etc).

### **Leitura e análise dos arquivos OWL em Protegé**

![Tela_Inicial](https://user-images.githubusercontent.com/9437020/226172682-0c1a09aa-7069-428d-a8b8-fe8abb9ea39c.PNG)
