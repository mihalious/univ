<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html"/>

    <xsl:template match="Professors">
		
		<table border ="1">
			<tr>
				<xsl:for-each select="//Faculty">
					<tr>						
						<td>
							<table border ="1">
								<tr>
									<p allign ="left">Faculty</p>
									<p allign ="left">
										<xsl:value-of select="@FACULTY"/>
									</p>
								</tr>
							</table>
						</td>
						<xsl:for-each select="//Professor">
							<tr>
								<td>
									<table border ="1">
										<tr>
											<p allign ="left">Name</p>
											<p allign="left">
												<xsl:value-of select="@NAME"/>
											</p>
										</tr>
										<tr>
											<p allign ="left">Department</p>
											<p allign="left">
												<xsl:value-of select="@DEPARTMENT"/>
											</p>
										</tr>
										<tr>
											<p allign ="left">Section</p>
											<p allign="left">
												<xsl:value-of select="@SECTION"/>
											</p>
										</tr>
										<tr>
											<p allign ="left">Cathedra</p>
											<p allign="left">
												<xsl:value-of select="@CATHEDRA"/>
											</p>
										</tr>
										<tr>
											<p allign ="left">Proffecion</p>
											<p allign="left">
												<xsl:value-of select="@PROFFECION"/>
											</p>
										</tr>
										<tr>
											<p allign ="left">Occupation</p>
											<p allign="left">
												<xsl:value-of select="@OCCUPATION"/>
											</p>
										</tr>
									</table>
								</td>
							</tr>
						</xsl:for-each>
					</tr>
				</xsl:for-each>
			</tr>
		</table>
    </xsl:template>
</xsl:stylesheet>
