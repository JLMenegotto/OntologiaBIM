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

 * [**Pasta ABNT**](https://github.com/JLMenegotto/OntologiaBIM/tree/main/Vers%C3%A3o5/ABNT) ontologias com o sistema de classificação da construção **NBR 15.965** ordenado seus códigos como Fatos conhecidos.
 * [**Pasta AMBI**](https://github.com/JLMenegotto/OntologiaBIM/tree/main/Vers%C3%A3o5/AMBI) ontologia com conceitos espaciais e Fatos conhecidos do **Instituto de Macromoléculas da UFRJ**.
 * [**Pasta CROM**](https://github.com/JLMenegotto/OntologiaBIM/tree/main/Vers%C3%A3o5/CROM) ontologia con conceitos **cromáticos** e alguns Fatos conhecidos de paletas cromáticas. 
 * [**Pasta CRON**](https://github.com/JLMenegotto/OntologiaBIM/tree/main/Vers%C3%A3o5/CRON) ontologia com conceitos de elementos **temporais**. 
 * [**Pasta CSUS**](https://github.com/JLMenegotto/OntologiaBIM/tree/main/Vers%C3%A3o5/CSUS) ontologias com conceitos normativos e Fatos conhecidos do **Sistema Único de Saúde**, especificamente o caderno do SomaSUS.
 * [**Pasta INFR**](https://github.com/JLMenegotto/OntologiaBIM/tree/main/Vers%C3%A3o5/INFR) ontologia com conceitos **Infraestrutura** e Fatos conhecidos da cidade de **Rio de janeiro** ou de instituições como o   	INMET.
 * [**Pasta DOCU**](https://github.com/JLMenegotto/OntologiaBIM/tree/main/Vers%C3%A3o5/DOCU) ontologia com conceitos de **Documentação** e com alguns fatos conhecidos referentes a Leis e Decretos como exemplo.
 * [**Pasta META**](https://github.com/JLMenegotto/OntologiaBIM/tree/main/Vers%C3%A3o5/META) ontologia com conceitos de **Estrutura Metálica** e com alguns fatos conhecidos referentes a catálogo de perfis laminados.
 * [**Pasta TUBO**](https://github.com/JLMenegotto/OntologiaBIM/tree/main/Vers%C3%A3o5/TUBO) ontologia com conceitos de **Tubulações** e com alguns fatos conhecidos referentes a catálogo de fabricantes do setor.
 * [**Pasta VANT**](https://github.com/JLMenegotto/OntologiaBIM/tree/main/Vers%C3%A3o5/VANT) ontologia com conceitos de **Veículos Aereos não Tripulados** e processos de manutenção predial usando drone de inspeção e aquisição de imagens.  
 * [**Pasta ARQU**](https://github.com/JLMenegotto/OntologiaBIM/tree/main/Vers%C3%A3o5/ARQU) ontologia com conceitos de **Arquitetura** e com alguns fatos conhecidos.
 * [**Pasta TASB**](https://github.com/JLMenegotto/OntologiaBIM/tree/main/Vers%C3%A3o5/TASB) ontologia com conceitos da **Taxonomia Sustentável Brasileira** com fatos conhecidos. 
 * [**Pasta VEGE**](https://github.com/JLMenegotto/OntologiaBIM/tree/main/Vers%C3%A3o5/VEGE) ontologia com conceitos de **Vegetação** com conhecimento utilizado em projetos paisagísticos.

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
 5. Na pasta **C:\Construtor_Onto** colocar os arquivos **Mapa_Classes.txt, Mapa_Ontologia.txt e Mapa_Propriedades.txt**. Eles são utilizados para criar os filtros SPARQL personalizados para extrair diversos conteúdos e propriedades requeridas das ontologias.
 6. Dentro de **C:\Construtor_Onto** o aplicativo criará as subpastas **ABNT, ARQU, CROM, CRON, CSUS, DOCU, INFR, META, TUBO, VANT, VEGE, TASB, X_Dataset**. Nelas pode colocar os arquivos Excel de cada tema e os arquivos owl e ttl com os conteúdos das ontologias.

![Pastas](https://github.com/user-attachments/assets/bf1f353e-b34b-4bf3-b80d-db9a12ea78e5)

#### Arquivo Addin para Revit
Incorporar o conteúdo do arquivo **ONTO2025.addin** na lista de aplicações do seu sistema. A pasta que contém do arquivo de addins é **C:\ProgramData\Autodesk\Revit\Addins\2024**. Caso decida instalar a API numa outra pasta da sua preferência, deverá alterar o caminho presente no conteúdo do arquivo ONTO2025.addin  

![Onto2025Addin](https://github.com/user-attachments/assets/902bcc39-1c02-4f54-a717-3bc361a255c1)

#### Interface:
<img width="354" height="103" alt="Interface" src="https://github.com/user-attachments/assets/15aa963f-afe1-41ee-8951-f224f47a50ac" />

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

### Exemplo de filtro SPARQL gerado a partir do acionamento do comando Extrair.
As propriedades extraídas podem ser adicionadas ou retiradas do arquivo Mapa_Propriedades.txt. Cada linha desse arquivo representa a propriedade e o nome arbitrário da variável Sparql. 
Por exemplo descrição,des. A aplicação do construtor criará o filtro automaticamente de acordo à solicitação ingressada no campo Classe da interface. Os campos Individuo 1, 2 e 3 foram preparados para futuro uso. 

    * PREFIX rdf:  <http://www.w3.org/1999/02/22-rdf-syntax-ns#>  
    * PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>      
    * PREFIX owl:  <http://www.w3.org/2002/07/owl#>             
    * PREFIX bim:  <https://github.com/JLMenegotto/RepoOnto#>   
    * SELECT ?ind ?cla  
    * (IF(BOUND(?CatRevit), ?CatRevit , "-----") AS ?rev)
    * (IF(BOUND(?ClasseIfc), ?ClasseIfc , "-----") AS ?cif)
    * (IF(BOUND(?ABNT), ?ABNT , "-----") AS ?nbr)
    * (IF(BOUND(?descrição), ?descrição , "-----") AS ?des)
    * (IF(BOUND(?categoriarevit), ?categoriarevit , "-----") AS ?cat)
    * (IF(BOUND(?classeifc), ?classeifc , "-----") AS ?ifc)
    * (IF(BOUND(?ide), ?ide , "-----") AS ?id)
    * (IF(BOUND(?nome), ?nome , "-----") AS ?nom)
    * (IF(BOUND(?método), ?método , "-----") AS ?met)
    * (IF(BOUND(?modelo), ?modelo , "-----") AS ?mod)
    * (IF(BOUND(?resistênciaaofogo), ?resistênciaaofogo , "-----") AS ?rfogon)
    * (IF(BOUND(?abertaem), ?abertaem , "-----") AS ?aber)
    * (IF(BOUND(?latitude), ?latitude , "-----") AS ?glat)
    * (IF(BOUND(?longitude), ?longitude , "-----") AS ?glon)
    * (IF(BOUND(?altitude), ?altitude , "-----") AS ?galt)
    * (IF(BOUND(?tema), ?tema , "-----") AS ?tem)
    * (IF(BOUND(?unidadefuncional), ?unidadefuncional , "-----") AS ?ufu)
    * (IF(BOUND(?atividade), ?atividade , "-----") AS ?ati)
    * (IF(BOUND(?aptaparacalçada), ?aptaparacalçada , "-----") AS ?apta)
    * (IF(BOUND(?bioma), ?bioma , "-----") AS ?bio)
    * WHERE 
    * {
    * 	?ind rdf:type ?cla .
    * 	FILTER(REGEX(STR(?cla) , "Palmeira" )) 
    * 	OPTIONAL { ?cla bim:CatRevit ?CatRevit . }
    * 	OPTIONAL { ?cla bim:ClasseIfc ?ClasseIfc . }
    * 	OPTIONAL { ?cla bim:ABNT ?ABNT . }
    * 	OPTIONAL { ?ind bim:descrição ?descrição . }
    * 	OPTIONAL { ?ind bim:categoria.revit ?categoriarevit . }
    * 	OPTIONAL { ?ind bim:classe.ifc ?classeifc . }
    * 	OPTIONAL { ?ind bim:ide ?ide . }
    * 	OPTIONAL { ?ind bim:nome ?nome . }
    * 	OPTIONAL { ?ind bim:método ?método . }
    * 	OPTIONAL { ?ind bim:modelo ?modelo . }
    * 	OPTIONAL { ?ind bim:resistência.ao.fogo ?resistênciaaofogo . }
    * 	OPTIONAL { ?ind bim:aberta.em ?abertaem . }
    * 	OPTIONAL { ?ind bim:latitude ?latitude . }
    * 	OPTIONAL { ?ind bim:longitude ?longitude . }
    * 	OPTIONAL { ?ind bim:altitude ?altitude . }
    * 	OPTIONAL { ?ind bim:tema ?tema . }
    * 	OPTIONAL { ?ind bim:unidade.funcional ?unidadefuncional . }
    * 	OPTIONAL { ?ind bim:atividade ?atividade . }
    * 	OPTIONAL { ?ind bim:apta.para.calçada ?aptaparacalçada . }
    * 	OPTIONAL { ?ind bim:bioma ?bioma . }
    * }
    * ORDER BY ASC( ?ind )
    * LIMIT 2000

    * DATASET EXTRAÍDO COM O FILTRO SPARQL E ARMAZENADO NA PASTA X_Dataset. INDIVÍDUOS DA CLASSE Palmeira CADASTRADOS NA Ontologia_Veget.ttl ou Ontologia_Veget.owl

    * Buriti;Palmeira;OST_Planting;IfcGeographicElement;3E.02.12;Fruto oleoso, folhas usadas em cestaria;OST_Planting;IfcGeographicElement;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;Não;Amazônia, Cerrado
    * Butiá;Palmeira;OST_Planting;IfcGeographicElement;3E.02.12;Fruto ácido, usado em doces e licores;OST_Planting;IfcGeographicElement;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;Sim;Pampa
    * Carnaúba;Palmeira;OST_Planting;IfcGeographicElement;3E.02.12;Fonte da cera de carnaúba, muito usada na indústria;OST_Planting;IfcGeographicElement;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;Não;Caatinga
    * Coqueiro.jerivá;Palmeira;OST_Planting;IfcGeographicElement;3E.02.12;Fruto comestível, muito usada em paisagismo;OST_Planting;IfcGeographicElement;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;Sim;Mata Atlântica
    * Palmeira.azul;Palmeira;OST_Planting;IfcGeographicElement;3E.02.12;Folhas azuladas, muito usada em paisagismo tropical;OST_Planting;IfcGeographicElement;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;Sim;Cultivada
    * Palmeira.de.leque;Palmeira;OST_Planting;IfcGeographicElement;3E.02.12;Folhas em forma de leque, muito decorativa;OST_Planting;IfcGeographicElement;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;Sim;Cultivada
    * Palmeira.imperial;Palmeira;OST_Planting;IfcGeographicElement;3E.02.12;Palmeira nativa das Antilhas. De porte imponente, tem valor simbólico. Pode atingir até 40 metros de altura, com tronco liso e colunar de cor esbranquiçada, mais largo em sua base. Entre o termino do tronco e a parte onde nascem as folhas, há uma seção verde, mais grossa.. Muito usada em paisagismo de grandes áreas, como praças e entradas monumentais. Não é recomendada para calçadas estreitas devido ao porte e queda de frutos. Se atribui a Dom João VI a plantação da primeira palmeira (Palma Mater) desta espécie no Jardim Botánico de Rio de Janeiro em 1809. O seu nome faz referencia ao general americano Roy Stone (1836-1905). A rua Paysandú, de Rio de Janeiro, tem uma alameda monumental de palmeiras imperiais plantadas em 1865 por ordem de Pedro II (https://museunacional.ufrj.br/hortobotanico);OST_Planting;IfcGeographicElement;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;Não;Mata Atlântica
    * Palmeira.pata.de.elefante;Palmeira;OST_Planting;IfcGeographicElement;3E.02.12;Base engrossada, folhas finas e arqueadas;OST_Planting;IfcGeographicElement;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;Sim;Cultivada
    * Palmeira.rabo.de.peixe;Palmeira;OST_Planting;IfcGeographicElement;3E.02.12;Folhas bipartidas lembram cauda de peixe;OST_Planting;IfcGeographicElement;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;Não;Cultivada
    * Palmeira.real;Palmeira;OST_Planting;IfcGeographicElement;3E.02.12;Tronco esguio, folhas arqueadas;OST_Planting;IfcGeographicElement;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;Sim;Cultivada
    * Palmeira.talipot;Palmeira;OST_Planting;IfcGeographicElement;3E.02.12;Tronco esguio com folhas palmadas em leque, com até 5 m de envergadura. Também é chamada de palmeira-parasol ou palma de Ceilão. Após floração deve ser monitorada por especialistas, pois pode apresentar risco de queda;OST_Planting;IfcGeographicElement;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;Não;Cultivada
    * Pau.de.açaí;Palmeira;OST_Planting;IfcGeographicElement;3E.02.12;Fruto roxo escuro, muito usado em alimentação e bebidas;OST_Planting;IfcGeographicElement;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;Não;Amazônia
    * Pau.de.bacaba;Palmeira;OST_Planting;IfcGeographicElement;3E.02.12;Fruto roxo escuro, usado em bebidas regionais;OST_Planting;IfcGeographicElement;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;Não;Amazônia
    * Pau.de.pupunha;Palmeira;OST_Planting;IfcGeographicElement;3E.02.12;Fruto comestível, fonte de palmito sustentável;OST_Planting;IfcGeographicElement;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;Não;Amazônia
    * Pau.de.tucum;Palmeira;OST_Planting;IfcGeographicElement;3E.02.12;Fibra usada em cordas, fruto oleoso;OST_Planting;IfcGeographicElement;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;Não;Amazônia
    * Paxiúba;Palmeira;OST_Planting;IfcGeographicElement;3E.02.12;Palmeira de raizes aereas adventícias convergentes formando um cone destacado, de hasta 2 m, de cujo vértice inicia a estirpe solitária. Conhecida também como 'Palmeira andante', pela característica morfológica de suas raizes;OST_Planting;IfcGeographicElement;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;Não;Amazônia
    * Tamareira;Palmeira;OST_Planting;IfcGeographicElement;3E.02.12;Fruto doce e energético, muito cultivado em regiões áridas;OST_Planting;IfcGeographicElement;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;-----;Não;Cultivada
	

### Preenchimento do arquivo de Propriedades
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
