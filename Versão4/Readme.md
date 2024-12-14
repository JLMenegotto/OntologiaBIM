# Construtor de Ontologias BIM GIS. Versão 4.0 
<sub> **_Prof. José Luis Menegotto._**</sub> 
+ <sub> **_DEG/POLI/UFRJ. Escola Politécnica da UFRJ._**</sub>
+ <sub> _PEU Programa de Pós-graduação em Engenharia Urbana_</sub>
+ <sub> _PPE Programa de Pós-graduação em Estruturas_</sub>

## Observações 

#### Na versão 4, que é a mais recente do construtor, foi modificada a forma de leitura do arquivo Excel para permitir estruturar de modo menos homogêneo a planilha de axiomas de Classes.
#### Para as Classes IFC que não tenham uma categoria correlativa direta em Revit é sugerida uma ou várias categorias. Foi preparada uma anotação rdfs:label específica informada no RDF.

	  Class: ifc:Gerador_Solar
		SubClassOf: ifc:ENE_Insumos_Geração
		Annotations: rdfs:label "Classe IFC ou Categoria Revit:   IfcSolarDevice"@pt
		Annotations: rdfs:label "Categorias de Revit relacionadas:  OST_ElectricalEquipmentt"@pt
		Annotations: rdfs:label "ENE_Projeto"@pt
		Annotations: rdfs:label "ENE_Insumos_Geração"@pt
		Annotations: rdfs:label "Gerador_Solar"@pt
		Annotations: rdfs:label "bim-key_850_4"@pt  

#### As Classes IFC e Categorias de Revit (OST_) foram ordenadas de modo a ter os conceitos comuns (colunas B C D E).
#### Pode acontecer que algum conceito esteja presente num dos modelos de informação apenas. 
#### Na planilha de axiomas foram incorporadas 4 colunas 

  * Correspondência da classe IFC com a categoria de Revit
  * A natureza da classe
  * A disciplina da classe
  * O tema da classe




#### O trabalho está em processo de desenvolvimento portanto, os arquivos no repositório são continuamente atualizados e as mudanças podem ser de diversos graus.

![Vista_INC](https://github.com/user-attachments/assets/24b8b37b-f52d-43e7-bbe8-805db847c105)

![ARQ_Mobiliários](https://github.com/user-attachments/assets/859a65e4-01ba-44e3-b07d-7be2207c8ed2)

![Vista_01](https://github.com/user-attachments/assets/10623359-40ab-4ae5-b43f-349f434f230e)


