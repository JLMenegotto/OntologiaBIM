### Construtor de Ontologias BIM GIS. Versão 5.00.
>**Prof. José Luis Menegotto**<br>
>**jlmenegotto@poli.ufrj.br**<br>
>Escola Politécnica da UFRJ - Departamento de Expressão Gráfica.<br>
>PEU Programa de Pós-graduação em Engenharia Urbana<br>
>PPE Programa de Pós-graduação em Estruturas<br>

##### Instalação para executar em Revit como API 

 1. Criar as pastas  
      * **C:\APIBIM\Onto2025**  
      * **C:\APIBIM\Onto2025\Ico**  
 2. Colocar o arquivo **ONTOBIM_2025.dll** na pasta **C:\APIBIM\Onto2025**.  
 3. Os arquivos **Png** da pasta Ico devem ser colocadados em **C:\APIBIM\Onto2025\Ico**.  
 4. Incorporar o conteúdo do arquivo **ONTO2025.addin** na lista de aplicações do seu sistema.
    A pasta que contém do arquivo de addins é **C:\ProgramData\Autodesk\Revit\Addins\2024**  
    Caso decida instalar a API numa outra pasta da sua preferência, deverá alterar o caminho presente no conteúdo do arquivo ONTO2025.addin  

![Onto2025Addin](https://github.com/user-attachments/assets/902bcc39-1c02-4f54-a717-3bc361a255c1)

##### Interface:

![Interface_2025](https://github.com/user-attachments/assets/3138138d-e57c-48d6-9ee2-128024440999)

O botão Criar executa a construção da ontologia especificada no campo 1. O botão Extrair fará a extração de fatos ontológicos do modelo BIM.
No campo 1 é especificado o domínio da ontologia que será criada. a seguir a lista de valores numéricos permitidos 

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
                                                       
O campo 2 ainda não tem uma função definida, mas será utilizado na próxima versão da API.  
Durante a execução é informado o andamento la linha de Prompt de Revit.

![Iface2](https://github.com/user-attachments/assets/78d6d549-5189-4757-89c7-174a65a926e9)

