# Construtor de Ontologias BIM GIS
<sub> **_Prof. José Luis Menegotto._**</sub> 
+ <sub> **_DEG/POLI/UFRJ. Escola Politécnica da UFRJ._**</sub>
+ <sub> _PEU Programa de Pós-graduação em Engenharia Urbana_</sub>
+ <sub> _PPE Programa de Pós-graduação em Estruturas_</sub>
## 

O construtor é atualizado regularmente. Embora o repositório mantenha todas as versões, a mais recente é a Versão 4.0. Nela poderá achar os arquivos Excell com a arquitetura proposta para a ontologia e os resultado OWL.

#### **Versão 1.00. Programada em Dynamo para Revit 2024**
<p align="justify">A versão 1.0 do Construtor foi programada em Designscript para rodar no ambiente Dynamo em Revit 2024. A versão le os arquivos Excel onde deve estar estruturado o campo ontológico do domínio tratado. O programa gera a ontologia em arquivo OWL escrito em sintaxe Manchester. Este é um trabalho acadêmico em contínuo desenvolvimento regularmente atualizado.</p>

 ![Ontologia_V1_Projeto_IFC4x3Add2_2024-04-07_02-48-29](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/322f892a-a07f-4c29-b807-b61174368bad)

#### **Versão 2.00. Programada para executar em Desktop Windows**
Na versão 2.0 foi modificada a estrutura dos arquivos Excel e incorporada a criação de arquivos em formato Turtle (ttl) simultamente aos arquivos OWL escritos em sintaxe Manchester.  
 - [Construtor Ontológico Versão 2.00 para a linha de Prompt de Windows](https://github.com/JLMenegotto/OntologiaBIM/tree/main/Vers%C3%A3o2)

#### **Versão 3.00. Programada para executar Revit como API**
- [Construtor Ontológico Versão 3.00 Revit API](https://github.com/JLMenegotto/OntologiaBIM/tree/main/Vers%C3%A3o3)
     
<p align="justify"> Ontologias modeladas em OWL permitem que tanto os seres humanos como os agentes algorítmicos possam ler e interpretar dados, favorecendo a conformação de ambientes integradores de processos. No projeto Ontologia BIM-GIS foi implementado um construtor de ontologias com saída em formato OWL <b>(Ontology Web Language)</b>. O objetivo é aumentar a integração entre o conhecimento produzido nos domínios CAD-BIM-GIS e a infraestrutura cognitiva digital da Web Semántica, dentro do paradigma de dados abertos e conectados <b>(Open Linked Data)</b>.<br></p>
 
<p align="justify"> As ontologias são, de acordo com Gruber, "uma especificação explicita de uma conceptualização". Dentro do domínio de conhecimentos AECO podem ser utilizadas para especificar explicitamente conceitos de projetos arquitetônicos e urbanos, seus elementos, os seus processos, etc. Podem ajudar na tarefa de integrar modelos de informação diferentes como IFC, Revit, CityGML, KML, OSM, etc. As descricões e axiomas definidos deveriam auxiliar projetistas e gestores a conhecer e acompanhar o projeto em todo o ciclo de vida. O projeto parte da hipótese de que as tecnologias CAD-BIM-GIS somente serão integradas se o conhecimento projetual, acumulado ao longo dos anos, for expresso e ordenado em redes de dados abertos e conectados, segundo conceitualizara Tim Berners-Lee. Esse conceito permite montar uma infraestrutura digital compartilhada de conhecimentos dentro da Web-semântica. Portanto, se as Normas Técnicas expressam o conhecimento industrial acumulado ao longo do tempo, seria conveniente traduzi-las em ontologias de domínio específico e disponibilizá-las de modo aberto e irrestrito para beneficiar os fluxos de dados, informações e conhecimentos. Não seria esse um retorno do conhecimento às suas fontes? O construtor pretende ser uma contribuição para realizar este empreendimento.</p>

O projeto sustenta que é altamente recomendável que ontologias OWL sejam desenvolvidas e publicadas de modo irrestrito por:

  * _Organizações normativas como a ABNT, que sirvam como silos abertos de irradiação do conhecimento industrial._
  * _Catálogos de fabricantes, que conhecem os seus produtos e processos._
  * _Códigos de Edificações e Regulamentos, que definem as vocações morfológicas das cidades._
  * _Cada projeto novo construído, que carrega implícito consigo novos conhecimentos._
  * _Cada projeto existente, que carrega conhecimentos latentes._

<p align="justify">Estruturas axiomáticas ontológicas deveriam ser publicadas para melhorar os fluxos de verificação e validação de projetos num processo aberto que poderia acontecer sistematicamente de modo contínuo e permanente durante o projeto. A evolução dos sistemas de produção de projetos indica que o paradigma de informação teria que ir se deslocando para um paradigma que coloque o conhecimento no início do processo de projeto. O seguinte projeto está inserido dentro do paradigma de modelação de dados conhecido como Neuro-Simbólica no qual  combinam-se técnicas de consultas a bases de conhecimentos baseadas em grafos, ML, LLM e consultas SPARQL.<br></p>  

<p align="justify">Para que todo o mecanismo de consulta funcione, um dos primeiros passos é possuir bases de conhecimentos formalizadas a partir de ontologias (a parte simbólica das técnicas). Essa é a função do construtor aquí apresentado. Os arquivos OWL em <b>sintaxe Manchester</b> são criados a partir de um conjunto de planilhas Excel estruturadas com o conteúdo do domínio e uma macro programada a medida em Designscript que lê as planilhas e escreve os arquivos OWL. Posteriormente, as ontologias podem ser abertas no editor Protégé para visualizar, testar e depurar a estrutura axiomática proposta. Os módulos desenvolvidos devem ter um prefixo único (fofu: urba: rede: hid:) caracterizando o Namespace do domínio axiomatizado (ambientes, esquadrias, SUS, normas, etc).<br></p> 

<p align="justify">A versão 2.0 do programa, foi preparada para rodar no Prompt do Windows e para produzir a saída da ontologia em formato Turtle (ttl)</p>

### **Exemplos com filtros SPARQL em plataforma Yasgui-Triply usando recursos RDF**

- [Veja exemplos de uso de tecnologia RDF](https://triplydb.com/JoseLuisMenegotto/-/overview)

### **Exemplos com filtros SPARQL em plataforma AllegroGraph usando recursos RDF**
### Nota:
          Como se trata de uma pesquisa acadêmica o servidor configurado utiliza uma   
          licença gratuita do AllegroGraph que deve ser reiniciada se permanecer  
          inativa por 12 hs. Caso a plataforma esteja fora do ar, retorne 
          mais tarde para fazer a consulta. 
 
- [Exemplo 01: Filtra Compartimentos](https://ag12pnceqjh5hmxu.allegrograph.cloud/webview/repositories/BIM/exec-query/anonymous/0bPosp-_jUoqS11H-tBo4/results?text=Select+%3Fcomp+%3Fnome+%3Fcod+%3Ftema+%3Fdes+%3Fem+%3Fcat+%3Fid+%3Farea%0AWhere%0A%7B%0A+++%3Fcomp+a+arq%3AQuarto%3B%0A+++++++++arq%3Atema+++++++++%3Ftema+%3B+%0A+++++++++arq%3Adescri%C3%A7%C3%A3o++++%3Fdes++%3B+%0A+++++++++arq%3A%C3%A9.dentro.de++%3Fem+++%3B%0A+++++++++arq%3A%C3%A9.categoria++%3Fcat++%3B%0A+++++++++arq%3Atem.ID+++++++%3Fid+++%3B%0A+++++++++arq%3A%C3%A1rea+++++++++%3Farea+%3B%0A+++++++++arq%3Anome+++++++++%3Fnome+%3B+++++++++++++++++%0A+++++++++arq%3Ac%C3%B3digo+++++++%3Fcod++.%0A%7D&language=SPARQL)

- [Exemplo 02: Filtra Salas](https://ag12pnceqjh5hmxu.allegrograph.cloud/webview/repositories/BIM/exec-query/anonymous/YNDFVHLWW1LzJKe5shtt5/results?text=select+%3Fem+%3Ftema+%3Fsala+%3Fcod+%3Fare%0Awhere+%0A%7B%0A+++%3Fsala+arq%3Ac%C3%B3digo+%3Fcod+%3B%0A+++++++++arq%3A%C3%A1rea+++%3Fare+%3B%0A+++++++++arq%3Atema+++%3Ftema%3B%0A+++++++++arq%3A%C3%A9.dentro.de+%3Fem.%0A%7D%0Aorder+by+%3Fem+%3Fare&language=SPARQL)

- [Exemplo 03: Filtra Códigos ABNT 15965](https://ag12pnceqjh5hmxu.allegrograph.cloud/webview/repositories/BIM/exec-query/anonymous/igfWPfdih3PkStlcIuNJX/results?text=SELECT+DISTINCT++%3Felem+%3Fcod+%3Fdescr+%0AWhere%0A%7B%0A++++++++%3Felem++abnt%3Ac%C3%B3digo-nbr+%3Fcod+%3B%0A+++++++++++++++abnt%3Adescri%C3%A7%C3%A3o+%3Fdescr.%0A%7D%0Aorder+by+%3Fcod&language=SPARQL)

- [Exemplo 04: Filtra Ambientes do SUS](https://ag12pnceqjh5hmxu.allegrograph.cloud/webview/repositories/BIM/exec-query/anonymous/eAkjEl3DoPRShdkKGrAHs/results?text=Select+distinct+%3Felem+%3Fsus+%3Fset+%3Fem%0AWhere%0A%7B%0A+++%3Felem++arq%3Adescri%C3%A7%C3%A3o++%3Fsus+.%0A+++filter+%28contains+%28str+%28%3Fsus%29%2C+%22SUS%22%29%29%0A%7D%0Aorder+by+%3Felem&language=SPARQL)

#### **Exemplos com filtros SPARQL em plataforma Stardog usando recursos RDF**

![Tela_Stardog_01](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/97afb135-f525-4887-a92f-cd68f006c1db)

- [Exemplo 01: Filtra Elementos IFC](https://cloud.stardog.com/share/fe71d0581acbde7b)

##### Mais informaçoes sobre o tema no Livro (Portugûes e español):
- [**_O modelo digital. Técnica e arte algorítmica em BIM._**](https://www.amazon.com.br/Modelo-Digital-T%C3%A9cnica-Arte-Algor%C3%ADtmica/dp/6589367833/ref=zg_bs_g_7841300011_sccl_40/140-7766966-1834631?psc=1)

- [**_El modelo digital. Técnica y arte algorítmica en BIM._**](https://bibliotecadigital.cp67.com/reader/el-modelo-digital-tecnica-y-arte-algoritmica-en-bim)

#### **Leitura e análise dos arquivos OWL em Protegé**
![Tela_Inicial](https://user-images.githubusercontent.com/9437020/226172682-0c1a09aa-7069-428d-a8b8-fe8abb9ea39c.PNG)

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
  17. [**Funções para torres:** Funções para Dynamo gerar estruturas verticais](https://github.com/JLMenegotto/AulasBIM/tree/master/Dynamo/Torres)
      
  18. [**Bibliografia**](https://jlmenegotto.wixsite.com/jlmenegotto-bim/pesquisa)
  19. [**Publicações**](https://jlmenegotto.wixsite.com/jlmenegotto-bim/jlm-public)
      
