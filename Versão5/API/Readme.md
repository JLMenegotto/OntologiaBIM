#### Versão 5.00. Para executar em como API em Revit 
Nesta versão foram modificados os seguintes aspectos:  
 
 * Programado para executar como API em Revit (testado na versão Revit 2024).  
 * O programa cria o arquivo owl em **sintaxe Manchester**.

### Instalação:
 1. Criar as pastas  
      * **C:\APIBIM\Onto2025**  
      * **C:\APIBIM\Onto2025\Ico**  
 2. Colocar o arquivo **ONTOBIM_2025.dll** na pasta **C:\APIBIM\Onto2025**.  
 3. Os arquivos **Png** da pasta Ico devem ser colocadados em **C:\APIBIM\Onto2025\Ico**.  
 4. Incorporar o conteúdo do arquivo **ONTO2025.addin** na lista de aplicações do seu sistema.
    A pasta que contém do arquivo de addins é **C:\ProgramData\Autodesk\Revit\Addins\2024**  
    Caso decida instalar a API numa outra pasta da sua preferência, deverá alterar o caminho presente no conteúdo do arquivo ONTO2025.addin  

![OntoAddin](https://github.com/user-attachments/assets/77f41887-582a-409d-8782-51179bcf8e6f)

### Interface:

![Iface](https://github.com/user-attachments/assets/66a63096-3c9e-42e0-a036-4d1e134de7a2)

O botão principal executa a construção da ontologia especificada no campo 1.

No campo 1 é especificado o domínio da ontologia que será criada.  
O campo 2 ainda não tem uma função definida, mas será utilizado na próxima versão da API.  
Durante a execução é informado o andamento la linha de Prompt de Revit.

![Iface2](https://github.com/user-attachments/assets/78d6d549-5189-4757-89c7-174a65a926e9)

