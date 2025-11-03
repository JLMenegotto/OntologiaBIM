### Construtor de Ontologias BIM GIS. Versão 5.00.
>**Prof. José Luis Menegotto**<br>
>**jlmenegotto@poli.ufrj.br**<br>
>Escola Politécnica da UFRJ - Departamento de Expressão Gráfica.<br>
>PEU Programa de Pós-graduação em Engenharia Urbana<br>
>PPE Programa de Pós-graduação em Estruturas<br>

##### Instalação para executar em Revit como API 
###### Estrutura de pastas

Na API com data em 20 de maio foi modificada a arquitetura do processamento das planilhas obtendo um ganho considerável de performance.

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

<p align="justify">O botão <b>Criar</b> executa a construção da ontologia especificada no campo 1. O botão <b>Extrair</b> executa uma função ainda não implementada para extrair os fatos ontológicos do modelo BIM utilizando os esquemas criados. 
O campo 1 especifica o domínio da ontologia que será criada. Deve ingressar o valor, pressionar enter ou cliclar na pequena seta azul do campo. Podem ser processadas mais de uma ontologia indicando no segundo campo o número da última ontologia que se deseja processar.<br></b></p> 

<p align="justify">Segue a lista de valores numéricos permitidos.<br></b></p>

    * 0  Processa OBIM Categorias Revit e Classes IFC
    * 1  Processa ABNT 15965_0M  (Materiais)
    * 2  Processa ABNT 15965_0P  (Propriedades)
    * 3  Processa ABNT 15965_1D  (Disciplinas)
    * 4  Processa ABNT 15965_1F  (Fases)
    * 5  Processa ABNT 15965_1S  (Serviços)
    * 6  Processa ABNT 15965_2C  (Recursos da construção - Materiais de construção)
    * 7  Processa ABNT 15965_2N  (Recursos da construção - Recursos Humanos)
    * 8  Processa ABNT 15965_2Q  (Recursos da construção - Equipamentos)
    * 9  Processa ABNT 15965_3E  (Elementos)
    * 10 Processa ABNT 15965_3R  (Resultados da construção)
    * 11 Processa ABNT 15965_4A  (Ambientes)
    * 12 Processa ABNT 15965_4U  (Unidades)                                                      
    * 13 Processa ABNT 15965_5I  (Informação)                                                     
    * 14 Processa CSUS_2Q Caderno SomaSUS (Equipamentos)                                                   
    * 15 Processa CSUS_4A Caderno SomaSUS (Ambientes)                                                            
    * 16 Processa CSUS_4U Caderno SomaSUS (Unidades Funcionais)                                                    
    * 17 Processa CSUS_5I Caderno SomaSUS (Volumes)                                                     
    * 18 Processa Conceitos urbanos URBA_Rio                                                 
    * 19 Processa Conceitos temporais CRONO                                             
    * 20 Processa Conceitos cromáticos CROMA 
    * 21 Processa Conceitos de documentação DOCUM   
                                                       
O campo 2 serve para apontar a segunda ontologia a ser criada. Inicialmente será configurado com o mesmo valor digitado no campo1. Caso queira apenas uma ontologia mantenha esse valor.   

#### Prompt de execução
Durante a execução é informado o andamento la linha de Prompt de Revit.

![Iface2](https://github.com/user-attachments/assets/78d6d549-5189-4757-89c7-174a65a926e9)

