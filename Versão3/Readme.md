# Construtor de Ontologias BIM GIS. Versão 3.00.
<sub> **_Prof. José Luis Menegotto._**</sub> 
+ <sub> **_DEG/POLI/UFRJ. Escola Politécnica da UFRJ._**</sub>
+ <sub> _PEU Programa de Pós-graduação em Engenharia Urbana_</sub>
+ <sub> _PPE Programa de Pós-graduação em Estruturas_</sub>
## 
#### Versão 3.00. Para executar em como API em Revit 
Nesta versão foram modificados quatro aspectos:  
 
 * A estrutura de classes e propriedades dos arquivos Excel.  
 * Programado para executar como API em Revit.  
 * O programa cria o arquivo owl em **sintaxe Manchester** e um arquivo ttl em **sintaxe Turtle**.

### Instalação:
 1. Criar as pastas  
      * **C:\APIBIM\Onto**  
      * **C:\APIBIM\Onto\Ico**  
 2. O arquivo **ONTOBIM_2024.dll** deve ser colocado na pasta **C:\APIBIM\Onto**.  
 3. Os arquivos **Png** da pasta Ico devem ser colocadados em **C:\APIBIM\Onto\Ico**.  
 4. Incorporar o conteúdo do arquivo **ONTO.addin** na lista de aplicações do seu sistema que estão na pasta **C:\ProgramData\Autodesk\Revit\Addins\2024**  
    Caso decida instalar a API numa outra pasta da sua preferência, deverá alterar o caminho presente no conteúdo do arquivo ONTO.addin  

![OntoAddin](https://github.com/user-attachments/assets/77f41887-582a-409d-8782-51179bcf8e6f)

### Interface:

![Iface](https://github.com/user-attachments/assets/66a63096-3c9e-42e0-a036-4d1e134de7a2)

O botão principal executa a construção da ontologia especificada no campo 1.

No campo 1 é especificado o domínio da ontologia que será criada.  
O campo 2 ainda não tem uma função definida, mas será utilizado na próxima versão da API.  
Durante a execução é informado o andamento la linha de Prompt de Revit.

![Iface2](https://github.com/user-attachments/assets/78d6d549-5189-4757-89c7-174a65a926e9)

## **Exemplos com filtros SPARQL em plataforma Yasgui-Triply usando recursos RDF**
- [Exemplo 01: Filtro SPARQL](https://triplydb.com/JoseLuisMenegotto/OBIM/sparql#query=Prefix%20arq%3A%20%3Chttps%3A%2F%2Fjlmenegotto.wixsite.com%2Fjlmenegotto-bim%23%3E%0A%20%20%20%20%23%20Encontrar%20tipos%20que%20contenham%20%22Vidro%22%20%20%20%0A%20%20%20%20Select%20%3Fr1%20%3Fo1%20%3Ft1%20%0A%20%20%20%20Where%0A%20%20%20%20%7B%0A%20%20%20%20%20%20%20%20%20%20%20%3Fr1%20%20arq%3Adescri%C3%A7%C3%A3o%20%3Fo1%20%3B%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%20%20arq%3Atipo%20%3Ft1%20.%0A%20%20%20%20%20%20%20%20%20%20%20filter%20%28contains%20%28str%20%28%3Ft1%29%2C%20%22Vidro%22%29%29%20%0A%20%20%20%20%7D&endpoint=https%3A%2F%2Fapi.triplydb.com%2Fdatasets%2FJoseLuisMenegotto%2FOBIM%2Fsparql&tabTitle=Query&outputFormat=Table)

## **Exemplos com filtros SPARQL em plataforma AllegroGraph usando recursos RDF**
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


