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

#### Arquivos OWL e TTL resultado do processo. Podem ser importados no Protégé para verificação.
#### As Classes IFC e Categorias de Revit (OST_) foram ordenadas de modo a ter os conceitos comuns (colunas B C D E).
#### Pode acontecer que algum conceito esteja presente num dos modelos de informação apenas. 
#### Na planilha de axiomas foram incorporadas 4 colunas 

  * Correspondência da classe IFC com a categoria de Revit
  * A natureza da classe
  * A disciplina da classe
  * O tema da classe

#### O trabalho está em processo de desenvolvimento portanto, os arquivos no repositório são continuamente atualizados e as mudanças podem ser de diversos graus.

![Arq_Ene_01](https://github.com/user-attachments/assets/da6c3391-6174-41a4-b9ef-fa75fc6c4327)

![Arq_Ilu_01](https://github.com/user-attachments/assets/f17696c7-6f43-4f68-ac11-411b04bf8fcf)

![Arq_Aud_01](https://github.com/user-attachments/assets/79206638-50d7-43b4-b778-78f5f1bc49b4)



