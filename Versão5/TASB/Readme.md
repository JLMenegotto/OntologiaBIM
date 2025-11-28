# Construtor de Ontologias BIM GIS. Versão 5.00.
>**Prof. José Luis Menegotto**<br>
>**jlmenegotto@poli.ufrj.br**<br>
>Escola Politécnica da UFRJ - Departamento de Expressão Gráfica.<br>
>PEU Programa de Pós-graduação em Engenharia Urbana<br>
>PPE Programa de Pós-graduação em Estruturas<br>

### Pasta TASB: Ontologia com conceitos da Taxonomia Sustentável Brasileira - Prefixo bim:

A **Taxonomia Sustentável Brasileira (TSB)** é um projeto impulsionado como política de Estado desenvolvido pelo Governo do Brasil. De acordo com o documento introdutório:  

<p align="justify" style="color:#DDDDDD;"><em><small>
&nbsp;&nbsp;&nbsp;&nbsp;A Taxonomia Sustentável Brasileira é um dos instrumentos do Novo Brasil – Plano de Transformação Ecológica (PTE) do Governo Federal, iniciativa que tem por objetivo promover uma mudança nos paradigmas econômicos, tecnológicos e culturais em prol do desenvolvimento a partir de relações sustentáveis com a natureza e seus biomas, de forma a possibilitar a geração de riqueza e sua distribuição justa e compartilhada, com melhoria na qualidade de vida das gerações presentes e futuras (BRASIL, MF, 2023b). O PTE está estruturado em seis eixos, sendo a TSB parte do eixo de Finanças Sustentáveis. (Fonte: Taxonomia Sustentável Brasileira. Introdução., 2025) 
  
&nbsp;&nbsp;&nbsp;&nbsp; A TSB consiste em um sistema de classificação que define, de maneira nítida, objetiva e com base científica, atividades, 
ativos e/ou categorias de projetos que contribuem substancialmente para objetivos climáticos, ambientais e/ou sociais, por meio de critérios específicos baseados na ciência (BRASIL, MF, 2023a). <br><br>
</small></em></p>

A ontologia está sendo desenvolvida utilizando as categorias definidas pela **TSB**. O desenvolvimento não pretende substituir a documentação oficial original publicada pelo Governo Federal. Trata-se de um exercício acadêmico que visa a integração da documentação da TSB, publicada em arquivos pdf, formalizando-a em ontologias OWL e TTL para leitura de humanos e máquina em ambientes BIM. Esses documentos podem ser abertos e consultados em Protégé ou serem integrados como conhecimento factual para que os novos agentes de IA utilizados no setor AECO possam acessar e processar.

As atividades económicas dos **Setores da TSB** e os princípios de sustentabilidade aplicados ao projeto de arquitetura e engenharia tem pontos de contato. Além dos princípios, diretrizes e salvaguardas gerais, são principalmente incorporadas as atividades econômicas (AECO) relativas ao setor F (Construção Civil) e as que se referem à diversos aspectos da infraestrutura.

À medida que a TSB evolua, a ontologia também evoluirá.

#### Relacionamento com Objetos BIM e sistemas de classificação.
Os diversos critérios de alinhamento com os princípios da Taxonomia são conectados às categorias Revit, classes IFC ou códigos como o ABNT, por meio dos indivíduos definidos na Classe **Sistema.Estudado**. 


	  Individual: bim:Sistemas.Climatização
		  Types: bim:Sistema.Estudado
		  Facts: bim:é.pertencente.a  bim:Taxonomia.TSB
		  acts: bim:categoria.revit  "[ OST_DuctSystem ]"
		  Facts: bim:classe.ifc  "[ IfcDistributionSystemAIRCONDITIONING , IfcDistributionSystemCHILLEDWATER ,  IfcDistributionSystemCOMPRESSEDAIR , IfcDistributionSystemCONDENSERWATER , IfcDistributionSystemEXHAUST ,  IfcDistributionSystemHEATING ,  IfcDistributionSystemREFRIGERATION , IfcDistributionSystemRETURN_CIRCUIT , IfcDistributionSystemVACUUM , IfcDistributionSystemVENTILATION ]"
		  Facts: bim:descrição  "Sistemas de Climatização."
		  Facts: bim:observação  "Esta instância vincula Sistemas de Climatização com as categorias, classes e demais sistemas de classificação utilizados em ambientes de projeto BIM. Também orienta sobre os critérios de alinhamento específicos do sistema."
		  Facts: bim:é.qualificada.com  bim:Critério.de.Qualificação.F01.A.a
		  Facts: bim:é.qualificada.com  bim:Critério.de.Qualificação.F01.A.b
		  Facts: bim:é.qualificada.com  bim:Critério.de.Qualificação.F03.B
		  Facts: bim:é.qualificada.com  bim:Critério.de.Qualificação.F03.D
  




  
  

#### Árvore de Classes Definidas por declarações axiomáticas (Clique na imagem para ampliar)
As ligações _"is-a"_ não devem ser entendidas literalmente como "é uma", mas entendidas como relações que existem entre as classes conectadas.

<img width="856" height="1928" alt="TSB" src="https://github.com/user-attachments/assets/5c221cf4-53c3-49e8-84d3-374ba4c23574" />


