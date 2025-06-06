# Construtor de Ontologias BIM GIS
>**Prof. José Luis Menegotto**<br>
>**jlmenegotto@poli.ufrj.br**<br>
>Escola Politécnica da UFRJ - Departamento de Expressão Gráfica.<br>
>PEU Programa de Pós-graduação em Engenharia Urbana<br>
>PPE Programa de Pós-graduação em Estruturas<br>
## 

O construtor é atualizado regularmente. Ainda que no repositório sejam mantidas todas as versões, a Versão 5.0 é a mais recente. Nela poderá encontrar os arquivos Excel contendo a última arquitetura de conceitos propuesta para a ontologia. Os resultado em formato OWL (sintaxe Mancheste) e ttl (formato Turtle) se encontram na pasta junto aos arquivos Excel. Não foram incorporados nessa pasta novos filtros em SPARQL, estes podem ser consultados nas pastas das versões anteriores.<br>
Cada ontologia tem a data e hora da sua criação registrada.

### [Versão5.00 do Construtor](https://github.com/JLMenegotto/OntologiaBIM/tree/main/Vers%C3%A3o5)

<p align="justify">Apesar da proliferação de agentes e plataformas de IA, é ainda uma necessidade investir em organizar e vincular grandes quantidades de dados. Uma forma de realizar essa tarefa é organizando os dados em <b>Grafos de Conhecimentos</b>, dentro do conceito de Dados Abertos e Conectados. Os grafos podem ser Grafos de propriedades ou, Grafos de conhecimento. A adoção dessas tecnologias contribui a melhorar os processos de manutenção predial, que podem passar a ser menos corretivos e mais preditivos, em outras palavras, uma manutenção menos reativa e mais responsiva.<br></b></p>

<p align="justify">Ontologias modeladas em OWL permitem que tanto os seres humanos como os agentes algorítmicos possam ler e interpretar dados, favorecendo a conformação de ambientes integradores de processos. No projeto Ontologia BIM-GIS foi implementado um construtor de ontologias com saída em formato OWL <b>(Ontology Web Language)</b>. O objetivo é aumentar a integração entre o conhecimento produzido nos domínios CAD-BIM-GIS e a infraestrutura cognitiva digital da Web Semántica, dentro do paradigma de dados abertos e conectados <b>(Open Linked Data).<br></b></p>
 
<p align="justify"> As ontologias são, de acordo com Gruber, "uma especificação explicita de uma conceptualização". Dentro do domínio de conhecimentos AECO podem ser utilizadas para especificar explicitamente conceitos de projetos arquitetônicos e urbanos, seus elementos, os seus processos, etc. Podem ajudar na tarefa de integrar modelos de informação diferentes como IFC, Revit, CityGML, KML, OSM, etc. As descricões e axiomas definidos deveriam auxiliar projetistas e gestores a conhecer e acompanhar o projeto em todo o ciclo de vida. O projeto parte da hipótese de que as tecnologias CAD-BIM-GIS somente serão integradas se o conhecimento projetual, acumulado ao longo dos anos, for expresso e ordenado em redes de dados abertos e conectados, segundo conceitualizara Tim Berners-Lee. Esse conceito permite montar uma infraestrutura digital compartilhada de conhecimentos dentro da Web-semântica. Portanto, se as Normas Técnicas expressam o conhecimento industrial acumulado ao longo do tempo, seria conveniente traduzi-las em ontologias de domínio específico e disponibilizá-las de modo aberto e irrestrito para beneficiar os fluxos de dados, informações e conhecimentos. Não seria esse um retorno do conhecimento às suas fontes? O construtor pretende ser uma contribuição para realizar este empreendimento.</p>

O projeto sustenta que é altamente recomendável que ontologias OWL sejam desenvolvidas e publicadas de modo irrestrito por:

  * _Organizações normativas como a ABNT, que sirvam como silos abertos de irradiação do conhecimento industrial._
  * _Catálogos de fabricantes, que conhecem os seus produtos e processos._
  * _Códigos de Edificações e Regulamentos, que definem as vocações morfológicas das cidades._
  * _Cada projeto novo construído, que carrega implícito consigo novos conhecimentos._
  * _Cada projeto existente, que carrega conhecimentos latentes._

<p align="justify">Estruturas axiomáticas ontológicas deveriam ser publicadas para melhorar os fluxos de verificação e validação de projetos num processo aberto que poderia acontecer sistematicamente de modo contínuo e permanente durante o projeto. A evolução dos sistemas de produção de projetos indica que o paradigma de informação teria que ir se deslocando para um paradigma que coloque o conhecimento no início do processo de projeto. O seguinte projeto está inserido dentro do paradigma de modelação de dados conhecido como Neuro-Simbólica no qual  combinam-se técnicas de consultas a bases de conhecimentos baseadas em grafos, ML, LLM e consultas SPARQL.<br></p>  

<p align="justify">Para que todo o mecanismo de consulta funcione, um dos primeiros passos é possuir bases de conhecimentos formalizadas a partir de ontologias (a parte simbólica das técnicas). Essa é a função do construtor aquí apresentado. Os arquivos OWL em <b>sintaxe Manchester</b> são criados a partir de um conjunto de planilhas Excel estruturadas com o conteúdo do domínio e uma macro programada a medida em Designscript que lê as planilhas e escreve os arquivos OWL. Posteriormente, as ontologias podem ser abertas no editor Protégé para visualizar, testar e depurar a estrutura axiomática proposta. Os módulos desenvolvidos devem ter um prefixo único (fofu: urba: rede: hid:) caracterizando o Namespace do domínio axiomatizado (ambientes, esquadrias, SUS, normas, etc).<br></p> 

#### **Versão 1.00. Programada em Dynamo para Revit 2024**
<p align="justify">A versão 1.0 do Construtor foi programada em Designscript para rodar no ambiente Dynamo em Revit 2024. A versão le os arquivos Excel onde deve estar estruturado o campo ontológico do domínio tratado. O programa gera a ontologia em arquivo OWL escrito em sintaxe Manchester. Este é um trabalho acadêmico em contínuo desenvolvimento regularmente atualizado.</p>

 ![Ontologia_V1_Projeto_IFC4x3Add2_2024-04-07_02-48-29](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/322f892a-a07f-4c29-b807-b61174368bad)

#### **Versão 5.00 Programada em C# como API de Revit****
<p align="justify">Na versão 5.0, foram reorganizados os conceitos nos arquivos Excel e os diversos dominios estudados foram alinhados.</p>

- [Construtor Ontológico Versão 5.00](https://github.com/JLMenegotto/OntologiaBIM/tree/main/Vers%C3%A3o5)

<hr/>

### **Exemplos de uso de ontologia como recurso RDF aplicando filtros SPARQL em plataforma Yasgui-Triply**

- [Veja exemplos de uso de tecnologia RDF](https://triplydb.com/JoseLuisMenegotto/-/overview)

### **Exemplos de uso de ontologia como recurso RDF aplicando filtros SPARQL em plataforma AllegroGraph**

          Nota: o servidor do AllegroGraph foi configurado com uma licença acadêmica gratuita.  
          Se ele permanecer inativo por 8 hs, o servidor pausa até ser reinicializado.  
          Caso a plataforma esteja fora do ar, retorne mais tarde para fazer a consulta.   
 
- [Exemplo 01: Filtra Ambientes IMA](https://ag12pnceqjh5hmxu.allegrograph.cloud/webview/repositories/Centro_de_Tecnologia/exec-query/anonymous/Sd_CNI8TtRDgvESIDjg_H/results?text=select+%3Fs+%3Fp+%3Fd+%3Fa%0Awhere+%0A%7B%0A+++%3Fs+a+bim%3AAmbiente+%3B%0A++++++++bim%3A%C3%A9.dentro.de+%3Fp+%3B%0A++++++++bim%3Anome+%3Fd+%3B%0A++++++++bim%3A%C3%A1rea+%3Fa+.%0A++++++++filter+%28contains+%28str+%28%3Fp%29%2C+%22Macro%22%29%29+%0A%7D%0Aorder+by+%3Fa&language=SPARQL)


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
      
