# Construtor de Ontologias BIM GIS. Versão 5.00.
>**Prof. José Luis Menegotto**<br>
>**jlmenegotto@poli.ufrj.br**<br>
>Escola Politécnica da UFRJ - Departamento de Expressão Gráfica.<br>
>PEU Programa de Pós-graduação em Engenharia Urbana<br>
>PPE Programa de Pós-graduação em Estruturas<br>

## Observações 

<p align="justify">Na versão 5, foi alterada a organização das classes e adicionadas equivalências entre Classe IFC e Categorias Revit. Foram unificados os esquemas de classes e de instâncias. Foram destacadas as Propriedades de objetos e as Anotações personalizadas em um arquivo independente e comum a todas as ontologias. Os nomes foram organizados assim: <br></b></p>

  * **Ontologia_ + tema + .xlsx**
  * **Ontologia_ + tema + .owl**

## Capítulos de ontologias 

<p align="justify">Foram separados os seguintes domínios ontológicos<br></b></p>

  * Pasta **ABNT** aloca ontologias com o sistema de classificação da construção **NBR 15.965** ordenado seus códigos como Fatos conhecidos.
  * Pasta **AMBI** aloca ontologias com conceitos espaciais e Fatos conhecidos do **Instituto de Macromoléculas da UFRJ**.
  * Pasta **CROM** aloca ontologia con conceitos **cromáticos** e alguns Fatos conhecidos de paletas cromáticas. 
  * Pasta **CRON** aloca ontologia con conceitos **temporais** e Fatos conhecidos acerca de conceitos temporais. 
  * Pasta **CSUS** aloca ontologias com conceitos normativos e Fatos conhecidos do **Sistema Único de Saúde**, especificamente o caderno do SomaSUS.
  * Pasta **OBIM** aloca ontologia com conceitos de **objetos BIM**, com fatos conhecidos de categorias Revit e classes IFC.
  * Pasta **URBA** aloca ontologia com conceitos **Urbanos** e Fatos conhecidos da cidade de **Rio de janeiro**.
  * Pasta **DOCU** aloca ontologia com conceitos de **Documentação** e com alguns fatos conhecidos referentes a Leis e Decretos como exemplo.

<p align="justify">As Classes IFC e Categorias de Revit (OST_) foram ordenadas de modo a ter os conceitos comuns (colunas B C D E). Pode acontecer que algum conceito esteja presente num dos modelos de informação apenas. Na planilha de axiomas foram incorporadas colunas que definem Anotações sobre a Classe. Foi completada a tradução ao español de cada classe e categoria. O trabalho está em processo de desenvolvimento portanto, os arquivos no repositório são continuamente atualizados e as mudanças podem ser de diversos graus. <br></b></p>

Para abrir a ontologia pode-se baixar e instalar o editor [Protégé](https://protege.stanford.edu/) da Universidade de Stanford.

#### Instalação para executar em Revit como API 

 1. Criar as pastas  
      * **C:\APIBIM\Onto2025**  
      * **C:\APIBIM\Onto2025\Ico**  
 2. Colocar o arquivo **ONTOBIM_2025.dll** na pasta **C:\APIBIM\Onto2025**.  
 3. Os arquivos **Png** da pasta Ico devem ser colocadados em **C:\APIBIM\Onto2025\Ico**.  
 4. Criar a pasta **C:\Construtor_Onto** e as subpastas **ABNT, OBIM, CRONO, CROMA, CSUS e URBA** onde pode colocar os arquivos Excel de cada tema. Nessas pastas são criados os arquivos owl.  

#### Arquivo Addin para Revit
Incorporar o conteúdo do arquivo **ONTO2025.addin** na lista de aplicações do seu sistema. A pasta que contém do arquivo de addins é **C:\ProgramData\Autodesk\Revit\Addins\2024**. Caso decida instalar a API numa outra pasta da sua preferência, deverá alterar o caminho presente no conteúdo do arquivo ONTO2025.addin  

![Onto2025Addin](https://github.com/user-attachments/assets/902bcc39-1c02-4f54-a717-3bc361a255c1)

#### Estrutura de pastas
![Pastas](https://github.com/user-attachments/assets/bf1f353e-b34b-4bf3-b80d-db9a12ea78e5)

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

### Preenchimento do arquivo de Propriedades.
#### Adicionar ou mudar uma propriedade de Dado.

Um dos arquivos Excel contem a estrutura de propriedades de objetos e dados. A planilha deve ser preenchida utilizando a coluna G (SubData2) usanto o texto em minúscula e separando cada palavra da propriedade por um ponto separador. Quando a propriedade tiver mais de uma palavra elas não podem ser separadas por espaços vazios. A coluna F (SubData1) define a natureza da propriedade definida por um verbo e deve ser iniciada com o prefixo "d.".

#### Propriedades de Objeto.
As propriedades de objetos (colunas C e D) são construídas automaticamente a partir de fórmulas aplicadas nas colunas F e G. Elas trocam o prefixo d. por p. e agregam o prefixo "é."  
A coluna G tem uma regra de verificação de valores duplicados para ajudar a criar propriedades que não se repitam. 

#### Características das propriedades de Objeto.
A propriedade de objeto pode ser associada às características das colunas J a R. As características aplicadas às propriedades de objetos definem as possibilidades de inferência lógica que os Reasoners terão, esclarecendo que não todos os Reasoners podem processar todas as características.
Não pode ter células vazias. Colocar o valor null caso não queira definir a característica. 

  * **Functional**          Indica que deve ter, no máximo, um valor para cada sujeito. (exemplo: número de CPF).
  * **Inverse Functional**  Indica que tem muitos valores mas atribui apenas um valor unívoco para cada sujeito. (exemplo: carteira de CPF).
  * **Transitive**          é.dentro.de  é uma propriedade com característica de transitividade, pois se A é.dentro.de B e B é.dentro.de C é verdade que A e.dentro.de C.
  * **Symmetric**           ser.irmão.de é uma propriedade com característica simétrica, pois se A é.irmão.de B , também é verdade que B é.irmão.de A.
  * **Asymmetric**          é.avô.de     é uma propriedade com característica antisimétrica, pois se A é.avô.de B, não pode ser verdade que B é.avô.de de A. Evitam contradições entre individuos diferentes.
  * **Reflexive**           uma propriedade reflexiva indica uma relação que aponta também para o proprio indivíduo que a tem. (exemplo: é.igual.a é uma propriedade reflexiva). 
  * **Irreflexive**         uma propriedade irreflexiva indica que é sempre falso que um objeto se relacione a si mesmo com essa propriedade (exemplo: 'é.avô.de' é uma propriedade irreflexiva, pois ninguém pode ser avô de si mesmo). Evitam auto-relações inválidas.
  * **Inverse Of**	         uma propridade inversa indica que se um objeto A se relaciona com outro B por essa propriedade, então será verdade indicar que B se relaciona com A pela propriedade inversa (exemplo: se A é.acima de B é verdade, então B é.abaixo.de A também é verdade, pois a propriedade é.acima.de foi definida como a inversa da propriedade é.abaixo.de). 
    
![Properties_01](https://github.com/user-attachments/assets/ce6afebd-3a07-4fc3-97db-aeb2ca1bb944)

#### Colunas de explicações das propriedades de Objetos e Dados.  
As colunas U, V e W contem explicações relativas às propriedades definidas. As colunas U e V são preenchidas automaticamente. A coluna W deve ser preenchida manualmente, com comentários que expliquem de maneira objetiva e sucinta o significado da propriedades. Colocar referências às Normas que utilizam a propriedade ou explicações acerca de como ela adquire o seu valor pode ser útil.  
A coluna X identifica cada grupo de propriedades com um valor formado pelos 4 primeiros caracteres do grupo (lido da coluna F) e sequencialmente numerado desde 100. É utilizada para manter uma indexação para cada grupo.  
A coluna Y é reservada para futuro desenvolvimento.  

![Properties_02](https://github.com/user-attachments/assets/b93a281e-7e44-431f-ba12-45d427df0afd)

### Preenchimento do arquivo de Classes e Fatos de cada Domínio.
A planilha de classes define a estrutura hierárquica dos conceitos com as condições de existência. As classes são definidas em Maiúsculas com as palavras separadas por pontos. A coluna F que **não pode ter classes repetidas**, por isso essa coluna tem uma regra para verificar e destacar as células que sejam repetidas, situação que deverá se corrigida.  
As colunas G a K são utilizadas para colocar condições existenciais, que definam conceitos universais e particulares. Cada condição faz referência a uma ou mais condições de existência.

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

   *interpretação: (um bairro) é.dentro.de some Cidade  um Bairro é.dentro.de alguma Cidade.

As condições podem ser escritas concatenando condições de conjunções (and) ou disjunções (or). Essas afirmações agrupadas entre parênteses devem ser escritas deixando um espaço em branco depois de cada elemento da proposição. As condições expressam premisas válidas conhecidas.

     ( prop.ob1 some Classe ) and ( prop.ob2 some Classe )
   
![PreenchimentoClasses_01](https://github.com/user-attachments/assets/093cf0ea-58bd-41a0-bf63-cc977366bd44)

Durante a programação do construtor, procurou-se facilitar a escrita da ontologia eliminando a necessidade de colocar o namespace da ontologia antes dos nomes de classes e propriedades. No arquivo OWL gerado cada classe ou propriedade é precedida pelo namespace da ontologia (bim:Classe). Essa concatenação será feita automaticamente pelo aplicativo, permitindo que o usuário se concentre no trabalho de conceitualização de classes e propriedades.

As colunas L M N O são preenchidas automaticamente. A coluna P é preenchida manualmente com explicação clara e breve sobre o conteúdo da classe definida na coluna F. A coluna Q é a tradução a outro idioma do conteúdo da coluna P. Para preencher pode ser utilizada a fórmula:

    * =TRADUZIR(P20; "pt"; "es")

![PreenchimentoClasses_02](https://github.com/user-attachments/assets/a3748c49-8bfa-44e4-845d-30ab7c09f176)

### Preenchimento dos Fatos de cada Domínio.

Se as Classes e as Propriedades de Objetos e Dados definem o esquema abstrato dos conceitos, os Fatos descrevem realidades concretas conhecidas utilizando as definições de classes e propriedades. A coluna B da planilha de Fatos é utilizada para declarar um indivíduo (que pode ter qualquer nome sem espaços). A coluna C define o tipo de indivíduo que deve ser alguma classe existente. As colunas seguintes Azuis e verdes são utilizadas 
para descrever as propriedades de cada indivíduo. No momento o construtor limita a quantidade de propriedades a 10. Cada propriedade usa duas colunas, a primeira para colocar o nome da propriedade definido pelo esquema e a segunda para definir o seu valor. As propriedades de objetos relacionam as Classes com os Indivíduos ou Indivíduos entre se. As propriedades de dados qualificam os indivíduos. 
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

Os fatos conhecidos descrever a realidade concreta e são de dois tipos. 1) Fatos que são conhecidos e independentes de cualquer projeto. Podem descrever indivíduos que representam componentes de construção, normas técnicas, dados urbanos, restrições de regulamentos, etc.  
2) Indivíduos que descrevem a realidade do projeto. São formados pela descrição factual dos indivíduos extraídos desde o modelo BIM que está sendo construído. Neste aplicativo, o botão de extração está sendo preparado para executar a função de criação da ontologia do projeto a partir da leitura do modelo. 
