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

  * Pasta **ABNT** aloca ontologias com o sistema de classificação da construção **NBR 15.965** ordenado pelas suas Partes.
  * Pasta **CSUS** aloca ontologias com elementos do **Sistema Único de Saúde**, especificamente o caderno do SomaSUS.
  * Pasta **OBIM** aloca ontologia com conceitos de **objetos BIM**, com as categorias Revit e classes IFC.
  * Pasta **URBA** aloca ontologia com conceitos **Urbanos** e fatos da cidade de Rio de janeiro.
  * Pasta **CRON** aloca ontologia con conceitos **temporais**. 

As Classes IFC e Categorias de Revit (OST_) foram ordenadas de modo a ter os conceitos comuns (colunas B C D E). <br> 
Pode acontecer que algum conceito esteja presente num dos modelos de informação apenas. <br> 
Na planilha de axiomas foram incorporadas colunas que definem Anotações sobre a Classe. <br>
Foi completada a tradução ao español de cada classe e categoria. <br>
O trabalho está em processo de desenvolvimento portanto, os arquivos no repositório são continuamente atualizados e as mudanças podem ser de diversos graus. <br>

Para abrir a ontologia pode-se baixar e instalar o editor [Protégé](https://protege.stanford.edu/) da Universidade de Stanford.

## Exemplos de grafos com OWLVIZ
As classes em amarelo são as definidas, as que figuram em laranja são as relações de equivalência entre classes. <br>
O texto "is-a" nas setas deve ser interpretado como uma relação entre as classes. <br>

#### Ambientes

![Ambiente_01](https://github.com/user-attachments/assets/d5b41efa-17f8-4fba-8b7d-ad4f4d39df58)

#### Sistema de controle mecânico

![Controle_01](https://github.com/user-attachments/assets/5f49fde5-5580-436e-b0f2-a18610aa9cbf)

#### Zoneamento

![Zonas_01](https://github.com/user-attachments/assets/361452f1-7820-449c-8bf2-ca03aad7b2c2)

#### Acessório

![Fixador_01](https://github.com/user-attachments/assets/3f2f0cc0-a52b-4899-8a61-fe8744d2fa20)



