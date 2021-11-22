<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html"/>

   
	<xsl:template match="//Faculty">
	<html>
		<body>
			<table border ="1">
			    <tr>
				    <th>Faculty</th>			     
			    </tr>
					<tr>
						<td>
							<xsl:value-of select ="@FACULTY"/>						
						</td>					
					</tr>
			</table>
			<table border ="1">
				      <TR>						
						<th>Name</th>
						<th>Department</th>
						<th>Section</th>
						<th>Cathedra</th>
						<th>Proffecion</th>
						<th>Occupation</th>
					 </TR>
				<xsl:apply-templates select ="//Professor"/>
				
			</table>			
		</body>	
	</html>

</xsl:template>

<xsl:template match="//Professor">	
<tr>
	 <td>
		<xsl:value-of select="@NAME"/>
      </td>
     <td>
	   <xsl:value-of select="@DEPARTMENT"/>
	 </td>
	 <td>
		<xsl:value-of select="@SECTION"/>
	 </td>
	 <td>
		<xsl:value-of select="@CATHEDRA"/>
	 </td>
	 <td>
	    <xsl:value-of select="@PROFFECION"/>
	 </td>
	 <td>
	    <xsl:value-of select="@OCCUPATION"/>
	 </td>
</tr>																		
	                                  
</xsl:template>
</xsl:stylesheet>




