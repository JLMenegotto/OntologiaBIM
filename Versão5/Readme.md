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
Um dos arquivos Excel contem a estrutura de propriedades de objetos e dados. A planilha deve ser preenchida utilizando a coluna G (SubData2)
em minúscula e separando cada palavra da propriedade utilizando um ponto como separador. Quando a propriedade tiver mais de uma palavra não podem ser separadas por espaços vazios. A coluna F (SubData1) define a natureza da propriedade e deve ser iniciada com o prefixo "d.".
As propriedades de objetos são construídas automaticamente a partir de fórmulas aplicadas às colunas F e G. Elas trocam o prefixo d. por p. e agregam o prefixo "é."  
A coluna G tem uma regra de verificação de valores duplicados para ajudar a criar propriedades que não se repitam. A propriedade de objeto pode ser associada às características das colunas J a R. As características aplicadas às propriedades de objetos definem as possibilidades de inferência lógica que os Reasoners terão, esclarecendo que não todos os Reasoners podem processar todas as características.
Não pode ter células vazias. Colocar o valor null caso não queira definir a característica. 

  * **Functional**          Indica que deve ter, no máximo, um valor para cada sujeito. (por exemplo, número de CPF).
  * **Inverse Functional**  Indica que tem muitos valores mas atribui apenas um valor para cada sujeito. (por exemplo, carteira de CPF).
  * **Transitive**          é.dentro.de  é uma propriedade com característica de transitividade, pois se A é.dentro.de B e B é.dentro.de C é verdade que A e.dentro.de C.
  * **Symmetric**           ser.irmão.de é uma propriedade com característica de simetria, pois se A é.irmão.de B , também é verdade que B é.irmão.de A.
  * **Asymmetric**          é.avô.de     é uma propriedade com caractéristica de antisimetria, pois se A é.avô.de B, não pode ser verdade que B é.avô.de de A.
  * **Reflexive**           uma propriedade reflexiva indica uma relação que aponta também para o proprio indivíduo que a tem. (exemplo é.igual.a é uma propriedade reflexiva). 
  * **Irreflexive**         uma propriedade irreflexiva indica que é sempre falso que um objeto se relacione a si mesmo com essa propriedade. (exemplo é.avô.de é uma propriedade irreflexiva).
  * **Inverse Of**	
  * **Equivatent**
    
![Properties_01](https://github.com/user-attachments/assets/ce6afebd-3a07-4fc3-97db-aeb2ca1bb944)

As colunas U e V são preenchidas automaticamente. A coluna W deve ser preenchida manualmente com comentários que expliquem de maneira clara e sucinta os conteúdos das propriedades.
A coluna X identifica cada grupo de propriedades com um valor formado pelos 4 primeiros caracteres do grupo e sequencialmente numerado desde 100. É utilizada para manter uma indexação de cada grupo. A coluna Y é reservada para futuro desenvolvimento.

![Properties_02](https://github.com/user-attachments/assets/52e10c03-a157-4870-bb0d-b5320ced9f08)

### Preenchimento do arquivo de Classes e Fatos de cada Domínio.
A planilha de classes define a estrutura hierárquica dos conceitos com as condições de existência. As classes são definidas em Maiúsculas com as palavras separadas por pontos. A coluna F que **não pode ter classes repetidas**, por isso essa coluna tem uma regra de verificar e destacar células repetidas. A colunas G a K são utilizadas para colocar condições existenciais (universais e particulares). Cada condição faz referência a uma ou mais condições de existência.

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

Procurou-se facilitar a escrita eliminando a necessidade de colocar o namespace da ontologia antes dos nomes de classes e propriedades.
No arquivo OWL gerado cada classe ou propriedade é precedida pelo namespace da ontologia (bim:Classe). Essa concatenação será feita pelo aplicativo.

As colunas L M N O são preenchidas automaticamente. A coluna P é preenchida manualmente com explicação clara e breve sobre o conteúdo da classe definida na coluna F. A coluna Q é a tradução a outro idioma do conteúdo da coluna P. Para preencher pode ser utilizada a fórmula:

    * =TRADUZIR(P20; "pt"; "es")

![PreenchimentoClasses_02](https://github.com/user-attachments/assets/a3748c49-8bfa-44e4-845d-30ab7c09f176)
