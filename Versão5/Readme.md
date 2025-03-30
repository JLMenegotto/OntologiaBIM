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

  * Pasta **ABNT** aloca ontologias com o sistema de classificação da construção **NBR 15.965** ordenado pelas suas Partes.
  * Pasta **AMBI** aloca ontologias com conceitos espaciais e Fatos do **Instituto de Macromoléculas da UFRJ**.
  * Pasta **CROM** aloca ontologia con conceitos **cromáticos**. 
  * Pasta **CRON** aloca ontologia con conceitos **temporais**. 
  * Pasta **CSUS** aloca ontologias com conceitos normativos e Fatos do **Sistema Único de Saúde**, especificamente o caderno do SomaSUS.
  * Pasta **OBIM** aloca ontologia com conceitos de **objetos BIM**, com categorias Revit e classes IFC.
  * Pasta **URBA** aloca ontologia com conceitos **Urbanos** e Fatos da cidade de **Rio de janeiro**.

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

<p align="justify">O botão <b>Criar</b> executa a construção da ontologia especificada no campo 1. O botão <b>Extrair</b> executa uma função ainda não implementada para extrair os fatos ontológicos do modelo BIM, utilizando os esquemas criados. Nos campos de temas 1 e 2 são especificados os domínios das ontologias que serão criadas. Segue a lista de valores numéricos permitidos.<br></b></p>

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




