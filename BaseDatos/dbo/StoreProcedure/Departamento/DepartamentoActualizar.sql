﻿CREATE PROCEDURE [dbo].[DepartamentoActualizar]
	@Id_Departamento INT= NULL

AS
	BEGIN 
	SET NOCOUNT ON

	SELECT 
	   Descripcion
	   , Ubicacion
	  , Estado
	FROM Departamentos
	WHERE (@Id_Departamento IS NULL OR Id_Departamento=@Id_Departamento)

	END
