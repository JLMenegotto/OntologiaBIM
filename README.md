# Ontologias BIM GIS
<sub> **_Prof. José Luis Menegotto._**</sub> 
+ <sub> **_DEG/POLI/UFRJ. Escola Politécnica da UFRJ._**</sub>
+ <sub> _PEU Programa de Pós-graduação em Engenharia Urbana_</sub>
+ <sub> _PPE Programa de Pós-graduação em Estruturas_</sub>
## 

### **Versão 2.00 Para Revit 2024**

Este é um trabalho acadêmico em desenvolvimento regularmente atualizado. As ontologias geradas em OWL e os arquivos excel que lhes dão origem são atualizados quando há mudanças na estruturação de classes e propriedades.

![OntoBIM_Manchester_2024](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/c43e6b33-1fc6-4a3e-b439-8111af74a6d7)

Ontologias modeladas em OWL permitem que tanto seres humanos como agentes algorítmicos possam ler e interpretar dados, favorecendo a conformação de ambientes integradores de processos. 

No projeto Ontologia BIM-GIS vem sendo implementado um construtor de ontologias com saida em formato OWL **(Ontology Web Language)**. O objetivo é integrar conhecimento em sistemas de dados abertos e conectados **(Open Linked Data)** em contextos de informação CAD-BIM-GIS. As ontologias são, de acordo com Gruber,
"uma especificação explicita de uma conceptualização". Dentro de nosso domínio de conhecimentos podem ser utilizadas para especificar explicitamente conceitos de projetos arquitetônicos e urbanos, seus elementos, os seus processos, etc. 
Podem ajudar na tarefa de integrar modelos de informação diferentes como IFC, Revit, CityGML, KML, OSM, etc. As descricões e axiomas definidos deveriam auxiliar a conhecer e acompanhar o projeto em todo o ciclo de vida.

O projeto parte da hipótese de que as tecnologias CAD-BIM-GIS somente serão integradas se o conhecimento projetual, acumulado ao longo dos anos, for expresso e ordenado em redes de dados abertos e conectados, segundo conceitualizou Tim Berners-Lee. Esse conceito permite montar uma infraestrutura digital compartilhada de conhecimentos. Portanto, se Normas Técnicas expressam o conhecimento industrial acumulado, deveriam ser estruturadas em ontologias de domínio específico e disponibilizadas de modo aberto. Os fluxos de dados, informaçoes e conhecimentos seriam beneficiados. Não seria esse um retorno do conhecimento às suas fontes? O construtor pretende ser uma contribuição para realizar este empreendimento.

O projeto sustenta que é altamente recomendável que ontologias OWL sejam desenvolvidas e publicadas de modo aberto por:

* _Organizações normativas como a ABNT, que sirvam de polo de irradiação do conhecimento industrial._
* _Catálogos de fabricantes, que conhecem os seus produtos e processos._
* _Códigos de Edificações e Regulamentos, que definem as vocações morfológicas das cidades._
* _Cada projeto novo construído, que traz consigo novos conhecimentos._
* _Cada projeto existente, que carrega conhecimentos latentes._

Estruturas axiomáticas ontológicas deveriam ser publicadas para melhorar os fluxos de verificação e validação de projetos num processo aberto que poderia acontecer sistematicamente de modo contínuo e permanente durante o projeto. 

+ **Fonte da Macro**  https://github.com/JLMenegotto/OntologiaBIM/tree/main/Dynamo
+ **Grafos Exemplo**  https://github.com/JLMenegotto/OntologiaBIM/tree/main/OWL 

Os arquivos OWL em sintaxe Manchester são criados a partir de uma conjunto estrururado de planilhas Excel e uma macro programada a medida em Designscript. As ontologias podem ser abertas no editor Protégé para visualizar, testar a axiomática e depurar a sua estruturação. Os módulos desenvolvidos devem ter um prefixo único (fofu: urba: rede: hid:) caracterizando Namespace do domínio específico axiomatizado (ambientes, esquadrias, SUSs, normas, etc).

### **Leitura e análise dos arquivos OWL em Protegé**

![Tela_Inicial](https://user-images.githubusercontent.com/9437020/226172682-0c1a09aa-7069-428d-a8b8-fe8abb9ea39c.PNG)

### Mais informaçoes sobre o tema no Livro: 
**_O modelo digital. Técnica e arte algorítmica em BIM._** 
https://www.amazon.com.br/Modelo-Digital-T%C3%A9cnica-Arte-Algor%C3%ADtmica/dp/6589367833/ref=zg_bs_g_7841300011_sccl_40/140-7766966-1834631?psc=1

### Consulte outros projetos em:

   1. **Acustica2024 e Parla:**         https://github.com/JLMenegotto/Acustica_2024
   2. **RIO**                           https://github.com/JLMenegotto/Rio
   3. **Promenade**                     https://github.com/JLMenegotto/Promenade
   4. **Sistemas Projetivos**           https://github.com/JLMenegotto/SistemasProjetivos
   5. **Atratores**                     https://github.com/JLMenegotto/Atratores
   6. **EGC**                           https://github.com/JLMenegotto/EGC
   7. **Funções Geométricas**           https://github.com/JLMenegotto/AulasBIM/tree/master/Dynamo/Geometricas
   8. **Funções de Análise de Lotes**   https://github.com/JLMenegotto/AulasBIM/tree/master/Dynamo/Lotes
   9. **Funções Obras Paradigmáticas**  https://github.com/JLMenegotto/AulasBIM/tree/master/Dynamo/Obras
  10. **Funções Gerais de Predios**     https://github.com/JLMenegotto/AulasBIM/tree/master/Dynamo/Predios
  11. **Funções Periódicas Temporais**  https://github.com/JLMenegotto/AulasBIM/tree/master/Dynamo/Relógio
  12. **Funções para Galpões**          https://github.com/JLMenegotto/AulasBIM/tree/master/Dynamo/Galpão
  13. **Funções para Treliças**         https://github.com/JLMenegotto/AulasBIM/tree/master/Dynamo/Treliças
  14. **Funções para Ambientes**        https://github.com/JLMenegotto/AulasBIM/tree/master/Dynamo/Rooms
  15. **Funções para Advance Steel**    https://github.com/JLMenegotto/AulasBIM/tree/master/AdvanceSteel   
  16. **Bibliografia e Material Complementar:** https://jlmenegotto.wixsite.com/jlmenegotto-bim
