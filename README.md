#AssemblyMaker#

##Version##
Assembly Maker v1.0  
2013/07/02 by Neil Meredith <nmeredith@gehrytech.com>  

##Requirements##
Digital Project V1R5 or CATIA V5-6R2012 (aka R22)  

##Description##
Inserts a Part/Product in to an assembly and then constrains the axis system of new part/product to a selection of axis system.  

##Usage##
Open "ContextModel.CATProduct" (and load in Design Model if you are using the Cache system).  
Run AssemblyMaker application  
Select any of the axis systems in the driver part "ContextModel_DRV"  
Select the part/product to instantiate (for example "/AssemblyModel/PanelAssembly.CATProduct")  
Execute to run the program  
Close to window to Quit AssemblyMaker

##Notes##
Axis systems between the various parts should match "handendness"  
Axis systems in the driver part and in the assembly should be published (see sample parts)  
All parts should be saved prior to running the AssemblyMaker  
The 1st publication in the assembly part/product will be used in creating the assembly constraints  