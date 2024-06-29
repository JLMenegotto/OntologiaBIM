# Ontologias BIM GIS
<sub> **_Prof. José Luis Menegotto._**</sub> 
+ <sub> **_DEG/POLI/UFRJ. Escola Politécnica da UFRJ._**</sub>
+ <sub> _PEU Programa de Pós-graduação em Engenharia Urbana_</sub>
+ <sub> _PPE Programa de Pós-graduação em Estruturas_</sub>
## 
#### **Versão 1.00 Para Revit 2024**

Este é um trabalho acadêmico em desenvolvimento regularmente atualizado. O repositório contem as funções Designscript desenvolvidas para gerar as ontologias em OWL. Os arquivos OWL gerados e as planilhas excel utilizadas para organizar o campo ontológico de cada domínio podem ser usados como exemplo para que o interessado possa formalizar a sua ontologia.

![Ontologia_V1_Projeto_IFC4x3Add2_2024-04-07_02-48-29](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/322f892a-a07f-4c29-b807-b61174368bad)

Ontologias modeladas em OWL permitem que tanto os seres humanos como os agentes algorítmicos possam ler e interpretar dados, favorecendo a conformação de ambientes integradores de processos. No projeto Ontologia BIM-GIS foi implementado um construtor de ontologias com saída em formato OWL **(Ontology Web Language)**. O objetivo é aumentar a integração entre o conhecimento produzido nos domínios CAD-BIM-GIS e a infraestrutura cognitiva digital da Web Semántica, dentro do paradigma de dados abertos e conectados **(Open Linked Data)**. 
As ontologias são, de acordo com Gruber, "uma especificação explicita de uma conceptualização". Dentro do domínio de conhecimentos AECO podem ser utilizadas para especificar explicitamente conceitos de projetos arquitetônicos e urbanos, seus elementos, os seus processos, etc. Podem ajudar na tarefa de integrar modelos de informação diferentes como IFC, Revit, CityGML, KML, OSM, etc. As descricões e axiomas definidos deveriam auxiliar projetistas e gestores a conhecer e acompanhar o projeto em todo o ciclo de vida.

O projeto parte da hipótese de que as tecnologias CAD-BIM-GIS somente serão integradas se o conhecimento projetual, acumulado ao longo dos anos, for expresso e ordenado em redes de dados abertos e conectados, segundo conceitualizara Tim Berners-Lee. Esse conceito permite montar uma infraestrutura digital compartilhada de conhecimentos dentro da Web-semântica. Portanto, se Normas Técnicas expressam o conhecimento industrial acumulado ao longo do tempo, creio que deveriam ser estruturadas em ontologias de domínio específico e disponibilizadas de modo aberto e irrestrito para beneficiar os fluxos de dados, informações e conhecimentos. Não seria esse um retorno do conhecimento às suas fontes? O construtor pretende ser uma contribuição para realizar este empreendimento.

O projeto sustenta que é altamente recomendável que ontologias OWL sejam desenvolvidas e publicadas de modo irrestrito por:

* _Organizações normativas como a ABNT, que sirvam de polo de irradiação do conhecimento industrial._
* _Catálogos de fabricantes, que conhecem os seus produtos e processos._
* _Códigos de Edificações e Regulamentos, que definem as vocações morfológicas das cidades._
* _Cada projeto novo construído, que carrega implícito consigo novos conhecimentos._
* _Cada projeto existente, que carrega conhecimentos latentes._

Estruturas axiomáticas ontológicas deveriam ser publicadas para melhorar os fluxos de verificação e validação de projetos num processo aberto que poderia acontecer sistematicamente de modo contínuo e permanente durante o projeto. A evolução dos sistemas de produção de projetos indica que o paradigma de informação teria que ir se deslocando para um paradigma que coloque o conhecimento no início do processo de projeto. 

Os arquivos OWL em **sintaxe Manchester** são criados a partir de uma conjunto estrururado de planilhas Excel e uma macro programada a medida em Designscript. As ontologias podem ser abertas no editor Protégé para visualizar, testar a axiomática e depurar a sua estruturação. Os módulos desenvolvidos devem ter um prefixo único (fofu: urba: rede: hid:) caracterizando o Namespace do domínio axiomatizado (ambientes, esquadrias, SUS, normas, etc).

### **Leitura e análise dos arquivos OWL em Protegé**
![Tela_Inicial](https://user-images.githubusercontent.com/9437020/226172682-0c1a09aa-7069-428d-a8b8-fe8abb9ea39c.PNG)

#### **Exemplos com filtros SPARQL em plataforma AllegroGraph usando recursos RDF**
- [Exemplo 01: Filtra Compartimentos](https://ag12pnceqjh5hmxu.allegrograph.cloud/webview/repositories/BIM/exec-query/anonymous/0bPosp-_jUoqS11H-tBo4/results?text=Select+%3Fcomp+%3Fnome+%3Fcod+%3Ftema+%3Fdes+%3Fem+%3Fcat+%3Fid+%3Farea%0AWhere%0A%7B%0A+++%3Fcomp+a+arq%3AQuarto%3B%0A+++++++++arq%3Atema+++++++++%3Ftema+%3B+%0A+++++++++arq%3Adescri%C3%A7%C3%A3o++++%3Fdes++%3B+%0A+++++++++arq%3A%C3%A9.dentro.de++%3Fem+++%3B%0A+++++++++arq%3A%C3%A9.categoria++%3Fcat++%3B%0A+++++++++arq%3Atem.ID+++++++%3Fid+++%3B%0A+++++++++arq%3A%C3%A1rea+++++++++%3Farea+%3B%0A+++++++++arq%3Anome+++++++++%3Fnome+%3B+++++++++++++++++%0A+++++++++arq%3Ac%C3%B3digo+++++++%3Fcod++.%0A%7D&language=SPARQL)

- [Exemplo 02: Filtra Salas](https://ag12pnceqjh5hmxu.allegrograph.cloud/webview/repositories/BIM/exec-query/anonymous/YNDFVHLWW1LzJKe5shtt5/results?text=select+%3Fem+%3Ftema+%3Fsala+%3Fcod+%3Fare%0Awhere+%0A%7B%0A+++%3Fsala+arq%3Ac%C3%B3digo+%3Fcod+%3B%0A+++++++++arq%3A%C3%A1rea+++%3Fare+%3B%0A+++++++++arq%3Atema+++%3Ftema%3B%0A+++++++++arq%3A%C3%A9.dentro.de+%3Fem.%0A%7D%0Aorder+by+%3Fem+%3Fare&language=SPARQL)

- [Exemplo 03: Filtra Códigos ABNT 15965](https://ag12pnceqjh5hmxu.allegrograph.cloud/webview/repositories/BIM/exec-query/anonymous/igfWPfdih3PkStlcIuNJX/results?text=SELECT+DISTINCT++%3Felem+%3Fcod+%3Fdescr+%0AWhere%0A%7B%0A++++++++%3Felem++abnt%3Ac%C3%B3digo-nbr+%3Fcod+%3B%0A+++++++++++++++abnt%3Adescri%C3%A7%C3%A3o+%3Fdescr.%0A%7D%0Aorder+by+%3Fcod&language=SPARQL)

#### **Exemplos com filtros SPARQL em plataforma STARDOG usando recursos RDF**
- [Exemplo 01: Filtros na ontologia Ifc432.Domínio.7 em StarDog](https://cloud.stardog.com/share/eec9366729d3113d)

##### Mais informaçoes sobre o tema no Livro:
- [**_O modelo digital. Técnica e arte algorítmica em BIM._**](https://www.amazon.com.br/Modelo-Digital-T%C3%A9cnica-Arte-Algor%C3%ADtmica/dp/6589367833/ref=zg_bs_g_7841300011_sccl_40/140-7766966-1834631?psc=1)

## 
[**Canal YouTube:** Videos com explicação dos conteúdos e metodologias das funções](https://www.youtube.com/channel/UCCN58u2BP38F09aswlJrILA)
#### **Consulte outros projetos**
  
   1. [**OntologiaBIM:** Construtor de ontologias OWL](https://github.com/JLMenegotto/OntologiaBIM)
   2. [**Acustica2024 e Parla:** Integração do Simulador Acústico BRASS com Revit](https://github.com/JLMenegotto/Acustica_2024)
   3. [**RIO:** Reformatação de acervos digitais](https://github.com/JLMenegotto/Rio)
   4. [**Promenade:** Sistema IoT para microlocalização](https://github.com/JLMenegotto/Promenade)
   5. [**Sistemas Projetivos:** Funções para o ensino de Geometria Descritiva em Revit](https://github.com/JLMenegotto/SistemasProjetivos)
   6. [**Atratores:** Funções AutoLISP para geração de pontos](https://github.com/JLMenegotto/Atratores)
   7. [**EGC:** Funções em AutoLISP para representação e formalização do projeto](https://github.com/JLMenegotto/EGC)
   8. [**Funções Geométricas:** Funções Dynamo para geometria plana](https://github.com/JLMenegotto/AulasBIM/tree/master/Dynamo/Geometricas)
   9. [**Funções de Análise de Lotes:** Funções Dynamo para o projeto conceptual a partir do lote](https://github.com/JLMenegotto/AulasBIM/tree/master/Dynamo/Lotes)
  10. [**Funções Obras Paradigmáticas:** Funções Dynamo de projetos paradigmáticos]( https://github.com/JLMenegotto/AulasBIM/tree/master/Dynamo/Obras)
  11. [**Funções Gerais de Predios:** Funções Dynamo para automatizar o projeto](https://github.com/JLMenegotto/AulasBIM/tree/master/Dynamo/Predio)
  12. [**Funções Periódicas Temporais:** Funções Dynamo para trabalhar com o tempo](https://github.com/JLMenegotto/AulasBIM/tree/master/Dynamo/Relógio)
  13. [**Funções para Galpões:** Funções Dynamo para automatizar o projeto de Gapões de aço](https://github.com/JLMenegotto/AulasBIM/tree/master/Dynamo/Galpão)
  14. [**Funções para Treliças:** Funções Dynamo para automatizar o projeto de treliças](https://github.com/JLMenegotto/AulasBIM/tree/master/Dynamo/Treliças)
  15. [**Funções para Ambientes:** Funções Dynamo para automatizar o projeto a partir do objeto Room em Revit](https://github.com/JLMenegotto/AulasBIM/tree/master/Dynamo/Rooms)
  16. [**Funções para Advance Steel:** Funções para gerar perfis customizados em AdvanceSteel](https://github.com/JLMenegotto/AulasBIM/tree/master/AdvanceSteel)
      
  17. [**Bibliografia**](https://jlmenegotto.wixsite.com/jlmenegotto-bim/pesquisa)
  18. [**Publicações**](https://jlmenegotto.wixsite.com/jlmenegotto-bim/jlm-public)
      
