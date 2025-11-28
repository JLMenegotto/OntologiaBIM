# Construtor de Ontologias BIM GIS. Versão 5.00.
>**Prof. José Luis Menegotto**<br>
>**jlmenegotto@poli.ufrj.br**<br>
>Escola Politécnica da UFRJ - Departamento de Expressão Gráfica.<br>
>PEU Programa de Pós-graduação em Engenharia Urbana<br>
>PPE Programa de Pós-graduação em Estruturas<br>

## API do Construtor 

Os arquivos necessários para a instalação do construtor de ontologias BIM estão na pasta **API**.    

## Observações 

<p align="justify">Na versão 5, foi alterada a organização das classes e adicionadas equivalências entre Classe IFC e Categorias Revit. Foram unificados os esquemas de classes e de instâncias. Foram destacadas as Propriedades de objetos e as Anotações personalizadas em um arquivo independente e comum a todas as ontologias. Os nomes foram organizados assim: <br></b></p>

  * **Ontologia_ + tema + .xlsx**
  * **Ontologia_ + tema + .owl**

## Domínios ontológicos 

<p align="justify">Foram separados os seguintes domínios ontológicos<br></b></p>

  * Pasta **ABNT** aloca ontologias com o sistema de classificação da construção **NBR 15.965** ordenado seus códigos como Fatos conhecidos.
  * Pasta **AMBI** aloca ontologias com conceitos espaciais e Fatos conhecidos do **Instituto de Macromoléculas da UFRJ**.
  * Pasta **CROM** aloca ontologia con conceitos **cromáticos** e alguns Fatos conhecidos de paletas cromáticas. 
  * Pasta **CRON** aloca ontologia con conceitos **temporais** e Fatos conhecidos acerca de conceitos temporais. 
  * Pasta **CSUS** aloca ontologias com conceitos normativos e Fatos conhecidos do **Sistema Único de Saúde**, especificamente o caderno do
    SomaSUS.
  * Pasta **INFR** aloca ontologia com conceitos **Infraestrutura** e Fatos conhecidos da cidade de **Rio de janeiro** ou de instituições como o   	INMET.
  * Pasta **DOCU** aloca ontologia com conceitos de **Documentação** e com alguns fatos conhecidos referentes a Leis e Decretos como exemplo.
  * Pasta **META** aloca ontologia com conceitos de **Estrutura Metálica** e com alguns fatos conhecidos referentes a catálogo de perfis   			laminados.
  * Pasta **TUBO** aloca ontologia com conceitos de **Tubulações** e com alguns fatos conhecidos referentes a catálogo de fabricantes do setor.
  * Pasta **VANT** aloca ontologia com conceitos de **Veículos Aereos não Tripulados** e com alguns fatos conhecidos referentes a processos de
    manutenção predial que utilizam drones para inspeção e aquisição de imagens.
  * Pasta **ARQU** aloca ontologia com conceitos de **Arquitetura** e com alguns fatos conhecidos.
  * Pasta **TASB** aloca ontologia com conceitos da **Taxonomia Sustentável Brasileira** com fatos conhecidos.  
  - ![Ver_Pasta](https://github.com/JLMenegotto/OntologiaBIM/tree/main/Vers%C3%A3o5/TASB)
  * Pasta **VEGE** aloca ontologia com conceitos de **Vegetação** com conhecimento utilizado em projetos paisagísticos.

<p align="justify">As Classes IFC e Categorias de Revit (OST_) foram ordenadas de modo a ter os conceitos comuns (colunas B C D E). Pode acontecer que algum conceito esteja presente num dos modelos de informação apenas. Na planilha de axiomas foram incorporadas colunas que definem Anotações sobre a Classe. Foi completada a tradução ao español de cada classe e categoria. O trabalho está em processo de desenvolvimento portanto, os arquivos no repositório são continuamente atualizados e as mudanças podem ser de diversos graus. <br></b></p>

Para abrir a ontologia pode-se baixar e instalar o editor [Protégé](https://protege.stanford.edu/) da Universidade de Stanford.

##### Instalação para executar em Revit como API 

Na última versão da API foi modificada a arquitetura do processamento das planilhas obtendo um ganho de performance.

##### Estrutura de pastas
 1. Criar as pastas  
      * **C:\APIBIM\Onto2025**  
      * **C:\APIBIM\Onto2025\Ico**  
 2. Colocar o arquivo **ONTOBIM_2025.dll** na pasta **C:\APIBIM\Onto2025**.  
 3. Os arquivos **Png** da pasta Ico devem ser colocadados em **C:\APIBIM\Onto2025\Ico**.  
 4. Criar a pasta **C:\Construtor_Onto**
 5. Dentro de **C:\Construtor_Onto** criar as subpastas **ABNT, ARQU, CROM, CRON, CSUS, DOCU, INFR, META, TUBO, VANT, VEGE** onde pode colocar os arquivos Excel de cada tema. Nessas pastas são criados os arquivos owl.  

![Pastas](https://github.com/user-attachments/assets/bf1f353e-b34b-4bf3-b80d-db9a12ea78e5)

#### Arquivo Addin para Revit
Incorporar o conteúdo do arquivo **ONTO2025.addin** na lista de aplicações do seu sistema. A pasta que contém do arquivo de addins é **C:\ProgramData\Autodesk\Revit\Addins\2024**. Caso decida instalar a API numa outra pasta da sua preferência, deverá alterar o caminho presente no conteúdo do arquivo ONTO2025.addin  

![Onto2025Addin](https://github.com/user-attachments/assets/902bcc39-1c02-4f54-a717-3bc361a255c1)

#### Interface:
![Interface_2025](https://github.com/user-attachments/assets/3138138d-e57c-48d6-9ee2-128024440999)

<p align="justify">O botão <b>Criar</b> executa a construção da ontologia especificada no campo 1. O botão <b>Extrair</b> executa uma função ainda não liberada para uso que extrai os fatos ontológicos do modelo BIM utilizando os esquemas criados. Nos campos de temas 1 e 2 são especificados os domínios das ontologias que serão criadas. Segue a lista de valores numéricos permitidos.<br></b></p>

    * 0  Processa os Objetos_BIM de Revit e Ifc 
    * 1  Processa ABNT 15965_0M
    * 2  Processa ABNT 15965_0P
    * 3  Processa ABNT 15965_1D 
    * 4  Processa ABNT 15965_1F
    * 5  Processa ABNT 15965_1S
    * 6  Processa ABNT 15965_2C
    * 7  Processa ABNT 15965_2N
    * 8  Processa ABNT 15965_2Q
    * 9  Processa ABNT 15965_3E
    * 10 Processa ABNT 15965_3R
    * 11 Processa ABNT 15965_4A
    * 12 Processa ABNT 15965_4U                                                      
    * 13 Processa ABNT 15965_5I                                                     
    * 14 Processa CSUS_2Q Caderno SomaSUS (Equipamentos)                                                   
    * 15 Processa CSUS_4A Caderno SomaSUS (Ambientes)                                                            
    * 16 Processa CSUS_4U Caderno SomaSUS (Unidades Funcionais)                                                    
    * 17 Processa CSUS_5I Caderno SomaSUS (Volumes)                                                     
    * 18 Processa Conceitos urbanos URBA_Rio                                                 
    * 19 Processa Conceitos temporais CRONO                                             
    * 20 Processa Conceitos cromáticos CROMA 
    * 21 Processa Conceitos documentação DOCUM 

#### Prompt de execução
Durante a execução é informado o andamento la linha de Prompt de Revit.

![Iface2](https://github.com/user-attachments/assets/78d6d549-5189-4757-89c7-174a65a926e9)

### Preenchimento do arquivo de Propriedades (atualmente 1536 propriedades)
#### Adicionar ou mudar uma propriedade de Dado.

Um dos arquivos Excel contem a estrutura de propriedades de objetos e dados. Ele é atualizado com regularidade pela incorporação de novas propriedades, pela modificação das características de propriedades existentes ou pelo reagrupamento de uma propriedade dentro de outra SubProp1 e SubData1 (colunas C e F). A planilha deve ser preenchida utilizando a coluna G (SubData2) usanto o texto em minúscula e separando cada palavra da propriedade por um ponto separador. Quando a propriedade tiver mais de uma palavra elas não podem ser separadas por espaços vazios. A coluna F (SubData1) define a natureza da propriedade definida por um verbo e deve ser iniciada com o prefixo "d.".

#### Propriedades de Objeto.
As propriedades de objetos (colunas C e D) são construídas automaticamente a partir de fórmulas aplicadas nas colunas F e G. Elas trocam o prefixo d. por p. e agregam o prefixo "é."  
A coluna G tem uma regra de verificação de valores duplicados para ajudar a criar propriedades que não se repitam. 

#### Características das propriedades de Objeto.
A possibilidade de inferência que tem uma ontologia, depende da exploração das características das propriedades de objeto, que podem ou não ser definidas a critério do usuário. A sua presença ou ausência definirá a capacidade que a ontologia terá para inferir fatos verdadeiros. Cada propriedade de objeto pode ser associada às características listadas nas colunas J a R da planilha. As características aplicadas às propriedades de objetos definem as possibilidades de inferência lógica que os Reasoners terão, esclarecendo que não todos os Reasoners podem processar todas as características. Não pode ter células vazias. Colocar o valor null caso não queira definir a característica. A seguir o significado de cada tipo de característica.

  * **Functional**         Indica que a propriedade deve ter, no máximo, um valor único para cada sujeito. (exemplo: data de nascimento).
  * **Inverse Functional** Indica que o valor da propriedade é unívoco entre sujeito e predicado. (exemplo: um número de CPF identifica como máximo uma pessoa).
  * **Transitive**         é.dentro.de  é uma propriedade com característica de transitividade, pois se A é.dentro.de B e B é.dentro.de C é verdade que A e.dentro.de C.
  * **Symmetric**          ser.irmão.de é uma propriedade com característica simétrica, pois se A é.irmão.de B , também é verdade que B é.irmão.de A.
  * **Asymmetric**         é.avô.de     é uma propriedade com característica antisimétrica, pois se A é.avô.de B, não pode ser verdade que B é.avô.de de A. Evitam contradições entre individuos diferentes.
  * **Reflexive**          Uma propriedade reflexiva indica uma relação que aponta também para o proprio indivíduo que a tem. (exemplo: é.igual.a é uma propriedade reflexiva). 
  * **Irreflexive**        Uma propriedade irreflexiva indica que é sempre falso que um objeto se relacione a si mesmo com essa propriedade (exemplo: 'é.avô.de' é uma propriedade irreflexiva, pois ninguém pode ser avô de si mesmo). Evitam auto-relações inválidas.
  * **Inverse Of**	   Uma propridade inversa indica que se um objeto A se relaciona com outro B por essa propriedade, então será verdade indicar que B se relaciona com A pela propriedade inversa (exemplo: se A é.acima de B é verdade, então B é.abaixo.de A também é verdade, pois a propriedade é.acima.de foi definida como a inversa da propriedade é.abaixo.de). 
    
![Properties_01](https://github.com/user-attachments/assets/ce6afebd-3a07-4fc3-97db-aeb2ca1bb944)

#### Colunas de explicações das propriedades de Objetos e Dados.  
As colunas U, V e W contem explicações relativas às propriedades definidas. As colunas U e V são preenchidas automaticamente. A coluna W deve ser preenchida manualmente, com comentários que expliquem de maneira objetiva e sucinta o significado da propriedades. Colocar referências às Normas que utilizam a propriedade ou explicações acerca de como ela adquire o seu valor pode ser útil.  
A coluna X identifica cada grupo de propriedades com um valor formado pelos 4 primeiros caracteres do grupo (lido da coluna F) e sequencialmente numerado desde 100. É utilizada para manter uma indexação para cada grupo.  
A coluna Y é reservada para futuro desenvolvimento.  

![Properties_02](https://github.com/user-attachments/assets/b93a281e-7e44-431f-ba12-45d427df0afd)

### Preenchimento do arquivo de Classes e Fatos de cada Domínio.
A planilha de classes define a estrutura hierárquica dos conceitos com as condições existenciais. As classes devem ser definidas iniciando em letra Maiúscula com os termos separados por pontos. A coluna F **não pode ter classes repetidas**. Essa coluna tem uma regra para verificar e destacar as células repetidas, situação que deverá ser corrigida.  
As colunas G a K são utilizadas para colocar condições existenciais, que definam a universalidade ou particularidade do conceito. Cada condição faz referência a uma ou mais condições de existência.

   * some
   * only
   * or
   * and
   * max
   * min
   * exactly
   * not

Exemplo 1: a classe **Red** que é subclasse de **Canal** tem uma condição definida utilizando a propriedade de objeto **é.red**, configurada para ter um valor mínimo de 0 e um valor máximo de 255.

   * é.red min 0 , é.red max 255 

Exemplo 2: para uma classe **Bairro** (na coluna F) a condição é declarada na coluna K. Ela afirma com a propriedade de objeto **é.dentro.de**, associada existencialmente como **some** à classe **Cidade**.

   *interpretação: (um bairro) é.dentro.de some Cidade  um Bairro é dentro de alguma Cidade.

As condições podem ser escritas concatenando condições de conjunções (and) ou disjunções (or). Essas afirmações agrupadas entre parênteses devem ser escritas deixando um espaço em branco depois de cada elemento da proposição. As condições expressam premisas válidas conhecidas.

     ( prop.ob1 some Classe ) and ( prop.ob2 some Classe )
   
![PreenchimentoClasses_01](https://github.com/user-attachments/assets/093cf0ea-58bd-41a0-bf63-cc977366bd44)

Durante a programação do construtor, procurou-se facilitar a escrita da ontologia eliminando a necessidade de colocar o namespace da ontologia antes dos nomes de classes e propriedades. No arquivo OWL gerado cada classe ou propriedade é precedida pelo namespace da ontologia (bim:Classe). Essa concatenação será feita automaticamente pelo aplicativo, permitindo que o usuário se concentre no trabalho de conceitualização de classes e propriedades.

As colunas L M N O são preenchidas automaticamente. A coluna P é preenchida manualmente com explicação clara e breve sobre o conteúdo da classe definida na coluna F. A coluna Q é a tradução a outro idioma do conteúdo da coluna P. Para preencher pode ser utilizada a fórmula:

    * =TRADUZIR(P20; "pt"; "es")

Ainda que tenha utilizado a fórmula sugerida para traduzir o texto, não esqueça que os sistemas de tradução podem falhar na interpretação por utilizar um domínio semántico diferente ao da construção. Revise sempre as traduções feitas pelo mecanismo tradutor.   

![PreenchimentoClasses_02](https://github.com/user-attachments/assets/53a13c2d-0785-42f0-a99a-2ff6cb988db8)

### Preenchimento dos Fatos de cada Domínio.

Se as Classes e as Propriedades de Objetos e Dados definem o esquema abstrato dos conceitos, os Fatos descrevem realidades concretas conhecidas utilizando as definições de classes e propriedades. A coluna B da planilha de Fatos é utilizada para declarar um indivíduo (que pode ter qualquer nome sem espaços). A coluna C define o tipo de indivíduo que deve ser associado a alguma classe existente. As colunas seguintes, nas cores azul ou verde, são utilizadas para descrever as propriedades de cada indivíduo. No momento, o construtor limita em 10 propriedades atribuidas a cada indivíduo. Cada propriedade usa duas colunas, a primeira para colocar o nome da propriedade definido pelo esquema e a segunda para definir o seu valor. As propriedades de objetos relacionam as Classes com os Indivíduos ou Indivíduos entre si. As propriedades de dados qualificam os indivíduos. 
Os indivíduos são conhecimentos factuais, representam a descrição de fatos válidos. Por exemplo, todos os códigos da NBR 15.965 são fatos válidos.  

![Fatos_01](https://github.com/user-attachments/assets/570183c0-e2e8-450c-8804-72fd646f9707)

Em sintaxe Manchester um indivíduo tem a seguinte leitura:  

   	*  Individual: bim:1F.10.14.15   
	*      Types: bim:Código  
	*      Facts: bim:norma  "NBR 15.965"  
	*      Facts: bim:parte  "Parte 3"  
	*      Facts: bim:tema  "1F"  
	*      Facts: bim:descrição  "Fase de pesquisa"  

 Quando o fato faz a referência a uma Classe, Propriedade ou Indivíduo é precedido pelo prefixo do namespace da ontologia (bim:). Pode haver algumas declarações como SameAs:  

   	*  Individual: bim:Copacabana    
	*      Types: bim:Bairro  
	*      Facts: bim:é.dentro.de  bim:RA.05  
	*      SameAs: bim:B.024  
	*      Facts: bim:é.região.administrativa  bim:RA.05  
	*      Facts: bim:é.dentro.de  bim:Zona.Sul  
	*      Facts: bim:descrição  "Bairro N° B.024 RA.05 Copacabana"  

Os fatos conhecidos descrevem a realidade concreta e são de dois tipos. 1) Fatos que são conhecidos e independentes de cualquer projeto. Eles podem descrever indivíduos que representam componentes de construção, normas técnicas, dados urbanos concretos, restrições presentes em regulamentos, etc.

	*  Fabricantes de componentes podem publicar ontologias de seus produtos, descrevendo indivíduos do catálogo de produtos.    
 	*  A prefeitura de uma cidade, pode publicar ontologias descrevendo os diversos aspectos urbanos conhecidos.  
  	*  O corpo de bombeiros poderia descrever situações espaciais a levar em conta no projeto ontologizando o conhecimento.  
   	*  A ABNT poderia descrever uma normativa.  

2) O segundo tipo de Indivíduos descreve a realidade do projeto. A realidade do projeto é factualmente descrita por indivíduos extraídos desde o modelo BIM que está sendo concebido. Neste aplicativo, o botão de extração está sendo preparado para executar a função de criação da ontologia do projeto a partir da leitura do modelo.


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
